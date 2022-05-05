# Apptentive Xamarin iOS SDK

## Register Apptentive
Register Apptentive in your Application class.

```
using ApptentiveKit.iOS;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        ...
    
        var configuration = new ApptentiveConfiguration("Your Apptentive Key", "Your Apptentive Signature");
        Apptentive.Shared.Register(configuration, (registered) => System.Console.WriteLine("Registered"));

        return true;
    }
}
```
Make sure you use the Apptentive App Key and Signature for the iOS app you created in the Apptentive console. Sharing these keys between two apps, or using keys from the wrong platform is not supported, and will lead to incorrect behavior. You can find them [here](https://be.apptentive.com/apps/current/settings/api).

## Events

Events record user interaction. You can use them to determine if and when an Interaction will be shown to your customer. You will use these Events later to target Interactions, and to determine whether an Interaction can be shown. You trigger an Event with the `Engage()` method. This will record the Event, and then check to see if any Interactions targeted to that Event are allowed to be displayed, based on the logic you set up in the Apptentive Dashboard.
  
```
var engageButton = FindViewById<Button>(...);
engageButton.Click += delegate
{
    Apptentive.Shared.Engage("my_event", this, (engaged) => Console.WriteLine("Event engaged: " + engaged) ); // assuming 'this' is a ViewController
};
```

## Message Center

See: [How to Use Message Center](https://learn.apptentive.com/knowledge-base/how-to-use-message-center/)

### Showing Message Center

With the Apptentive Message Center your customers can send feedback, and you can reply, all without making them leave the app. Handling support inside the app will increase the number of support messages received and ensure a better customer experience.

Message Center lets customers see all the messages they have send you, read all of your replies, and even send screenshots that may help debug issues.

Add [Message Center](http://learn.apptentive.com/knowledge-base/apptentive-android-sdk-features/#message-center) to talk to your customers.

Find a place in your app where you can add a button that opens Message Center. Your setings page is a good place.

```
public partial class ViewController : UIViewController
{
    ...
    
    public override void ViewDidLoad()
    {
        base.ViewDidLoad();

        MessageCenterButton.TouchUpInside += delegate
        {
            Apptentive.Shared.PresentMessageCenter(this, (presented) => Console.WriteLine("Message center presented: " + presented) );
        };
    }
}
```

### Checking Unread Message Count

You can also check to see how many messages are waiting to be read in the customer’s Message Center.
```
var unreadMessageCount = Apptentive.Shared.UnreadMessageCount;
if (unreadMessageCount > 0)
{
    Console.WriteLine("You have {0} unread messages", unreadMessageCount);
}
```

### Unread Message Count Notification

You can receive a callback when a new unread message comes in. You can use this callback to notify your customer, and display a badge letting them know how many unread messages are waiting for them. Because this listener could be called at any time, you should store the value returned from this method, and then perform any user interaction you desire at the appropriate time.
```
public partial class ViewController : UIViewController
{
    private IDisposable Observer = null;
  
    public override void ViewDidLoad()
    {
        base.ViewDidLoad();
        
        ...
        
        Observer = Apptentive.Shared.AddObserver("unreadMessageCount", Foundation.NSKeyValueObservingOptions.New, (NSObservedChange obj) =>
        {
          UnreadMessagesTextView.Text = "Unread messages: " + Apptentive.Shared.UnreadMessageCount;
        });
    }
}
```

### Push Notifications

Apptentive can send push notifications to your app when you reply to your customers. Your replies are more likely to be seen by your customer when you do this. To set up push notifications, you will need to supply your push credentials on the Integrations page of your Apptentive dashboard, send us the ID that your push provider uses to identify the device, and call into our SDK when a user opens a push notification.

To use Apptentive push, you will need to add code to your application delegate, configure your app for push in the developer portal, and supply your push certificate and private key in your Apptentive dashboard.

Your app will have to register for remote notifications (we recommend registering for alert and sound notifications) as follows:

```

using UserNotifications;

...

UNUserNotificationCenter.Current.RequestAuthorization((UNAuthorizationOptions.Sound | UNAuthorizationOptions.Alert), (Boolean Success, NSError Error) =>
{
    if (Success) {
        Console.WriteLine("Successfully got notification permission.");
    }
    else if (Error != null)
    {
        Console.WriteLine("Failed to get notification permission: " + Error.LocalizedDescription);
    }
});

UIApplication.SharedApplication.RegisterForRemoteNotifications();

UNUserNotificationCenter.Current.Delegate = Apptentive.Shared;

UIApplication.SharedApplication.RegisterUserNotificationSettings(pushSettings);
UIApplication.SharedApplication.RegisterForRemoteNotifications();
```

When the registration succeeds, your application delegate will have to pass the device token on to the Apptentive SDK:

```
public override void RegisteredForRemoteNotifications(UIApplication application, NSData deviceToken)
{
    Apptentive.Shared.SetRemoteNotificationDeviceToken(deviceToken);
}
```

Your application delegate will also have to forward any push and local notifications that it receives to the Apptentive SDK:

```
public override void DidReceiveRemoteNotification(UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler)
{
    Apptentive.Shared.DidReceiveRemoteNotification(userInfo, completionHandler);
}
```

In place of `this.Window.RootViewController`, you should determine which of your app’s view controllers is currently being displayed and pass that in as the value for the from argument. You can pass nil for the view controller parameter and the SDK will create a new window to present Message Center in.

If you are using Apple’s UserNotifications framework, you will need to replace the second method listed above with the following:

```
public void DidReceiveNotificationResponse(UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler)
{
    Apptentive.Shared.DidReceveUserNotification(response, completionHandler);
}
```

If your app supports both Apptentive notifications and notifications from another source, the Apptentive "DidReceive" methods above return a boolean value that indicates that the notification was intended for the Apptentive SDK. For methods that accept a completionHandler, it will be called by the Apptentive SDK only if the notification is intended for it, so it is your app's responsibility to call the completion handler in the event that the Apptentive method returns false.

### Provisioning Your App For Push

In the Apple Developer Portal's Certificates, Identifiers and Profiles section, configure your app's App ID for push. The Apptentive push server only supports sending push notifications to the production environment, so you will not need to configure it for the development push environment.

Then create a new provisioning profile for your app. We recommend creating an ad-hoc provisioning profile for testing push in addition to the iOS App Store profile you will need to submit your app to the App Store. Download the provisioning profile(s) you created and then open them in Xcode.

Next, select your app project in Xcode's Project Navigator and select your app target from the list (or dropdown menu, if the list is collapsed). On the General tab, choose the provisioning profile you just created in the Signing section. Then switch to the Capabilities tab and turn on Push Notifications, and in the Background Modes section, select Remote Notifications.

### Supplying Push Certificate and Private Key

Finally, you'll need to export the push certificate you created as part of the provisioning process and upload it to your Apptentive dashboard.

To do this, launch Keychain Access and choose the My Certificates category in the "login" keychain. You will see a certificate with a name like "Apple Production IOS Push Services: com.my.app.id" (where com.my.app.id is your app's bundle indentifier). Select it and choose File > Export Items…. You will need to encrypt the exported certificate and private key with a password of your choosing, and export in the PKCS-12 (.p12) format.

Then go to the Integrations page of your Apptentive dashboard in your browser, and expand the Apptentive Push section. Enter the password you chose when exporting your .p12 file into the Push Certificate Password field, and drag the .p12 file into the Push Certificate field. You can choose to enable a notification sound, and even specify the name of an audio file in your app's bundle to play in place of the default sound.

Then click the Save button and switch on the Active toggle.

### Testing Push

Because the Apptentive push service works only with the production environment, you will have to take a few extra steps to be able to test it.

First, you will need to compile using an ad-hoc provisioning profile for sigining (configured in the Project Options dialog). You will need to use the Release configuration when running.

At this point you should be able to run your app, send a message in Message Center and close your app, reply in your Apptentive dashboard, and receive a push notification.

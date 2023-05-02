using System;

using UIKit;
using Foundation;
using ApptentiveKit.iOS;

namespace ApptentiveSample
{
    public partial class ViewController : UIViewController
    {
        private IDisposable Observer = null;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            EngageButton.TouchUpInside += delegate {
                var eventName = EventNameTextField.Text;
                Apptentive.Shared.Engage(eventName, this, (engaged) => Console.WriteLine("Event engaged: " + engaged));
            };

            MessageCenterButton.TouchUpInside += delegate {
                Apptentive.Shared.PresentMessageCenter(this, (presented) => Console.WriteLine("Message center presented: " + presented));
            };

            CanShowInteractionButton.TouchUpInside += delegate {
                var eventName = EventNameTextField.Text;
                Apptentive.Shared.QueryCanShowInteraction(eventName, (canShow) => {
                    var alertController = UIAlertController.Create("Apptentive", canShow ? "Yes" : "No", UIAlertControllerStyle.Alert);
                    alertController.AddAction(UIAlertAction.Create("Close", UIAlertActionStyle.Cancel, (obj) => alertController.DismissViewController(true, null)));
                    PresentViewController(alertController, true, null);
                });
            };

            Observer = Apptentive.Shared.AddObserver("unreadMessageCount", Foundation.NSKeyValueObservingOptions.New, (NSObservedChange obj) =>
            {
                UpdateUnreadMessagesCount();
            });
        }

        private void UpdateUnreadMessagesCount()
        {
            UnreadMessagesTextView.Text = "Unread messages: " + Apptentive.Shared.UnreadMessageCount;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            if (segue.Identifier == "Authentication")
            {
                AuthenticationViewController VC = (AuthenticationViewController)segue.DestinationViewController;

                // do stuff
            }
            else if (segue.Identifier == "PersonData")
            {
                DataViewController VC = (DataViewController)segue.DestinationViewController;

                VC.Source = DataViewControllerSource.Person;
            }
            else if (segue.Identifier == "DeviceData")
            {
                DataViewController VC = (DataViewController)segue.DestinationViewController;

                VC.Source = DataViewControllerSource.Device;
            }
        }
    }
}

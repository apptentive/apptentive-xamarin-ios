using System;

using UIKit;
using ApptentiveKit.iOS;
using Foundation;

namespace ApptentiveSample
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            unreadMessageCount.TouchUpInside += delegate {
                UpdateUnreadMessagesCount();
            };

            EngageButton.TouchUpInside += delegate {
                var eventName = EventNameTextField.Text;
                Apptentive.Shared.Engage(eventName, this, (engaged) => Console.WriteLine("Event engaged: " + engaged) );
            };

            MessageCenterButton.TouchUpInside += delegate {
                Apptentive.Shared.PresentMessageCenterFromViewController(this, (presented) => Console.WriteLine("Message center presented: " + presented) );
            };

            CanShowInteractionButton.TouchUpInside += delegate {
                var eventName = EventNameTextField.Text;
                Apptentive.Shared.QueryCanShowInteractionForEvent(eventName, (canShow) => {
                    var alertController = UIAlertController.Create("Apptentive", canShow ? "Yes" : "No", UIAlertControllerStyle.Alert);
                    alertController.AddAction(UIAlertAction.Create("Close", UIAlertActionStyle.Cancel, (obj) => alertController.DismissViewController(true, null)));
                    PresentViewController(alertController, true, null);
                });
            };
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

            if (segue.Identifier == "PersonData")
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

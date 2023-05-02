using System;

using UIKit;
using ApptentiveKit.iOS;

namespace ApptentiveSample
{
    public partial class AuthenticationViewController : UIViewController
    {
        protected AuthenticationViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            loginButton.TouchUpInside += delegate
            {
                String JWT = keyTextField.Text.Trim();
                Apptentive.Shared.LogIn(JWT, (success, error) =>
                {
                    if (success)
                    {
                        this.NavigationController.PopViewController(true);
                    }
                    else
                    {
                        var alert = UIAlertController.Create("Login Failed", error.Description, UIAlertControllerStyle.Alert);
                        alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Cancel, null));
                    }
                });
            };

            logoutButton.TouchUpInside += delegate
            {
                Apptentive.Shared.LogOut();
                this.NavigationController.PopViewController(true);
            };

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


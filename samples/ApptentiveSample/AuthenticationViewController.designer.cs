// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ApptentiveSample
{
    [Register ("AuthenticationViewController")]
    partial class AuthenticationViewController
    {
        [Outlet]
        UIKit.UITextField keyTextField { get; set; }

        [Outlet]
        UIKit.UIButton loginButton { get; set; }

        [Outlet]
        UIKit.UIButton logoutButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (keyTextField != null) {
                keyTextField.Dispose ();
                keyTextField = null;
            }

            if (loginButton != null) {
                loginButton.Dispose ();
                loginButton = null;
            }

            if (logoutButton != null) {
                logoutButton.Dispose ();
                logoutButton = null;
            }
        }
    }
}
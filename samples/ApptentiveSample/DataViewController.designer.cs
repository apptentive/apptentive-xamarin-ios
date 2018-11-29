// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace ApptentiveSample
{
    [Register ("DataViewController")]
    partial class DataViewController
    {
        [Outlet]
        UIKit.UIButton addButton { get; set; }

        [Outlet]
        UIKit.UISwitch booleanSwitch { get; set; }

        [Outlet]
        UIKit.UITextField dataTextField { get; set; }

        [Outlet]
        UIKit.UITextField emailTextField { get; set; }

        [Outlet]
        UIKit.UITextField keyTextField { get; set; }

        [Outlet]
        UIKit.UITextField nameTextField { get; set; }

        [Outlet]
        UIKit.UISegmentedControl typeControl { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (addButton != null) {
                addButton.Dispose ();
                addButton = null;
            }

            if (booleanSwitch != null) {
                booleanSwitch.Dispose ();
                booleanSwitch = null;
            }

            if (dataTextField != null) {
                dataTextField.Dispose ();
                dataTextField = null;
            }

            if (emailTextField != null) {
                emailTextField.Dispose ();
                emailTextField = null;
            }

            if (keyTextField != null) {
                keyTextField.Dispose ();
                keyTextField = null;
            }

            if (nameTextField != null) {
                nameTextField.Dispose ();
                nameTextField = null;
            }

            if (typeControl != null) {
                typeControl.Dispose ();
                typeControl = null;
            }
        }
    }
}
﻿// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Phoneword.iOS.Views
{
    [Register ("MainView")]
    partial class MainView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField InputField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel OutputLabel { get; set; }

        [Action ("TranslateUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TranslateUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (InputField != null) {
                InputField.Dispose ();
                InputField = null;
            }

            if (OutputLabel != null) {
                OutputLabel.Dispose ();
                OutputLabel = null;
            }
        }
    }
}
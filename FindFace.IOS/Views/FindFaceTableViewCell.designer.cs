// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace FindFace.IOS.Views
{
    [Register ("FindFaceTableViewCell")]
    partial class FindFaceTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView FindFaceImageView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (FindFaceImageView != null) {
                FindFaceImageView.Dispose ();
                FindFaceImageView = null;
            }
        }
    }
}
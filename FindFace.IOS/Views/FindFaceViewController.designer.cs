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
    [Register ("FindFaceViewController")]
    partial class FindFaceViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView FindFaceTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView img { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton TakePhoto { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (FindFaceTableView != null) {
                FindFaceTableView.Dispose ();
                FindFaceTableView = null;
            }

            if (img != null) {
                img.Dispose ();
                img = null;
            }

            if (TakePhoto != null) {
                TakePhoto.Dispose ();
                TakePhoto = null;
            }
        }
    }
}
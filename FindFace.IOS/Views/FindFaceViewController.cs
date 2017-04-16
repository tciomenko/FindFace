﻿using System;
using FindFace.Core.ViewModels;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using UIKit;
using MvvmCross.Binding.BindingContext;

namespace FindFace.IOS.Views
{
    public partial class FindFaceViewController : MvxViewController<FirstViewModel>
    {
        private FindFaceTableViewSource findFaceTableViewSource;
        public FindFaceViewController() : base("FindFaceViewController", null){}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationController.NavigationBar.Translucent = false;
            findFaceTableViewSource = new FindFaceTableViewSource(FindFaceTableView);
            FindFaceTableView.Source = findFaceTableViewSource;
            FindFaceTableView.EstimatedRowHeight = 90f;
            FindFaceTableView.RowHeight = UITableView.AutomaticDimension;

            InitializeBindings();
        }
        //public override void ViewWillTransitionToSize(CoreGraphics.CGSize toSize, IUIViewControllerTransitionCoordinator coordinator)
        //{
        //    FindFaceTableView.ReloadData();
        //}

        //private void CheckOrientation()
        //{
        //    if (UIDevice.CurrentDevice.Orientation.IsLandscape())
        //        findFaceTableViewSource.HideView = false;
        //    else
        //        findFaceTableViewSource.HideView = true;
        //    FindFaceTableView.ReloadData();
        //}
        private void InitializeBindings()
        {
            var bindingSet = this.CreateBindingSet<FindFaceViewController, FirstViewModel>();
            bindingSet.Bind(findFaceTableViewSource).To(vm => vm.CurrentFindFace);
            bindingSet.Apply();
            //CheckOrientation();
        }
    }
}
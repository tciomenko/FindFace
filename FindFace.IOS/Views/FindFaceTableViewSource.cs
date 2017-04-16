using System;
using System.Collections.Generic;
using System.Text;
using Foundation;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace FindFace.IOS.Views
{
    public class FindFaceTableViewSource : MvxSimpleTableViewSource
    {

        public FindFaceTableViewSource(UITableView tableView) : base(tableView, FindFaceTableViewCell.Key, FindFaceTableViewCell.Key)
        {
        }
        public bool HideView { get; set; }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {

            var findFaceViewCell = tableView.DequeueReusableCell(FindFaceTableViewCell.Key, indexPath) as FindFaceTableViewCell;
            return findFaceViewCell;
        }

        public override nfloat EstimatedHeight(UITableView tableView, NSIndexPath indexPath) => 100;


    }
}

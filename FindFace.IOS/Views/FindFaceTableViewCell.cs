using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace FindFace.IOS.Views
{
    public partial class FindFaceTableViewCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("FindFaceTableViewCell");
        public static readonly UINib Nib;

        private readonly MvxImageViewLoader imageLoader;
        static FindFaceTableViewCell()
        {
            Nib = UINib.FromName("FindFaceTableViewCell", NSBundle.MainBundle);
        }
        
        protected FindFaceTableViewCell(IntPtr handle) : base(handle)
        {
            imageLoader = new MvxImageViewLoader(() => FindFaceImageView);
            this.DelayBind(() =>
            {
                var bindingSet = this.CreateBindingSet<FindFaceTableViewCell, Core.Model.ConfidenceFace>();

                bindingSet.Bind(imageLoader).To(vm => vm.Face.Photo);
                bindingSet.Bind(imageLoader).For(i => i.DefaultImagePath).To(vm => vm.Face.Photo);
                bindingSet.Apply();
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;

namespace FindFace.Droid.Views
{
    [Activity(Label = "FindFaceView", MainLauncher = true)]
    public class FindFaceView : MvxActivity, IMvxViewModel
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }

        public void Init(IMvxBundle parameters)
        {
            throw new NotImplementedException();
        }

        public void ReloadState(IMvxBundle state)
        {
            throw new NotImplementedException();
        }
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.FirstView);
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void SaveState(IMvxBundle state)
        {
            throw new NotImplementedException();
        }

        public new FindFaceView ViewModel
        {
            get { return (FindFaceView)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public MvxRequestedBy RequestedBy { get;  set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Text;
using FindFace.Core.ViewModels;
using MvvmCross.Core.ViewModels;

namespace FindFace.IOS
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<FirstViewModel>();
        }
    }
}
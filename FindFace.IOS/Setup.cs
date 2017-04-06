using FindFace.Core;
using FindFace.Core.Services;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using UIKit;

namespace FindFace.IOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(IMvxApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window)
        {
        }

        public Setup(IMvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter) : base(applicationDelegate, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override void FillBindingNames(IMvxBindingNameRegistry registry)
        {
            // use these to register default binding names
            base.FillBindingNames(registry);
        }

        protected override void InitializePlatformServices()
        {
            base.InitializePlatformServices();

            Mvx.LazyConstructAndRegisterSingleton<IMvxAppStart, AppStart>();
            Mvx.LazyConstructAndRegisterSingleton<IDataService, DataService>();

        }
    }
}

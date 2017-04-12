using FindFace.Core.Services;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace FindFace.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.LazyConstructAndRegisterSingleton<IDataService, DataService>();
        }


        public override void Initialize()
        {
            base.Initialize();
        }
    }
}

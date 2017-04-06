using Cirrious.CrossCore;
using FindFace.Core.Services;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace FindFace.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            //Mvx.LazyConstructAndRegisterSingleton<IDataService, DataService>();
        }


        public override void Initialize()
        {
            base.Initialize();
        }
    }
}

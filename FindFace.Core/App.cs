using Cirrious.CrossCore;
using FindFace.Core.Services;
using MvvmCross.Platform.IoC;

namespace FindFace.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            Mvx.LazyConstructAndRegisterSingleton<IDataService, DataService>();
        }
    }
}

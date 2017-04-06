using MvvmCross.Core.ViewModels;
using System.ComponentModel;
using FindFace.Core.Model;
using Chance.MvvmCross.Plugins.UserInteraction;
using System;
using MvvmCross.Core.ViewModels;
using FindFace.Core.Services;
using System.Diagnostics;
using System.ComponentModel;
using MvvmCross.Platform;
using Chance.MvvmCross.Plugins.UserInteraction;
using System.Threading.Tasks;

namespace FindFace.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel, INotifyPropertyChanged
    {
        readonly IDataService dataService;

        public FirstViewModel(IDataService dataService)
        {
            this.dataService = dataService;

        }

        public  async Task LoadAsync()
        {
            var getWeather = await dataService.SendPost(); //GetDataFromService();
        }
        public async override void Start()
        {
            base.Start();
            await LoadAsync();
        }
    }
}

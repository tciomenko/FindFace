using System;
using MvvmCross.Core.ViewModels;
using System.ComponentModel;
using System.Diagnostics;
using FindFace.Core.Services;
using System.Threading.Tasks;
using Chance.MvvmCross.Plugins.UserInteraction;
using FindFace.Core.Model;
using MvvmCross.Platform;
using System.Collections.Generic;

namespace FindFace.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel, INotifyPropertyChanged
    {

        readonly IDataService dataService;
        public MvxObservableCollection<List<ConfidenceFace>> CurrentFindFace { get; set; }
        public FirstViewModel(IDataService dataService)
        {
            this.dataService = dataService;
            CurrentFindFace = new MvxObservableCollection<List<ConfidenceFace>>();

        }

        public async Task LoadAsync()
        {
            try { 
            var getFindFace = await dataService.GetDataFromService();
            if (getFindFace != null)
            {
                CurrentFindFace.Add(getFindFace);
            }
            else
            {
                var result = await Mvx.Resolve<IUserInteraction>().ConfirmAsync("Cant get weather. Please try again later", "Warning");
                if (result)
                {
                    await LoadAsync();
                }
            }
        }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, ex.StackTrace);
            }
}
        public async override void Start()
        {
            base.Start();
            await LoadAsync();
        }
    }
}

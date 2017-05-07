using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Command;
using WpfBoilerplate.Service;
using WpfBoilerplate.ViewModel;

namespace WpfBoilerplate.Factory
{
    internal class MainViewModelFactory : IMainViewModelFactory
    {
        private readonly IDataService _dataService;
        public MainViewModelFactory(IDataService dataService)
        {
            _dataService = dataService;
        }
        public MainViewModel Create()
        {
            return new MainViewModel()
            {
                Title = _dataService.Get(),
                Lista = new ObservableCollection<string>(_dataService.GetList())
            };
        }
    }
}
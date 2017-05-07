using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace WpfBoilerplate.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                Title = "Zdravo svete design";
                Lista = new ObservableCollection<string>( new List<string>
                {
                    "jedan",
                    "dva",
                    "tri"
                });
            }
            else
            {
                RemoveItem = new RelayCommand(() => Lista.RemoveAt(0));
            }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { Set(ref _title, value); }
        }

        private ObservableCollection<string> _lista;

        public ObservableCollection<string> Lista
        {
            get { return _lista; }
            set { Set(ref _lista, value); }
        }

        public RelayCommand RemoveItem
        {
            get;
            private set;
        }

    }
}
using Flickzation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flickzation.MVVM.ViewModel
{
    class MainViewModel : ObservableObject


    {
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand SeriesViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }

        public SeriesViewModel SeriesVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel() 
        { 
            HomeVM = new HomeViewModel();
            SeriesVM = new SeriesViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            SeriesViewCommand = new RelayCommand(o =>
            {
                CurrentView = SeriesVM;
            });
        }
    }
}

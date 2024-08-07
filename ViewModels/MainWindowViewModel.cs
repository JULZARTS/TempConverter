using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using TempConverter.Models;

namespace TempConverter.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<BtnsViewModel> btn = new();
        [ObservableProperty]
        private ObservableCollection<BtnsViewModel> btn2 = new();
        [ObservableProperty]
        private ObservableCollection<BtnsViewModel> btn3 = new();

        public MainWindowViewModel()
        {
            btn = new (btn)
            {
                new BtnsViewModel { BtnContent = "1" },
                new BtnsViewModel { BtnContent = "2" },
                new BtnsViewModel { BtnContent = "3" },
            };

            btn2 = new(btn2)
            {
                new BtnsViewModel { BtnContent = "4" },
                new BtnsViewModel { BtnContent = "5" },
                new BtnsViewModel { BtnContent = "6" },
            };

            btn3 = new(btn3)
            {
                new BtnsViewModel { BtnContent = "7" },
                new BtnsViewModel { BtnContent = "8" },
                new BtnsViewModel { BtnContent = "9" },
            };
        }
    }
}

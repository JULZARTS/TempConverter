using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Globalization;
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

        private BtnsViewModel _btnsViewModel;
        public MainWindowViewModel(BtnsViewModel btnsViewModel) 
        { 
            _btnsViewModel = btnsViewModel; 
        }

        [ObservableProperty]
        private string selectedItem;

        [ObservableProperty]
        private string selectedItem2;

        [ObservableProperty]
        private string tb1Text;

        [ObservableProperty]
        private string tb2Text;

        partial void OnTb1TextChanged(string value)
        {
            if (double.TryParse(value, out double Temp))
            {
                if (selectedItem == "°C" && selectedItem2 == "°F") Tb2Text = value = (Temp * 9 / 5 + 32).ToString();
                else if (selectedItem == "°F" && selectedItem2 == "°C") Tb2Text = value = ((Temp - 32) * 5 / 9).ToString();
                else if (selectedItem == "°C" && selectedItem2 == "K") Tb2Text = value = (Temp + 273.15).ToString();
                else if (selectedItem == "K" && selectedItem2 == "°C") Tb2Text = value = (Temp - 273.15).ToString();
                else if (selectedItem == "°F" && selectedItem2 == "K") Tb2Text = value = ((Temp - 32) * 5 / 9 + 273.15).ToString();
                else if (selectedItem == "K" && selectedItem2 == "°F") Tb2Text = value = ((Temp - 273.15) * 9 / 5 + 32).ToString();
                else Tb2Text = value;
            }
        }


        public MainWindowViewModel()
        {
            btn = new (btn)
            {
                new BtnsViewModel(this) { BtnContent = "7" },
                new BtnsViewModel(this) { BtnContent = "4" },
                new BtnsViewModel(this) { BtnContent = "1" },
                new BtnsViewModel(this) { BtnContent = "0" },
            };

            btn2 = new(btn2)
            {
                new BtnsViewModel(this) { BtnContent = "8" },
                new BtnsViewModel(this) { BtnContent = "5" },
                new BtnsViewModel(this) { BtnContent = "2" },
                new BtnsViewModel(this) { BtnContent = "•" },
            };

            btn3 = new(btn3)
            {
                new BtnsViewModel(this) { BtnContent = "9" },
                new BtnsViewModel(this) { BtnContent = "6" },
                new BtnsViewModel(this) { BtnContent = "3" },
                new BtnsViewModel(this) { BtnContent = "C" },
            };
            SelectedItem = "+";
            SelectedItem2 = "+";
        }

        [RelayCommand]
        public void Unit1(string unit)
        { SelectedItem = unit;  }

        [RelayCommand]
        public void Unit2(string unit)
        { SelectedItem2 = unit; OnTb1TextChanged(Tb1Text); } 
    }
}
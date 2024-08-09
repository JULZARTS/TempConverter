using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using TempConverter.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TempConverter.ViewModels
{
    public partial class BtnsViewModel: ViewModelBase
    {

        private MainWindowViewModel _mainWindowViewModel;
        public BtnsViewModel(MainWindowViewModel mainWindowViewModel) 
        { 
            _mainWindowViewModel = mainWindowViewModel;
        }

        [ObservableProperty]
        public string? btnContent;
        public BtnsViewModel(DisplayButtons Dbtns) 
        { 
            btnContent = Dbtns.BtnContent; 
        }

        [ObservableProperty]
        private string greetings = "Hello World";

        [ObservableProperty]
        private string tb1Text;

        [RelayCommand]
        public void BtnCommand(string buttoncontent)
        {
            if (buttoncontent == "C")
            {
                _mainWindowViewModel.Tb1Text = string.Empty;
            }
            else if (buttoncontent == "•")
            {
                // Check if there's already a dot in the current input
                if (!_mainWindowViewModel.Tb1Text.Contains("."))
                {
                    _mainWindowViewModel.Tb1Text += ".";
                }
            }
            else if (int.TryParse(buttoncontent, out int number))
            {
                _mainWindowViewModel.Tb1Text += buttoncontent;
            }
        }
    }
}

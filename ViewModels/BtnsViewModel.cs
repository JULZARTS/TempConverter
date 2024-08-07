using CommunityToolkit.Mvvm.ComponentModel;
using TempConverter.Models;

namespace TempConverter.ViewModels
{
    public partial class BtnsViewModel: ViewModelBase
    {
        public BtnsViewModel() { }


        [ObservableProperty]
        public string? btnContent;
        public BtnsViewModel(DisplayButtons Dbtns) 
        { 
            btnContent = Dbtns.BtnContent; 
        }

        public DisplayButtons GetDisplayButtons()
        {
            return new DisplayButtons { BtnContent = this.BtnContent };
        }

        
    }
}

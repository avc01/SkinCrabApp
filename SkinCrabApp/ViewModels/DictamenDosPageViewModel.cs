using MvvmHelpers;
using MvvmHelpers.Commands;
using SkinCrabApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SkinCrabApp.ViewModels
{
    public class DictamenDosPageViewModel : ObservableObject
    {
        public AsyncCommand TapBack { get; set; }
        public DictamenDosPageViewModel()
        {
            TapBack = new AsyncCommand(GoBack);
        }

        private async Task GoBack()
        {
            await Shell.Current.GoToAsync($"//{nameof(MenuPage)}");
        }
    }
}

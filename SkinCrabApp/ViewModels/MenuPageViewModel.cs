using MvvmHelpers;
using MvvmHelpers.Commands;
using SkinCrabApp.Views;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SkinCrabApp.ViewModels
{
    public class MenuPageViewModel : ObservableObject
    {
        public AsyncCommand TapCommandFirstLink { get; set; }

        public AsyncCommand TapCommandSecondLink { get; set; }

        public AsyncCommand TapLogout { get; set; }

        public MenuPageViewModel()
        {
            TapCommandFirstLink = new AsyncCommand(TapFirstLink);
            TapCommandSecondLink = new AsyncCommand(TapSecondLink);
            TapLogout = new AsyncCommand(TapLogoutUser);
        }

        public async Task TapFirstLink()
        {
            await Launcher.OpenAsync("https://www.cancer.gov/espanol/tipos/piel/paciente/tratamiento-piel-pdq");
        }

        public async Task TapSecondLink()
        {
            await Launcher.OpenAsync("https://www.cdc.gov/spanish/cancer/skin/basic_info/index.htm");
        }

        public async Task TapLogoutUser()
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}

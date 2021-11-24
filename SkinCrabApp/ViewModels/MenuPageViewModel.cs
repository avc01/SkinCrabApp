using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace SkinCrabApp.ViewModels
{
    public class MenuPageViewModel : ObservableObject
    {
        public AsyncCommand TapCommandFirstLink { get; set; }

        public AsyncCommand TapCommandSecondLink { get; set; }

        public MenuPageViewModel()
        {
            TapCommandFirstLink = new AsyncCommand(TapFirstLink);
            TapCommandSecondLink = new AsyncCommand(TapSecondLink);
        }

        public async Task TapFirstLink() 
        {
            await Launcher.OpenAsync("https://www.cancer.gov/espanol/tipos/piel/paciente/tratamiento-piel-pdq");
        }

        public async Task TapSecondLink()
        {
            await Launcher.OpenAsync("https://www.cdc.gov/spanish/cancer/skin/basic_info/index.htm");
        }
    }
}

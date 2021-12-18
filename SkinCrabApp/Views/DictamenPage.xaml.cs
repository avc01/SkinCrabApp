using SkinCrabApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SkinCrabApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DictamenPage : ContentPage
    {
        public DictamenPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var resultAutoExamenId = await SkinCrabService.GetUsuario(int.Parse(Preferences.Get("currentUser_UsuarioId", "default_value")));

            if (resultAutoExamenId.IdAutoExamen is null)
            {
                await Shell.Current.GoToAsync($"////{nameof(DictamenPage)}");
            }
            else if (resultAutoExamenId.IdAutoExamen == 1)
            {
                await Shell.Current.GoToAsync($"{nameof(DictamenUnoPage)}");
            }
            else if (resultAutoExamenId.IdAutoExamen == 2)
            {
                await Shell.Current.GoToAsync($"{nameof(DictamenDosPage)}");
            }
            else if (resultAutoExamenId.IdAutoExamen == 3)
            {
                await Shell.Current.GoToAsync($"{nameof(DictamenTresPage)}");
            }
        }
    }
}
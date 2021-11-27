using MvvmHelpers;
using MvvmHelpers.Commands;
using SkinCrabApp.Services;
using SkinCrabApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SkinCrabApp.ViewModels
{
    public class LoginPageViewModel : ObservableObject
    {
        public AsyncCommand TapLogin { get; set; }
        public AsyncCommand TapRegistrarme { get; set; }

        private string _nombreUsuario;
        public string NombreUsuario { get => _nombreUsuario; set => SetProperty(ref _nombreUsuario, value); }

        private string _clave;
        public string Clave { get => _clave; set => SetProperty(ref _clave, value); }

        public LoginPageViewModel()
        {
            TapLogin = new AsyncCommand(LogUser);
            TapRegistrarme = new AsyncCommand(RegistrarUser);
        }

        public async Task LogUser()
        {
            if (EmptyFields())
            {
                await Application.Current.MainPage.DisplayAlert("Atencion", "faltan datos", "ok");
                return;
            }

            var result = await SkinCrabService.GetUsuarioByUserName(NombreUsuario);

            if (result is null)
            {
                await Application.Current.MainPage.DisplayAlert("Atencion", "usuario no encontrado", "ok");
                return;
            }

            if (result.Clave != Clave)
            {
                await Application.Current.MainPage.DisplayAlert("Atencion", "clave incorrecta", "ok");
                return;
            }

            await Task.Run(() => 
            {
                Preferences.Set("currentUser_Name", $"{result.Nombre}");
                Preferences.Set("currentUser_LastName", $"{result.Apellido}");
                Preferences.Set("currentUser_NombreUsuario", $"{result.NombreUsuario}");
                Preferences.Set("currentUser_UsuarioId", $"{result.IdUsuario}");
            });
            await CleanFields();
           // await Shell.Current.GoToAsync($"//{nameof(MenuPage)}");
            await Shell.Current.GoToAsync($"{nameof(DeteccionPage)}");

        }

        public async Task RegistrarUser()
        {
            await CleanFields();
            await Shell.Current.GoToAsync($"{nameof(RegistroPage)}");
        }

        public bool EmptyFields()
        {
            if (string.IsNullOrWhiteSpace(Clave) || string.IsNullOrWhiteSpace(NombreUsuario))
            {
                return true;
            }
            return false;
        }

        public async Task CleanFields()
        {
            await Task.Run(() =>
            {
                NombreUsuario = default;
                Clave = default;
            });
        }
    }
}

using MvvmHelpers;
using MvvmHelpers.Commands;
using SkinCrabApp.Helpers;
using SkinCrabApp.Models;
using SkinCrabApp.Services;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SkinCrabApp.ViewModels
{
    public class RegistroPageViewModel : ObservableObject
    {
        public AsyncCommand<Usuario> TapRegisterUser { get; }
        public AsyncCommand TapCancelar { get; }
        public Usuario UsuarioCommand { get; set; }

        public RegistroPageViewModel()
        {
            TapRegisterUser = new AsyncCommand<Usuario>(CreateUsuario);
            TapCancelar = new AsyncCommand(CleanFieldsAsync);

            UsuarioCommand = new Usuario();
        }

        public async Task CreateUsuario(Usuario usuario) 
        {
            if (FieldsEmpty(usuario))
            {
                await Application.Current.MainPage.DisplayAlert("Atencion", "faltan datos o hay datos erroneos", "ok");
                return;
            }
            
            await SkinCrabService.CreateUsuario(usuario);
            await DataFile.SaveUserDataToFileAsync(usuario);
            await Application.Current.MainPage.DisplayAlert("Notificacion", "usuario creado exitosamente", "ok");
            await CleanFieldsAsync();
        }

        public async Task CleanFieldsAsync()
        {
            foreach (var item in UsuarioCommand.GetType().GetProperties())
            {
                item.SetValue(UsuarioCommand, default);
            }

            await Shell.Current.GoToAsync($"..");
        }

        public bool FieldsEmpty(Usuario usuario) 
        {
            foreach (var item in usuario.GetType().GetProperties())
            {
                if (item.Name.Contains("IdUsuario") || item.Name.Contains("IdEmfermedad") || item.PropertyType.Name.Contains("Boolean"))
                {
                    continue;
                }

                if (item.PropertyType.Name.Contains("String"))
                {
                    if (string.IsNullOrWhiteSpace((string)item.GetValue(usuario)))
                    {
                        return true;
                    }
                }

                if (item.PropertyType.Name.Contains("Int32"))
                {
                    if ((int)item.GetValue(usuario) <= 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

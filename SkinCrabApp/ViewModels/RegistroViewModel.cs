using MvvmHelpers;
using MvvmHelpers.Commands;
using SkinCrabApp.Models;
using SkinCrabApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SkinCrabApp.ViewModels
{
    public class RegistroViewModel : ObservableObject
    {
        public AsyncCommand<Usuario> TapRegisterUser { get; set; }

        public Usuario UsuarioCommand { get; set; }

        #region Mapeo de Propiedades
        private string _nombre;
        public string Nombre 
        { 
            get => _nombre; 
            set
            {
                SetProperty(ref _nombre, value);
                UsuarioCommand.Nombre = value;
            } 
        }

        private string _apellido;
        public string Apellido 
        { 
            get => _apellido; 
            set => SetProperty(ref _apellido, value); 
        }

        private string _clave;
        public string Clave 
        { 
            get => _clave; 
            set => SetProperty(ref _clave, value); 
        }

        private string _nombreUsuario;
        public string NombreUsuario 
        { 
            get => _nombreUsuario; 
            set => SetProperty(ref _nombreUsuario, value); 
        }
        #endregion
        public RegistroViewModel()
        {
            TapRegisterUser = new AsyncCommand<Usuario>(CreateUsuario);
            UsuarioCommand = new Usuario();
        }

        public async Task CreateUsuario(Usuario usuario) 
        {

            // await SkinCrabService.CreateUsuario();
        }
    }
}

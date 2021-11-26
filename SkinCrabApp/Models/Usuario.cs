using MvvmHelpers;
using SQLite;

namespace SkinCrabApp.Models
{
    public class Usuario : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int IdUsuario { get; set; }

        [NotNull]
        public string Nombre { get => _nombre; set => SetProperty(ref _nombre, value); }

        [NotNull]
        public string Apellido { get => _apellido; set => SetProperty(ref _apellido, value); }

        [NotNull]
        public string NombreUsuario { get => _nombreUsuario; set => SetProperty(ref _nombreUsuario, value); }

        [NotNull]
        public string Clave { get => _clave; set => SetProperty(ref _clave, value); }

        [Indexed]
        public int? IdEmfermedad { get; set; }

        // Not Mapped

        [Ignore]
        public int Edad { get => _edad; set => SetProperty(ref _edad, value); }

        [Ignore]
        public string Genero { get => _genero; set => SetProperty(ref _genero, value); }

        [Ignore]
        public string Etnia { get => _etnia; set => SetProperty(ref _etnia, value); }

        [Ignore]
        public string Color { get => _color; set => SetProperty(ref _color, value); }

        [Ignore]
        public bool MarcasNacimiento { get => _marcasNacimiento; set => SetProperty(ref _marcasNacimiento, value); }

        [Ignore]
        public bool HistorialMedico { get => _historialMedico; set => SetProperty(ref _historialMedico, value); }

        [Ignore]
        public bool Diagnosticado { get => _diagnosticado; set => SetProperty(ref _diagnosticado, value); }

        [Ignore]
        public bool Tratamiento { get => _tratamiento; set => SetProperty(ref _tratamiento, value); }

        [Ignore]
        public bool PielPalida { get => _pielPalida; set => SetProperty(ref _pielPalida, value); }

        // Values Datos Acceso
        
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _clave;

        // Values Datos Basicos

        private int _edad;
        private string _genero;
        private string _etnia;
        private string _color;
        private bool _marcasNacimiento;
        private bool _historialMedico;
        private bool _diagnosticado;
        private bool _tratamiento;
        private bool _pielPalida;
    }
}

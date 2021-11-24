using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkinCrabApp.Models
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int IdUsuario { get; set; }

        [NotNull]
        public string Nombre { get; set; }

        [NotNull]
        public string Apellido { get; set; }

        [NotNull]
        public string NombreUsuario { get; set; }

        [NotNull]
        public string Clave { get; set; }

        [Indexed]
        public int? IdEmfermedad { get; set; }

        // Not Mapped

        [Ignore]
        public int Edad { get; set; }

        [Ignore]
        public string Genero { get; set; }

        [Ignore]
        public string Etnia { get; set; }

        [Ignore]
        public string Color { get; set; }

        [Ignore]
        public bool MarcasNacimiento { get; set; }

        [Ignore]
        public bool HistorialMedico { get; set; }

        [Ignore]
        public bool Diagnosticado { get; set; }

        [Ignore]
        public bool Tratamiento { get; set; }

        [Ignore]
        public bool PielPalida { get; set; }
    }
}

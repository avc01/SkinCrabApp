using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkinCrabApp.Models
{
    public class Clinica
    {
        [PrimaryKey, AutoIncrement]
        public int IdClinica { get; set; }

        [NotNull]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [NotNull]
        public string Telefono { get => _telefono; set => _telefono = value; }

        [NotNull]
        public string Direccion { get => _direccion; set => _direccion = value; }

        [NotNull, Indexed]
        public int IdEmfermedad { get; set; }

        [NotNull]
        public string Url { get => _url; set => _url = value; }

        // Values

        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _url;
    }
}

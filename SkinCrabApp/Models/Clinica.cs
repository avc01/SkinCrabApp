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
        public string Nombre { get; set; }

        [NotNull]
        public string Telefono { get => $"Teléfono: {_telefono}"; set => _telefono = value; }

        [NotNull]
        public string Direccion { get => $"Dirección: {_direccion}"; set => _direccion = value; }

        [NotNull, Indexed]
        public int IdEmfermedad { get; set; }

        [Ignore]
        public string Url { get; set; }

        private string _direccion;
        private string _telefono;
    }
}

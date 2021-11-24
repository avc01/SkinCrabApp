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
        public string Telefono { get; set; }

        [NotNull]
        public string Direccion { get; set; }

        [NotNull, Indexed]
        public int IdEmfermedad { get; set; }
    }
}

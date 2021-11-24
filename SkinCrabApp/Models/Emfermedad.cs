using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkinCrabApp.Models
{
    public class Emfermedad
    {
        [PrimaryKey, AutoIncrement]
        public int IdEmfermedad { get; set; }

        [NotNull]
        public string TipoCancer { get; set; }

        [NotNull]
        public string Descripcion { get; set; }

        [NotNull]
        public string Tratamiento { get; set; }
    }
}

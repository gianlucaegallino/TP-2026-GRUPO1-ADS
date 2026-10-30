using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Equipo
    {
        public int IdEquipo { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public DateTime FechaFundacion { get; set; }

        public bool Activo { get; set; } = true;
    }
}

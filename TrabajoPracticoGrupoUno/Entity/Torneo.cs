using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Torneo
    {
        public int IdTorneo { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public int Año { get; set; }

        public bool Activo { get; set; } = true;
    }
}
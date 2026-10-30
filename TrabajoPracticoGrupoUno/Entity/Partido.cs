using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Partido
    {
        public int IdPartido { get; set; }

        public int IdTorneo { get; set; }

        public int IdEquipoLocal { get; set; }

        public int IdEquipoVisitante { get; set; }

        public int GolesLocal { get; set; }

        public int GolesVisitante { get; set; }

        public DateTime Fecha { get; set; }

        public bool Activo { get; set; } = true;
    }
}
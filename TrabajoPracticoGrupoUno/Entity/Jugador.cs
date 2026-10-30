using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Jugador
    {
        public int IdJugador { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        public int NumeroCamiseta { get; set; }

        public int IdEquipo { get; set; }

        public int IdPais { get; set; }

        public bool Activo { get; set; } = true;
    }
}

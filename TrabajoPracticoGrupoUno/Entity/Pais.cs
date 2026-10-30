using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Pais
    {
        public int IdPais { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public bool Activo { get; set; } = true;
    }
}

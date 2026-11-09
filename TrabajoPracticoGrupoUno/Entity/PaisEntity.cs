using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class PaisEntity
    {
        public int IdPais { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public bool Activo { get; set; } = true;
    }
}

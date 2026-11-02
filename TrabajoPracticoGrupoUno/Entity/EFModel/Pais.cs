using System;
using System.Collections.Generic;

namespace Entity.EFModel;

public partial class Pais
{
    public int IdPais { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Activo { get; set; }

    public virtual ICollection<Jugador> Jugador { get; set; } = new List<Jugador>();
}

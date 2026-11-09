using System;
using System.Collections.Generic;

namespace Entity.EFModel;

public partial class Torneo
{
    public int IdTorneo { get; set; }

    public string Nombre { get; set; } = null!;

    public int Año { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<Partido> Partido { get; set; } = new List<Partido>();
}

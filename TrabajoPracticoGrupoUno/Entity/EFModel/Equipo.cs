using System;
using System.Collections.Generic;

namespace Entity.EFModel;

public partial class Equipo
{
    public int IdEquipo { get; set; }

    public string Nombre { get; set; } = null!;

    public DateOnly Fechafundacion { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<Jugador> Jugador { get; set; } = new List<Jugador>();

    public virtual ICollection<Partido> PartidoIdEquipoLocalNavigation { get; set; } = new List<Partido>();

    public virtual ICollection<Partido> PartidoIdEquipoVisitanteNavigation { get; set; } = new List<Partido>();
}

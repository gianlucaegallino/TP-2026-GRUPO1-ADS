using System;
using System.Collections.Generic;

namespace Entity.EFModel;

public partial class Jugador
{
    public int IdJugador { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int Numerocamiseta { get; set; }

    public int IdEquipo { get; set; }

    public int IdPais { get; set; }

    public bool Activo { get; set; }

    public virtual Equipo IdEquipoNavigation { get; set; } = null!;

    public virtual Pais IdPaisNavigation { get; set; } = null!;
}

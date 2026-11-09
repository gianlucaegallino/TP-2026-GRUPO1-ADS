using System;
using System.Collections.Generic;

namespace Entity.EFModel;

public partial class Partido
{
    public int IdPartido { get; set; }

    public int IdTorneo { get; set; }

    public int IdEquipoLocal { get; set; }

    public int IdEquipoVisitante { get; set; }

    public int? Goleslocal { get; set; }

    public int? Golesvisitante { get; set; }

    public DateTime Fecha { get; set; }

    public bool Activo { get; set; }

    public DateTime? Fechafinpartido { get; set; }

    public virtual Equipo IdEquipoLocalNavigation { get; set; } = null!;

    public virtual Equipo IdEquipoVisitanteNavigation { get; set; } = null!;

    public virtual Torneo IdTorneoNavigation { get; set; } = null!;
}

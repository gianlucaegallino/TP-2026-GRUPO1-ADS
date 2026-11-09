using Entity;
using Entity.EFModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public static class PartidoMapper
    {
        public static PartidoEntity MapToEntity(Partido origen)
        {
            if (origen == null) return null;
            return new PartidoEntity
            {
                IdPartido = origen.IdPartido,
                IdTorneo = origen.IdTorneo,
                IdEquipoLocal = origen.IdEquipoLocal,
                IdEquipoVisitante = origen.IdEquipoVisitante,
                GolesLocal = origen.Goleslocal ?? 0,       
                GolesVisitante = origen.Golesvisitante ?? 0,
                Fecha = origen.Fecha,
                Activo = origen.Activo
            };
        }

        public static Partido MapToModel(PartidoEntity origen)
        {
            if (origen == null) return null;
            return new Partido
            {
                IdPartido = origen.IdPartido,
                IdTorneo = origen.IdTorneo,
                IdEquipoLocal = origen.IdEquipoLocal,
                IdEquipoVisitante = origen.IdEquipoVisitante,
                Goleslocal = origen.GolesLocal,       
                Golesvisitante = origen.GolesVisitante, 
                Fecha = origen.Fecha,
                Activo = origen.Activo
            };
        }
    }
}

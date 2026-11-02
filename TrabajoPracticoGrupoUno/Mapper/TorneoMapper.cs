using Entity.EFModel;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public static class TorneoMapper
    {
            public static TorneoEntity MapToEntity(Torneo origen)
            {
                if (origen == null) return null;
                return new TorneoEntity
                {
                    IdTorneo = origen.IdTorneo,
                    Nombre = origen.Nombre,
                    Año = origen.Año,
                    Activo = origen.Activo
                };
            }
            public static Torneo MapToModel(TorneoEntity origen)
            {
                if (origen == null) return null;
                return new Torneo
                {
                    IdTorneo = origen.IdTorneo,
                    Nombre = origen.Nombre,
                    Año = origen.Año,
                    Activo = origen.Activo
                };
            }
        
    }
}


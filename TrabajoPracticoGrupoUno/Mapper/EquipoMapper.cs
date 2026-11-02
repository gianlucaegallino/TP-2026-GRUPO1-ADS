using Entity;
using Entity.EFModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public static class EquipoMapper
    {
        public static EquipoEntity MapToEntity(Entity.EFModel.Equipo origen)
        {
            if (origen == null) return null;
            return new EquipoEntity
            {
                IdEquipo = origen.IdEquipo,
                Nombre = origen.Nombre,
                // Convierte DateOnly a DateTime para el negocio
                FechaFundacion = origen.Fechafundacion.ToDateTime(new System.TimeOnly(0, 0)),
                Activo = origen.Activo
            };
        }

        public static Entity.EFModel.Equipo MapToModel(EquipoEntity origen)
        {
            if (origen == null) return null;
            return new Entity.EFModel.Equipo
            {
                IdEquipo = origen.IdEquipo,
                Nombre = origen.Nombre,
                // Convierte DateTime a DateOnly para la base de datos
                Fechafundacion = System.DateOnly.FromDateTime(origen.FechaFundacion),
                Activo = origen.Activo
            };
        }
    }
}
    

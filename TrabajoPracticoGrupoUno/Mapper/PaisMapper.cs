using Entity;
using Entity.EFModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public static class PaisMapper
    {
        public static Pais MapToEntity(Entity.EFModel.Pais origen)
        {
            if (origen == null) return null;
            return new Pais
            {
                IdPais = origen.IdPais,
                Nombre = origen.Nombre,
                Activo = origen.Activo
            };
        }

        public static Entity.EFModel.Pais MapToModel(Pais origen)
        {
            if (origen == null) return null;
            return new Entity.EFModel.Pais
            {
                IdPais = origen.IdPais,
                Nombre = origen.Nombre,
                Activo = origen.Activo
            };
        }
    }
}

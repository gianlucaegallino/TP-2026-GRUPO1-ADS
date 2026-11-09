using Entity;
using Entity.EFModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public static class PaisMapper
    {
        public static Pais MapToEntity(Pais origen)
        {
            if (origen == null) return null;
            return new Pais
            {
                IdPais = origen.IdPais,
                Nombre = origen.Nombre,
                Activo = origen.Activo
            };
        }

        public static Pais MapToModel(Pais origen)
        {
            if (origen == null) return null;
            return new Pais
            {
                IdPais = origen.IdPais,
                Nombre = origen.Nombre,
                Activo = origen.Activo
            };
        }
    }
}

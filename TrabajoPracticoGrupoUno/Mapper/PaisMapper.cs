using Entity;
using Entity.EFModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public static class PaisMapper
    {
        public static PaisEntity MapToEntity(Pais origen)
        {
            if (origen == null) return null;
            return new PaisEntity
            {
                IdPais = origen.IdPais,
                Nombre = origen.Nombre,
                Activo = origen.Activo
            };
        }

        public static Pais MapToModel(PaisEntity origen)
        {
            if (origen == null) return null;
            return new Pais
            {
                IdPais = origen.IdPais,
                Nombre = origen.Nombre,
                Activo = origen.Activo
            };
        }

        public static List<PaisEntity> MapToEntity(List<Pais> list)
        {
            List<PaisEntity> entityList = new List<PaisEntity>();
            foreach (var item in list)
            {
                entityList.Add(MapToEntity(item));
            }
            return entityList;
        }
    }
}

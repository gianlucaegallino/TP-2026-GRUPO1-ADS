using Entity;
using Entity.EFModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public static class JugadorMapper
    {
        public static JugadorEntity MapToEntity(Jugador origen)
        {
            if (origen == null) return null;
            return new JugadorEntity
            {
                IdJugador = origen.IdJugador,
                Nombre = origen.Nombre,
                Apellido = origen.Apellido,
                NumeroCamiseta = origen.Numerocamiseta,
                IdEquipo = origen.IdEquipo,
                IdPais = origen.IdPais,
                Activo = origen.Activo
            };
        }

        public static Jugador MapToModel(JugadorEntity origen)
        {
            if (origen == null) return null;
            return new Jugador
            {
                IdJugador = origen.IdJugador,
                Nombre = origen.Nombre,
                Apellido = origen.Apellido,
                Numerocamiseta = origen.NumeroCamiseta,
                IdEquipo = origen.IdEquipo,
                IdPais = origen.IdPais,
                Activo = origen.Activo
            };
        }


    }
}




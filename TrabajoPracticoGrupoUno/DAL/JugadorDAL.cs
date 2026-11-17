using DAL.Models;
using Entity;
using Entity.EFModel;
using Mapper;

namespace DAL
{
    public class JugadorDAL
    {
        public void add(JugadorEntity nuevoEntity)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Jugador nuevo = JugadorMapper.MapToModel(nuevoEntity);
                    db.Jugador.Add(nuevo);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void update(JugadorEntity entity)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Jugador item = db.Jugador.FirstOrDefault(e => e.IdJugador == entity.IdJugador);
                    if (item != null)
                    {
                        Jugador cambios = JugadorMapper.MapToModel(entity);
                        item.Nombre = cambios.Nombre;
                        item.Apellido = cambios.Apellido;
                        item.Numerocamiseta = cambios.Numerocamiseta;
                        item.IdEquipo = cambios.IdEquipo;
                        item.IdPais = cambios.IdPais;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void cambiarEstado(int id, bool activo)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Jugador item = db.Jugador.FirstOrDefault(e => e.IdJugador == id);
                    if (item != null)
                    {
                        item.Activo = activo;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<JugadorEntity> getAll()
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    List<Jugador> list = db.Jugador.ToList();
                    return list.Select(JugadorMapper.MapToEntity).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<JugadorEntity> getActivos()
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    List<Jugador> list = db.Jugador.Where(e => e.Activo).ToList();
                    return list.Select(JugadorMapper.MapToEntity).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public JugadorEntity getById(int id)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Jugador item = db.Jugador.FirstOrDefault(e => e.IdJugador == id);

                    if (item != null)
                    {
                        return JugadorMapper.MapToEntity(item);
                    }
                    else return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

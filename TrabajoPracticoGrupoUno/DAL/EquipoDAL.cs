using DAL.Models;
using Entity;
using Entity.EFModel;
using Mapper;

namespace DAL
{
    public class EquipoDAL
    {
        public void add(EquipoEntity nuevoEntity)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Equipo nuevo = EquipoMapper.MapToModel(nuevoEntity);
                    db.Equipo.Add(nuevo);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void update(EquipoEntity entity)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Equipo item = db.Equipo.FirstOrDefault(e => e.IdEquipo == entity.IdEquipo);
                    if (item != null)
                    {
                        Equipo cambios = EquipoMapper.MapToModel(entity);
                        item.Nombre = cambios.Nombre;
                        item.Fechafundacion = cambios.Fechafundacion;
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
                    Equipo item = db.Equipo.FirstOrDefault(e => e.IdEquipo == id);
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

        public List<EquipoEntity> getAll()
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    List<Equipo> list = db.Equipo.ToList();
                    return EquipoMapper.MapToEntity(list);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<EquipoEntity> getActivos()
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    List<Equipo> list = db.Equipo.Where(e => e.Activo).ToList();
                    return EquipoMapper.MapToEntity(list);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public EquipoEntity getById(int id)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Equipo item = db.Equipo.FirstOrDefault(e => e.IdEquipo == id);

                    if (item != null)
                    {
                        return EquipoMapper.MapToEntity(item);
                    }
                    else return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public EquipoEntity getByNombre(string nombre)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Equipo item = db.Equipo.FirstOrDefault(e => e.Nombre == nombre);

                    if (item != null)
                    {
                        return EquipoMapper.MapToEntity(item);
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

using DAL.Models;
using Entity;
using Entity.EFModel;
using Mapper;

namespace DAL
{
    public class PaisDAL
    {
        public void add(PaisEntity nuevoEntity)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Pais nuevo = PaisMapper.MapToModel(nuevoEntity);
                    db.Pais.Add(nuevo);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void update(PaisEntity entity)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Pais item = db.Pais.FirstOrDefault(e => e.IdPais == entity.IdPais);
                    if (item != null)
                    {
                        Pais cambios = PaisMapper.MapToModel(entity);
                        item.Nombre = cambios.Nombre;
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
                    Pais item = db.Pais.FirstOrDefault(e => e.IdPais == id);
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

        public List<PaisEntity> getAll()
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    List<Pais> list = db.Pais.ToList();
                    return list.Select(PaisMapper.MapToEntity).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<PaisEntity> getActivos()
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    List<Pais> list = db.Pais.Where(e => e.Activo).ToList();
                    return list.Select(PaisMapper.MapToEntity).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public PaisEntity getById(int id)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Pais item = db.Pais.FirstOrDefault(e => e.IdPais == id);

                    if (item != null)
                    {
                        return PaisMapper.MapToEntity(item);
                    }
                    else return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public PaisEntity getByNombre(string nombre)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Pais item = db.Pais.FirstOrDefault(e => e.Nombre == nombre);

                    if (item != null)
                    {
                        return PaisMapper.MapToEntity(item);
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

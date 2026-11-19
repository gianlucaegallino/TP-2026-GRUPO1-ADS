using DAL.Models;
using Entity;
using Entity.EFModel;
using Mapper;

namespace DAL
{
    public class TorneoDAL
    {
        public void add(TorneoEntity nuevoEntity)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Torneo nuevo = TorneoMapper.MapToModel(nuevoEntity);
                    db.Torneo.Add(nuevo);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void update(TorneoEntity entity)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Torneo item = db.Torneo.FirstOrDefault(e => e.IdTorneo == entity.IdTorneo);
                    if (item != null)
                    {
                        Torneo cambios = TorneoMapper.MapToModel(entity);
                        item.Nombre = cambios.Nombre;
                        item.Año = cambios.Año;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Baja logica: el boton "Activar / Desactivar" no borra el registro, cambia ACTIVO.
        public void cambiarEstado(int id, bool activo)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Torneo item = db.Torneo.FirstOrDefault(e => e.IdTorneo == id);
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

        public List<TorneoEntity> getAll()
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    List<Torneo> list = db.Torneo.ToList();
                    return list.Select(TorneoMapper.MapToEntity).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<TorneoEntity> getActivos()
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    List<Torneo> list = db.Torneo.Where(e => e.Activo).ToList();
                    return list.Select(TorneoMapper.MapToEntity).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public TorneoEntity getById(int id)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Torneo item = db.Torneo.FirstOrDefault(e => e.IdTorneo == id);

                    if (item != null)
                    {
                        return TorneoMapper.MapToEntity(item);
                    }
                    else return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Un torneo se identifica por nombre + año (ej: "Copa Libertadores 2026")
        public TorneoEntity getByNombreYAnio(string nombre, int anio)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Torneo item = db.Torneo.FirstOrDefault(e => e.Nombre == nombre && e.Año == anio);

                    if (item != null)
                    {
                        return TorneoMapper.MapToEntity(item);
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

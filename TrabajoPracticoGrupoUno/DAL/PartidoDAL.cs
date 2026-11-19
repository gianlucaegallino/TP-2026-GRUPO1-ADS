using DAL.Models;
using Entity;
using Entity.EFModel;
using Mapper;

namespace DAL
{
    public class PartidoDAL
    {
        public void add(PartidoEntity nuevoEntity, bool resultadoCargado)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Partido nuevo = PartidoMapper.MapToModel(nuevoEntity);

                    if (resultadoCargado)
                    {
                        nuevo.Fechafinpartido = DateTime.Now;
                    }
                    else
                    {
                        nuevo.Goleslocal = null;
                        nuevo.Golesvisitante = null;
                        nuevo.Fechafinpartido = null;
                    }

                    db.Partido.Add(nuevo);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void update(PartidoEntity entity, bool resultadoCargado)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Partido item = db.Partido.FirstOrDefault(e => e.IdPartido == entity.IdPartido);
                    if (item != null)
                    {
                        Partido cambios = PartidoMapper.MapToModel(entity);
                        item.IdTorneo = cambios.IdTorneo;
                        item.IdEquipoLocal = cambios.IdEquipoLocal;
                        item.IdEquipoVisitante = cambios.IdEquipoVisitante;
                        item.Fecha = cambios.Fecha;

                        if (resultadoCargado)
                        {
                            item.Goleslocal = cambios.Goleslocal;
                            item.Golesvisitante = cambios.Golesvisitante;
                            // Si ya tenia fecha de fin se conserva, si no se registra ahora
                            item.Fechafinpartido = item.Fechafinpartido ?? DateTime.Now;
                        }
                        else
                        {
                            item.Goleslocal = null;
                            item.Golesvisitante = null;
                            item.Fechafinpartido = null;
                        }

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
                    Partido item = db.Partido.FirstOrDefault(e => e.IdPartido == id);
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

        public List<PartidoEntity> getAll()
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    List<Partido> list = db.Partido.ToList();
                    return list.Select(PartidoMapper.MapToEntity).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<PartidoEntity> getActivos()
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    List<Partido> list = db.Partido.Where(e => e.Activo).ToList();
                    return list.Select(PartidoMapper.MapToEntity).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public PartidoEntity getById(int id)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Partido item = db.Partido.FirstOrDefault(e => e.IdPartido == id);

                    if (item != null)
                    {
                        return PartidoMapper.MapToEntity(item);
                    }
                    else return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<int> getIdsConResultado()
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    return db.Partido
                        .Where(e => e.Goleslocal != null && e.Golesvisitante != null)
                        .Select(e => e.IdPartido)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

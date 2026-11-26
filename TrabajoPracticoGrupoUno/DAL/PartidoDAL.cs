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
                        nuevo.Fechafinpartido = nuevoEntity.FechaFinPartido;
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
                        item.IdTorneo = entity.IdTorneo;
                        item.IdEquipoLocal = entity.IdEquipoLocal;
                        item.IdEquipoVisitante = entity.IdEquipoVisitante;
                        item.Fecha = entity.Fecha;

                        if (resultadoCargado)
                        {
                            item.Goleslocal = entity.GolesLocal;
                            item.Golesvisitante = entity.GolesVisitante;
                            item.Fechafinpartido = entity.FechaFinPartido;
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
                    return PartidoMapper.MapToEntity(list);
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
                    return PartidoMapper.MapToEntity(list);
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
    }
}

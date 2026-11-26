using DAL;
using Entity;
using System.Transactions;

namespace BLL
{
    public class PartidoBusiness
    {
        private PartidoDAL PartidoDal = new();
        private TorneoBusiness TorneoBusiness = new();
        private EquipoBusiness EquipoBusiness = new();

        // resultadoCargado = false -> el partido queda sin resultado (goles en NULL), se ignoran los goles de la entidad
        public void add(PartidoEntity tempEntity, bool resultadoCargado)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    // Validaciones
                    ValidarTorneoSeleccionado(tempEntity.IdTorneo);
                    ValidarExistenciaTorneoActivo(tempEntity.IdTorneo);
                    ValidarFechaEnAnioDelTorneo(tempEntity.IdTorneo, tempEntity.Fecha);
                    ValidarFechaFinPartido(tempEntity, resultadoCargado);
                    ValidarEquipoSeleccionado(tempEntity.IdEquipoLocal, "local");
                    ValidarEquipoSeleccionado(tempEntity.IdEquipoVisitante, "visitante");
                    ValidarEquiposDistintos(tempEntity.IdEquipoLocal, tempEntity.IdEquipoVisitante);
                    ValidarExistenciaEquipoActivo(tempEntity.IdEquipoLocal, "local");
                    ValidarExistenciaEquipoActivo(tempEntity.IdEquipoVisitante, "visitante");
                    ValidarEquipoSinPartido(tempEntity.IdEquipoLocal, tempEntity.Fecha, 0, "local");
                    ValidarEquipoSinPartido(tempEntity.IdEquipoVisitante, tempEntity.Fecha, 0, "visitante");
                    if (resultadoCargado) ValidarGoles(tempEntity.GolesLocal, tempEntity.GolesVisitante);

                    tempEntity.Activo = true;

                    PartidoDal.add(tempEntity, resultadoCargado);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void update(PartidoEntity tempEntity, bool resultadoCargado)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    ValidarIdSeleccionado(tempEntity.IdPartido);
                    ValidarExistenciaPorID(tempEntity.IdPartido);
                    ValidarTorneoSeleccionado(tempEntity.IdTorneo);
                    ValidarExistenciaTorneoActivo(tempEntity.IdTorneo);
                    ValidarFechaEnAnioDelTorneo(tempEntity.IdTorneo, tempEntity.Fecha);
                    ValidarFechaFinPartido(tempEntity, resultadoCargado);
                    ValidarEquipoSeleccionado(tempEntity.IdEquipoLocal, "local");
                    ValidarEquipoSeleccionado(tempEntity.IdEquipoVisitante, "visitante");
                    ValidarEquiposDistintos(tempEntity.IdEquipoLocal, tempEntity.IdEquipoVisitante);
                    ValidarExistenciaEquipoActivo(tempEntity.IdEquipoLocal, "local");
                    ValidarExistenciaEquipoActivo(tempEntity.IdEquipoVisitante, "visitante");
                    ValidarEquipoSinPartido(tempEntity.IdEquipoLocal, tempEntity.Fecha, tempEntity.IdPartido, "local");
                    ValidarEquipoSinPartido(tempEntity.IdEquipoVisitante, tempEntity.Fecha, tempEntity.IdPartido, "visitante");
                    if (resultadoCargado) ValidarGoles(tempEntity.GolesLocal, tempEntity.GolesVisitante);

                    PartidoDal.update(tempEntity, resultadoCargado);
                    trx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Activa si estaba inactivo, desactiva si estaba activo
        public void cambiarEstado(int id)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    ValidarIdSeleccionado(id);
                    ValidarExistenciaPorID(id);

                    PartidoEntity actual = getById(id);

                    if (!actual.Activo) // se está reactivando
                    {
                        ValidarExistenciaTorneoActivo(actual.IdTorneo);

                        ValidarFechaEnAnioDelTorneo(actual.IdTorneo, actual.Fecha);

                        ValidarFechaFinPartido(
                            actual, actual.FechaFinPartido.HasValue);

                        ValidarExistenciaEquipoActivo(actual.IdEquipoLocal, "local");
                        ValidarExistenciaEquipoActivo(actual.IdEquipoVisitante, "visitante");

                        ValidarEquipoSinPartido(actual.IdEquipoLocal, actual.Fecha, id, "local");
                        ValidarEquipoSinPartido(actual.IdEquipoVisitante, actual.Fecha, id, "visitante");
                    }

                    PartidoDal.cambiarEstado(id, !actual.Activo);
                    trx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PartidoEntity> getAll()
        {
            try
            {
                return PartidoDal.getAll();
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
                return PartidoDal.getActivos();
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
                return PartidoDal.getById(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //VALIDACIONES

        public void ValidarTorneoSeleccionado(int idTorneo)
        {
            if (idTorneo <= 0)
            {
                throw new Exception("Debe seleccionar un torneo.");
            }
        }

        public void ValidarExistenciaTorneoActivo(int idTorneo)
        {
            TorneoEntity torneo = TorneoBusiness.getById(idTorneo);
            if (torneo == null)
            {
                throw new Exception("El torneo no existe.");
            }
            if (!torneo.Activo)
            {
                throw new Exception("El torneo seleccionado esta inactivo.");
            }
        }

        public void ValidarFechaEnAnioDelTorneo(int idTorneo, DateTime fecha)
        {
            TorneoEntity torneo = TorneoBusiness.getById(idTorneo);
            if (fecha.Year != torneo.Año)
            {
                throw new Exception($"La fecha del partido debe estar dentro del año del torneo ({torneo.Año}).");
            }
        }

        public void ValidarFechaFinPartido(PartidoEntity partido, bool resultadoCargado)
        {
            if (resultadoCargado)
            {
                if (!partido.FechaFinPartido.HasValue)
                {
                    throw new Exception("Debe seleccionar la fecha de finalización del partido.");
                }

                if (partido.FechaFinPartido.Value <= partido.Fecha)
                {
                    throw new Exception("La fecha de finalización debe ser posterior a la fecha de inicio.");
                }

                if (partido.FechaFinPartido.Value > DateTime.Now)
                {
                    throw new Exception("No se puede cargar el resultado de un partido que todavía no terminó.");
                }

                ValidarFechaEnAnioDelTorneo(
                    partido.IdTorneo,
                    partido.FechaFinPartido.Value);
            }
        }

        public void ValidarEquipoSeleccionado(int idEquipo, string rol)
        {
            if (idEquipo <= 0)
            {
                throw new Exception($"Debe seleccionar el equipo {rol}.");
            }
        }

        public void ValidarExistenciaEquipoActivo(int idEquipo, string rol)
        {
            EquipoEntity equipo = EquipoBusiness.getById(idEquipo);
            if (equipo == null)
            {
                throw new Exception($"El equipo {rol} no existe.");
            }
            if (!equipo.Activo)
            {
                throw new Exception($"El equipo {rol} esta inactivo.");
            }
        }

        public void ValidarEquiposDistintos(int idLocal, int idVisitante)
        {
            if (idLocal == idVisitante)
            {
                throw new Exception("El equipo local y el visitante deben ser distintos.");
            }
        }

        public void ValidarGoles(int golesLocal, int golesVisitante)
        {
            if (golesLocal < 0 || golesLocal > 99 || golesVisitante < 0 || golesVisitante > 99)
            {
                throw new Exception("Los goles deben estar entre 0 y 99.");
            }
        }

        public void ValidarIdSeleccionado(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Debe seleccionar un partido de la grilla.");
            }
        }

        public void ValidarExistenciaPorID(int id)
        {
            if (getById(id) == null)
            {
                throw new Exception("El partido no existe.");
            }
        }
        // Un equipo no puede jugar dos partidos activos el mismo DIA (se compara solo la fecha, no la hora).
        // idPartidoActual = 0 al agregar; al modificar o reactivar se pasa el id para ignorar el propio partido.
        // rol ("local"/"visitante") solo se usa para armar el mensaje de error.
        public void ValidarEquipoSinPartido(int idEquipo, DateTime fecha, int idPartidoActual, string rol)
        {
            List<PartidoEntity> partidos = getActivos();

            foreach (PartidoEntity p in partidos)
            {
                if (p.IdPartido != idPartidoActual &&
                    p.Fecha.Date == fecha.Date &&
                    (p.IdEquipoLocal == idEquipo || p.IdEquipoVisitante == idEquipo))
                {
                    throw new Exception($"El equipo {rol} ya tiene un partido en esa fecha.");
                }
            }
        }
    }
}

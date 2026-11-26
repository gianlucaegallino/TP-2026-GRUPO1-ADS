using DAL;
using Entity;
using System.Transactions;

namespace BLL
{
    public class EquipoBusiness
    {
        private EquipoDAL EquipoDal = new();

        public void add(EquipoEntity tempEntity)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    tempEntity.Nombre = tempEntity.Nombre.Trim();

                    // Validaciones
                    ValidarNombre(tempEntity.Nombre);
                    ValidarInexistenciaPorNombre(tempEntity.Nombre, 0);
                    ValidarFechaFundacion(tempEntity.FechaFundacion);

                    tempEntity.Activo = true;

                    EquipoDal.add(tempEntity);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void update(EquipoEntity tempEntity)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    tempEntity.Nombre = tempEntity.Nombre.Trim();

                    ValidarIdSeleccionado(tempEntity.IdEquipo);
                    ValidarExistenciaPorID(tempEntity.IdEquipo);
                    ValidarNombre(tempEntity.Nombre);
                    ValidarInexistenciaPorNombre(tempEntity.Nombre, tempEntity.IdEquipo);
                    ValidarFechaFundacion(tempEntity.FechaFundacion);

                    EquipoDal.update(tempEntity);
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

                    EquipoEntity actual = getById(id);
                    if (actual.Activo)   // se está desactivando
                    {
                        ValidarSinJugadoresActivos(id);
                        ValidarSinPartidosActivos(id);
                    }
                    EquipoDal.cambiarEstado(id, !actual.Activo);
                    trx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<EquipoEntity> getAll()
        {
            try
            {
                return EquipoDal.getAll();
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
                return EquipoDal.getActivos();
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
                return EquipoDal.getById(id);
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
                return EquipoDal.getByNombre(nombre);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //VALIDACIONES

        public void ValidarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre) || nombre.Length > 50)
            {
                throw new Exception("El nombre del equipo debe tener entre uno y cincuenta caracteres.");
            }
        }

        // idActual = 0 al agregar; al modificar se pasa el id para que no choque consigo mismo
        public void ValidarInexistenciaPorNombre(string nombre, int idActual)
        {
            EquipoEntity existente = getByNombre(nombre);
            if (existente != null && existente.IdEquipo != idActual)
            {
                throw new Exception("Ya existe un equipo con ese nombre.");
            }
        }

        public void ValidarFechaFundacion(DateTime fecha)
        {
            if (fecha.Date > DateTime.Today)
            {
                throw new Exception("La fecha de fundacion no puede ser futura.");
            }
        }

        public void ValidarIdSeleccionado(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Debe seleccionar un equipo de la grilla.");
            }
        }

        public void ValidarExistenciaPorID(int id)
        {
            if (getById(id) == null)
            {
                throw new Exception("El equipo no existe.");
            }
        }

        // Los business se crean dentro del método (y no como campo) para evitar una
        // referencia circular de instancias: JugadorBusiness y PartidoBusiness ya
        // crean un EquipoBusiness como campo.
        public void ValidarSinJugadoresActivos(int idEquipo)
        {
            List<JugadorEntity> jugadores = new JugadorBusiness().getActivos();

            foreach (JugadorEntity j in jugadores)
            {
                if (j.IdEquipo == idEquipo)
                {
                    throw new Exception("No se puede desactivar el equipo porque tiene jugadores activos.");
                }
            }
        }

        public void ValidarSinPartidosActivos(int idEquipo)
        {
            List<PartidoEntity> partidos = new PartidoBusiness().getActivos();

            foreach (PartidoEntity p in partidos)
            {
                if (p.IdEquipoLocal == idEquipo || p.IdEquipoVisitante == idEquipo)
                {
                    throw new Exception("No se puede desactivar el equipo porque tiene partidos activos.");
                }
            }
        }
    }
}

using DAL;
using Entity;
using System.Transactions;

namespace BLL
{
    public class TorneoBusiness
    {
        private TorneoDAL TorneoDal = new();

        public void add(TorneoEntity tempEntity)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    tempEntity.Nombre = tempEntity.Nombre.Trim();

                    // Validaciones
                    ValidarNombre(tempEntity.Nombre);
                    ValidarAnio(tempEntity.Año);
                    ValidarInexistenciaPorNombreYAnio(tempEntity.Nombre, tempEntity.Año, 0);

                    tempEntity.Activo = true;

                    TorneoDal.add(tempEntity);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void update(TorneoEntity tempEntity)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    tempEntity.Nombre = tempEntity.Nombre.Trim();

                    ValidarIdSeleccionado(tempEntity.IdTorneo);
                    ValidarExistenciaPorID(tempEntity.IdTorneo);
                    ValidarNombre(tempEntity.Nombre);
                    ValidarAnio(tempEntity.Año);
                    ValidarInexistenciaPorNombreYAnio(tempEntity.Nombre, tempEntity.Año, tempEntity.IdTorneo);
                    ValidarCambioDeAnio(tempEntity.IdTorneo, tempEntity.Año);

                    TorneoDal.update(tempEntity);
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

                    TorneoEntity actual = getById(id);
                    if (actual.Activo)   // se está desactivando
                    {
                        ValidarSinPartidosActivos(id);
                    }
                    TorneoDal.cambiarEstado(id, !actual.Activo);
                    trx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TorneoEntity> getAll()
        {
            try
            {
                return TorneoDal.getAll();
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
                return TorneoDal.getActivos();
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
                return TorneoDal.getById(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public TorneoEntity getByNombreYAnio(string nombre, int anio)
        {
            try
            {
                return TorneoDal.getByNombreYAnio(nombre, anio);
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
                throw new Exception("El nombre del torneo debe tener entre uno y cincuenta caracteres.");
            }
        }

        public void ValidarAnio(int anio)
        {
            if (anio < 1900 || anio > 2100)
            {
                throw new Exception("El año del torneo debe estar entre 1900 y 2100.");
            }
        }

        // idActual = 0 al agregar; al modificar se pasa el id para que no choque consigo mismo
        public void ValidarInexistenciaPorNombreYAnio(string nombre, int anio, int idActual)
        {
            TorneoEntity existente = getByNombreYAnio(nombre, anio);
            if (existente != null && existente.IdTorneo != idActual)
            {
                throw new Exception("Ya existe un torneo con ese nombre y año.");
            }
        }

        public void ValidarIdSeleccionado(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Debe seleccionar un torneo de la grilla.");
            }
        }

        // PartidoBusiness se crea dentro del método (no como campo) para evitar una referencia
        // circular de instancias: PartidoBusiness ya crea un TorneoBusiness como campo.
        public void ValidarSinPartidosActivos(int idTorneo)
        {
            List<PartidoEntity> partidos = new PartidoBusiness().getActivos();

            foreach (PartidoEntity p in partidos)
            {
                if (p.IdTorneo == idTorneo)
                {
                    throw new Exception("No se puede desactivar el torneo porque tiene partidos activos.");
                }
            }
        }

        // PartidoBusiness se crea dentro del método (no como campo), igual que en ValidarSinPartidosActivos.
        public void ValidarCambioDeAnio(int idTorneo, int anioNuevo)
        {
            TorneoEntity actual = getById(idTorneo);
            if (actual.Año != anioNuevo)
            {
                List<PartidoEntity> partidos = new PartidoBusiness().getAll();

                foreach (PartidoEntity p in partidos)
                {
                    if (p.IdTorneo == idTorneo)
                    {
                        throw new Exception("No se puede cambiar el año del torneo porque tiene partidos cargados.");
                    }
                }
            }
        }

        public void ValidarExistenciaPorID(int id)
        {
            if (getById(id) == null)
            {
                throw new Exception("El torneo no existe.");
            }
        }
    }
}

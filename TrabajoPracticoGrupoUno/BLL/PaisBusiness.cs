using DAL;
using Entity;
using System.Transactions;

namespace BLL
{
    public class PaisBusiness
    {
        private PaisDAL PaisDal = new();

        public void add(PaisEntity tempEntity)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    tempEntity.Nombre = tempEntity.Nombre.Trim();

                    // Validaciones
                    ValidarNombre(tempEntity.Nombre);
                    ValidarInexistenciaPorNombre(tempEntity.Nombre, 0);

                    tempEntity.Activo = true;

                    PaisDal.add(tempEntity);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void update(PaisEntity tempEntity)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    tempEntity.Nombre = tempEntity.Nombre.Trim();

                    ValidarIdSeleccionado(tempEntity.IdPais);
                    ValidarExistenciaPorID(tempEntity.IdPais);
                    ValidarNombre(tempEntity.Nombre);
                    ValidarInexistenciaPorNombre(tempEntity.Nombre, tempEntity.IdPais);

                    PaisDal.update(tempEntity);
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

                    PaisEntity actual = getById(id);
                    PaisDal.cambiarEstado(id, !actual.Activo);
                    trx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PaisEntity> getAll()
        {
            try
            {
                return PaisDal.getAll();
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
                return PaisDal.getActivos();
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
                return PaisDal.getById(id);
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
                return PaisDal.getByNombre(nombre);
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
                throw new Exception("El nombre del pais debe tener entre uno y cincuenta caracteres.");
            }
        }

        // idActual = 0 al agregar; al modificar se pasa el id para que no choque consigo mismo
        public void ValidarInexistenciaPorNombre(string nombre, int idActual)
        {
            PaisEntity existente = getByNombre(nombre);
            if (existente != null && existente.IdPais != idActual)
            {
                throw new Exception("Ya existe un pais con ese nombre.");
            }
        }

        public void ValidarIdSeleccionado(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Debe seleccionar un pais de la grilla.");
            }
        }

        public void ValidarExistenciaPorID(int id)
        {
            if (getById(id) == null)
            {
                throw new Exception("El pais no existe.");
            }
        }
    }
}

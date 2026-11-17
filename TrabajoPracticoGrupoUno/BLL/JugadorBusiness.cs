using DAL;
using Entity;
using System.Transactions;

namespace BLL
{
    public class JugadorBusiness
    {
        private JugadorDAL JugadorDal = new();
        private EquipoBusiness EquipoBusiness = new();
        private PaisBusiness PaisBusiness = new();

        public void add(JugadorEntity tempEntity)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    tempEntity.Nombre = tempEntity.Nombre.Trim();
                    tempEntity.Apellido = tempEntity.Apellido.Trim();

                    // Validaciones
                    ValidarNombre(tempEntity.Nombre);
                    ValidarApellido(tempEntity.Apellido);
                    ValidarNumeroCamiseta(tempEntity.NumeroCamiseta);
                    ValidarEquipoSeleccionado(tempEntity.IdEquipo);
                    ValidarExistenciaEquipoActivo(tempEntity.IdEquipo);
                    ValidarPaisSeleccionado(tempEntity.IdPais);
                    ValidarExistenciaPaisActivo(tempEntity.IdPais);

                    tempEntity.Activo = true;

                    JugadorDal.add(tempEntity);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void update(JugadorEntity tempEntity)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    tempEntity.Nombre = tempEntity.Nombre.Trim();
                    tempEntity.Apellido = tempEntity.Apellido.Trim();

                    ValidarIdSeleccionado(tempEntity.IdJugador);
                    ValidarExistenciaPorID(tempEntity.IdJugador);
                    ValidarNombre(tempEntity.Nombre);
                    ValidarApellido(tempEntity.Apellido);
                    ValidarNumeroCamiseta(tempEntity.NumeroCamiseta);
                    ValidarEquipoSeleccionado(tempEntity.IdEquipo);
                    ValidarExistenciaEquipoActivo(tempEntity.IdEquipo);
                    ValidarPaisSeleccionado(tempEntity.IdPais);
                    ValidarExistenciaPaisActivo(tempEntity.IdPais);

                    JugadorDal.update(tempEntity);
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

                    JugadorEntity actual = getById(id);
                    JugadorDal.cambiarEstado(id, !actual.Activo);
                    trx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<JugadorEntity> getAll()
        {
            try
            {
                return JugadorDal.getAll();
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
                return JugadorDal.getActivos();
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
                return JugadorDal.getById(id);
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
                throw new Exception("El nombre del jugador debe tener entre uno y cincuenta caracteres.");
            }
        }

        public void ValidarApellido(string apellido)
        {
            if (string.IsNullOrWhiteSpace(apellido) || apellido.Length > 50)
            {
                throw new Exception("El apellido del jugador debe tener entre uno y cincuenta caracteres.");
            }
        }

        public void ValidarNumeroCamiseta(int numero)
        {
            if (numero < 1 || numero > 99)
            {
                throw new Exception("El numero de camiseta debe estar entre 1 y 99.");
            }
        }

        public void ValidarEquipoSeleccionado(int idEquipo)
        {
            if (idEquipo <= 0)
            {
                throw new Exception("Debe seleccionar un equipo.");
            }
        }

        public void ValidarExistenciaEquipoActivo(int idEquipo)
        {
            EquipoEntity equipo = EquipoBusiness.getById(idEquipo);
            if (equipo == null)
            {
                throw new Exception("El equipo no existe.");
            }
            if (!equipo.Activo)
            {
                throw new Exception("El equipo seleccionado esta inactivo.");
            }
        }

        public void ValidarPaisSeleccionado(int idPais)
        {
            if (idPais <= 0)
            {
                throw new Exception("Debe seleccionar un pais.");
            }
        }

        public void ValidarExistenciaPaisActivo(int idPais)
        {
            PaisEntity pais = PaisBusiness.getById(idPais);
            if (pais == null)
            {
                throw new Exception("El pais no existe.");
            }
            if (!pais.Activo)
            {
                throw new Exception("El pais seleccionado esta inactivo.");
            }
        }

        public void ValidarIdSeleccionado(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Debe seleccionar un jugador de la grilla.");
            }
        }

        public void ValidarExistenciaPorID(int id)
        {
            if (getById(id) == null)
            {
                throw new Exception("El jugador no existe.");
            }
        }
    }
}

using Entity;
using Mapper;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class AlquilerDAL
    {
        private TipoBicicletaDAL biciDal = new();

        public void agregarAlquiler(Alquiler alquiler)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["GrupoUnoFutbolConnection"].ConnectionString))
                {
                    sqlConnection.Open();
                    string sql = "INSERT INTO ALQUILER (TIPO_BICICLETA, DNI_CLIENTE, IMPORTE_TOTAL, FECHA_REGISTRO, FECHA_ALQUILER) " +
                        "VALUES (@tipoBicicleta, @dniCliente, @importeTotal, @fechaRegistro, @fechaAlquiler)";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@tipoBicicleta", alquiler.TipoBicicleta.IdTipoBicicleta);
                        sqlCommand.Parameters.AddWithValue("@dniCliente", alquiler.DniCliente);
						sqlCommand.Parameters.AddWithValue("@importeTotal", alquiler.ImporteTotal);
						sqlCommand.Parameters.AddWithValue("@fechaRegistro", alquiler.FechaRegistro);
						sqlCommand.Parameters.AddWithValue("@fechaAlquiler", alquiler.FechaAlquiler);


						sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void eliminarAlquiler(int idAlquiler)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["GrupoUnoFutbolConnection"].ConnectionString))
                {
                    sqlConnection.Open();
                    string sql = "DELETE FROM ALQUILER WHERE NUMERO_ALQUILER = @idAlquiler";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@idAlquiler", idAlquiler);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void modificarAlquiler(int idAlquiler, double nuevoImporte, DateTime nuevaFechaAlquiler)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["GrupoUnoFutbolConnection"].ConnectionString))
                {
                    sqlConnection.Open();
                    string sql = "UPDATE ALQUILER SET IMPORTE_TOTAL = @importeTotal, FECHA_ALQUILER = @fechaAlquiler WHERE NUMERO_ALQUILER = @idAlquiler";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@idAlquiler", idAlquiler);
                        sqlCommand.Parameters.AddWithValue("@importeTotal", nuevoImporte);
                        sqlCommand.Parameters.AddWithValue("@fechaAlquiler", nuevaFechaAlquiler);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Alquiler obtenerAlquilerPorId(int idAlquiler)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["GrupoUnoFutbolConnection"].ConnectionString))
                {
                    sqlConnection.Open();
                    string sql = "SELECT * FROM ALQUILER WHERE NUMERO_ALQUILER = @idAlquiler";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@idAlquiler", idAlquiler);

                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                TipoBicicleta tipoBicicleta = biciDal.obtenerTipoBicicletaPorId(Convert.ToInt32(sqlDataReader["TIPO_BICICLETA"]));
                                return AlquilerMapper.Map(sqlDataReader, tipoBicicleta);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Alquiler> obtenerAlquileres()
        {
            try
            {
                List<Alquiler> alquilers = new List<Alquiler>();

                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["GrupoUnoFutbolConnection"].ConnectionString))
                {
                    sqlConnection.Open();
                    string sql = "SELECT * FROM ALQUILER";

                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                TipoBicicleta tipoBicicleta = biciDal.obtenerTipoBicicletaPorId(Convert.ToInt32(sqlDataReader["TIPO_BICICLETA"]));
                                alquilers.Add(AlquilerMapper.Map(sqlDataReader, tipoBicicleta));
                            }
                        }
                    }
                }
                return alquilers;

            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}

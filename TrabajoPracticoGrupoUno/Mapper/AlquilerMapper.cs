using Entity;
using Microsoft.Data.SqlClient;

namespace Mapper
{
    public class AlquilerMapper
    {
        public static Alquiler Map(SqlDataReader reader, TipoBicicleta tipoBicicleta)
        {
            return new Alquiler()
            {
                NumeroAlquiler = Convert.ToInt32(reader["NUMERO_ALQUILER"]),
                DniCliente = Convert.ToString(reader["DNI_CLIENTE"]),
                ImporteTotal = Convert.ToDouble(reader["IMPORTE_TOTAL"]),
                FechaRegistro = Convert.ToDateTime(reader["FECHA_REGISTRO"]),
                FechaAlquiler = Convert.ToDateTime(reader["FECHA_ALQUILER"]),
                TipoBicicleta = tipoBicicleta
            };
        }
    }
}

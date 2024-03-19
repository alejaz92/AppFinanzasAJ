using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFinanzasAJ.Negocio;


namespace AppFinanzasAJ.Data
{
    public class PagoTarjetaAdapter : Adapter
    {
        public void insertPago(string tarjeta, string fecha)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;

                string sqlFecha = "(SELECT DISTINCT IDFECHA FROM Dim_Tiempo WHERE FECHA  = '" + fecha + "')";

                string sqlQuery = "INSERT INTO Pago_Tarjeta (idTarjeta, fechaMes) VALUES (@TARJETA, @FECHA)";


                sqlQuery = sqlQuery.Replace("@TARJETA", "(SELECT idTarjeta FROM Dim_Tarjeta WHERE nombre = '" + tarjeta + "')");
                sqlQuery = sqlQuery.Replace("@FECHA", sqlFecha);

                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al insertar tarjeta", Ex);
                throw Excepcion;
            }
        }
        
    }
       
}

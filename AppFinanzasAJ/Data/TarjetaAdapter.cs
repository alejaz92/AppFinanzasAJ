using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFinanzasAJ.Negocio;


namespace AppFinanzasAJ.Data
{
    public class TarjetaAdapter : Adapter
    {

        public List<Tarjeta> GetTarjetas()
        {
            List<Tarjeta> ListaTarjetas = new List<Tarjeta>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT NOMBRE FROM Dim_Tarjeta;";

                SqlCommand cmdTarjetas = null;

                cmdTarjetas = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdTarjetas.ExecuteReader();

                while (reader.Read())
                {
                    Tarjeta newTarjeta = new Tarjeta();
                    newTarjeta.NOMBRE = (string)reader["NOMBRE"];
                    ListaTarjetas.Add(newTarjeta);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar las tarjetas", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaTarjetas;
        }


        public void insertTarjeta(string nombreVar)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;

                string sqlQuery = "INSERT INTO Dim_Tarjeta (nombre) VALUES ('@NOMBRE')";

                sqlQuery = sqlQuery.Replace("@NOMBRE", nombreVar);

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

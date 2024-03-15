using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFinanzasAJ.Negocio;


namespace AppFinanzasAJ.Data
{
    public class CuentaAdapter : Adapter
    {
        public List<Cuenta> Getcuentas(string tipoCta)
        {
            List<Cuenta> ListaCuentas = new List<Cuenta>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT NOMBRE FROM Dim_Cuenta WHERE tipo = '@TIPO';";

                consulta_select = consulta_select.Replace("@TIPO", tipoCta);

                SqlCommand cmdCuentas = null;

                cmdCuentas = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdCuentas.ExecuteReader();

                while (reader.Read())
                {
                    Cuenta newCuenta = new Cuenta();
                    newCuenta.NOMBRE = (string)reader["NOMBRE"];
                    ListaCuentas.Add(newCuenta);
                }
               
                reader.Close();
    
                
                
            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar las cuentas", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaCuentas;
        }

        public void insertCuenta(string nombreVar, string tipoVar)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;

                string sqlQuery = "INSERT INTO Dim_Cuenta (nombre, tipo) VALUES ('@NOMBRE', '@TIPO')";

                sqlQuery = sqlQuery.Replace("@NOMBRE", nombreVar);
                sqlQuery = sqlQuery.Replace("@TIPO", tipoVar);

                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();
              
            }
            catch(Exception Ex)
            {
                Exception Excepcion = new Exception("Error al insertar cuenta", Ex);
                throw Excepcion;
            }
        }

        public void deleteCuenta(string nombreVar)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;

                string sqlQuery = "DELETE FROM Dim_Cuenta WHERE NOMBRE = '@NOMBRE'";

                sqlQuery = sqlQuery.Replace("@NOMBRE", nombreVar);

                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al eliminar cuenta", Ex);
                throw Excepcion;
            }
        }
    }
       
}

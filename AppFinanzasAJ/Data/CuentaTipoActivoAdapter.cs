using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFinanzasAJ.Negocio;


namespace AppFinanzasAJ.Data
{
    public class CuentaTipoActivoAdapter : Adapter
    {
       public void clearCuenta(string cuenta)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;

                string sqlQuery = "DELETE FROM Cuenta_TipoActivo WHERE IDCUENTA = (SELECT IDCUENTA FROM Dim_Cuenta " +
                    "WHERE NOMBRE = '@CUENTA')";

                sqlQuery = sqlQuery.Replace("@CUENTA", cuenta);

                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al limpiar la cuenta", Ex);
                throw Excepcion;
            }
        }

        public void InsertCuenta(string cuenta, string tipoActivo)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;

                string sqlQuery = "INSERT INTO Cuenta_TipoActivo (IDCUENTA, IDTIPOACTIVO) VALUES ((SELECT IDCUENTA FROM " +
                    "Dim_Cuenta WHERE NOMBRE = '@CUENTA'),(SELECT IDTIPOACTIVO FROM Dim_Tipo_Activo WHERE NOMBRE = " +
                    "'@TIPOACTIVO'));";

                sqlQuery = sqlQuery.Replace("@CUENTA", cuenta);
                sqlQuery = sqlQuery.Replace("@TIPOACTIVO", tipoActivo);

                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al actualizar la cuenta", Ex);
                throw Excepcion;
            }
        }
    }
       
}

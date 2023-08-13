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
        public List<Cuenta> Getcuentas()
        {
            List<Cuenta> ListaCuentas = new List<Cuenta>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT NOMBRE FROM Dim_Cuenta;";

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
    }
       
}

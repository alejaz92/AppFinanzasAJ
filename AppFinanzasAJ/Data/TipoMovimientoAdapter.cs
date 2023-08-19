using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFinanzasAJ.Negocio;


namespace AppFinanzasAJ.Data
{
    public class TipoMovimientoAdapter : Adapter
    {
        public List<TipoMovimiento> GetTiposMovimiento()
        {
            List<TipoMovimiento> ListaTiposMovimiento = new List<TipoMovimiento>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT DESCRIPCION, INGEGR FROM Dim_TipoMovimiento";

                SqlCommand cmdTiposMovimiento = null;

                cmdTiposMovimiento = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdTiposMovimiento.ExecuteReader();

                while (reader.Read())
                {
                    TipoMovimiento newTipoMovimiento = new TipoMovimiento();
                    newTipoMovimiento.DESCRIPCION = (string)reader["DESCRIPCION"];
                    newTipoMovimiento.INGEGR = (string)reader["INGEGR"];
                    ListaTiposMovimiento.Add(newTipoMovimiento);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar los tipos de movimiento", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaTiposMovimiento;
        }

    }
       
}

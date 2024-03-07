using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFinanzasAJ.Negocio;


namespace AppFinanzasAJ.Data
{
    public class TipoActivoAdapter : Adapter
    {
        public List<TipoActivo> GetTiposActivo()
        {
            List<TipoActivo> ListaTiposActivo = new List<TipoActivo>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT NOMBRE FROM Dim_Tipo_Activo;";

                SqlCommand cmdTipoActivo = null;

                cmdTipoActivo = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdTipoActivo.ExecuteReader();

                while (reader.Read())
                {
                    TipoActivo newTipoActivo = new TipoActivo();
                    newTipoActivo.NOMBRE = (string)reader["NOMBRE"];
                    ListaTiposActivo.Add(newTipoActivo);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar los tipos de activos", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaTiposActivo;


        }

    }
}

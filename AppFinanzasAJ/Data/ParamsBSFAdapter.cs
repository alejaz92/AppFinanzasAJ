using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFinanzasAJ.Negocio;


namespace AppFinanzasAJ.Data
{
    public class ParamsBSFAdapter : Adapter
    {
       public List<paramsBSF> GetValues()
        {
            List<paramsBSF> ListaParamsBSF = new List<paramsBSF>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT * FROM paramsBSF;";

                SqlCommand cmdParamsBSF = null;

                cmdParamsBSF = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdParamsBSF.ExecuteReader();

                while (reader.Read())
                {
                    paramsBSF newParamsBSF = new paramsBSF();
                    newParamsBSF.parametro = (string)reader["parametro"];
                    newParamsBSF.valor = (decimal)reader["valor"];

                    ListaParamsBSF.Add(newParamsBSF);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar los parametros", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaParamsBSF;
        }

        public void updateParams(string montoVar, string porcentajeVar)
        {
            try
            {
                this.OpenConnection();
                SqlCommand updateSQL = null;

                montoVar = montoVar.Replace(",", ".");
                porcentajeVar = porcentajeVar.Replace(",", ".");

                string sqlQuery1 = "UPDATE paramsBSF SET valor = @MONTO WHERE parametro = 'totalMes';";
                string sqlQuery2  =  "UPDATE paramsBSF SET valor = @PORCENTAJE WHERE parametro = 'porcDev';";

                sqlQuery1 = sqlQuery1.Replace("@MONTO", montoVar);
                sqlQuery2 = sqlQuery2.Replace("@PORCENTAJE", porcentajeVar);

                updateSQL = new SqlCommand(sqlQuery1, SqlConn);

                updateSQL.ExecuteNonQuery();

                updateSQL = new SqlCommand(sqlQuery2, SqlConn);

                updateSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al actualizar paremetros", Ex);
                throw Excepcion;
            }
        }


    }
       
}

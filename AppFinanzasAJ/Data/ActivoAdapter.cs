using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFinanzasAJ.Negocio;


namespace AppFinanzasAJ.Data
{
    public class ActivoAdapter : Adapter
    {
        public List<Activo> GetActivos(string tipoAct)
        {
            List<Activo> ListaActivos = new List<Activo>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT A.NOMBRE FROM Dim_Activo A INNER JOIN Dim_Tipo_Activo TA ON TA.idTipoActivo = A.idTipoActivo WHERE TA.nombre = '@TA';";

                consulta_select = consulta_select.Replace("@TA", tipoAct);

                SqlCommand cmdActivos = null;

                cmdActivos = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdActivos.ExecuteReader();

                while (reader.Read())
                {
                    Activo newActivo = new Activo();
                    newActivo.NOMBRE = (string)reader["NOMBRE"];
                    ListaActivos.Add(newActivo);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar las activos", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaActivos;
        }


        public List<Activo> GetActivosPrincipal()
        {
            List<Activo> ListaActivos = new List<Activo>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT A.NOMBRE, ESPRINCIPAL FROM Dim_Activo A INNER JOIN Dim_Tipo_Activo TA ON TA.idTipoActivo = A.idTipoActivo WHERE TA.NOMBRE = 'Moneda';";

                SqlCommand cmdActivos = null;

                cmdActivos = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdActivos.ExecuteReader();

                while (reader.Read())
                {
                    Activo newActivo = new Activo();
                    newActivo.NOMBRE = (string)reader["NOMBRE"];
                    newActivo.ESPRINCIPAL = (bool)reader["ESPRINCIPAL"];
                    ListaActivos.Add(newActivo);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar las activos", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaActivos;
        }

        public List<Activo> GetActivoRef()
        {
            List<Activo> ListaActivos = new List<Activo>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT A.NOMBRE, esReferencia FROM Dim_Activo A INNER JOIN Dim_Tipo_Activo TA ON TA.idTipoActivo = A.idTipoActivo WHERE TA.NOMBRE = 'Moneda';";

                SqlCommand cmdActivos = null;

                cmdActivos = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdActivos.ExecuteReader();

                while (reader.Read())
                {
                    Activo newActivo = new Activo();
                    newActivo.NOMBRE = (string)reader["NOMBRE"];
                    newActivo.ESREFERENCIACOTIZ = (bool)reader["ESREFERENCIA"];
                    ListaActivos.Add(newActivo);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar las activos", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaActivos;
        }

        public List<Activo> GetActivosEdit(string nombreVar)
        {
            List<Activo> ListaActivos = new List<Activo>();
            try
            {
                OpenConnection();
                string sqlQuery = "SELECT IDACTIVO, SIMBOLO,NOMBRE FROM Dim_Activo WHERE NOMBRE = '@NOMBRE';";

                sqlQuery = sqlQuery.Replace("@NOMBRE", nombreVar);

                SqlCommand cmdActivos = null;

                cmdActivos = new SqlCommand(sqlQuery, SqlConn);

                SqlDataReader reader = cmdActivos.ExecuteReader();

                while (reader.Read())
                {
                    Activo newActivo = new Activo();
                    newActivo.NOMBRE = (string)reader["NOMBRE"];
                    newActivo.SIMBOLO = (string)reader["SIMBOLO"];
                    //newActivo.ESFIAT = (bool)reader["ESFIAT"];
                    newActivo.IDACTIVO = (int)reader["IDACTIVO"];
                    ListaActivos.Add(newActivo);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar las activos", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaActivos;
        }

        public void deleteActivo(string nombreVar)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;

                string sqlQuery = "DELETE FROM Dim_Activo WHERE NOMBRE = '@NOMBRE'";

                sqlQuery = sqlQuery.Replace("@NOMBRE", nombreVar);

                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al eliminar activo", Ex);
                throw Excepcion;
            }
        }


        public void insertActivo(string nombreVar, string simboloVar, string tipoAct)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;

                string sqlQuery = "INSERT INTO Dim_Activo (idTipoActivo, simbolo, nombre, esPrincipal, esReferencia) VALUES (@TIPOACT,'@SIMBOLO', '@NOMBRE',0, 0)";
               
                sqlQuery = sqlQuery.Replace("@TIPOACT", "(SELECT DISTINCT idTipoActivo FROM Dim_Tipo_Activo WHERE nombre = '"+ tipoAct +"')");
                sqlQuery = sqlQuery.Replace("@NOMBRE", nombreVar);
                sqlQuery = sqlQuery.Replace("@SIMBOLO", simboloVar);


                

                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al insertar activo", Ex);
                throw Excepcion;
            }


        }

        public void updatetActivo(int idVar, string nombreVar, string simboloVar)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;

                string sqlQuery = "UPDATE Dim_Activo SET simbolo = '@SIMBOLO', nombre = '@NOMBRE' WHERE IDACTIVO = @ID";

                sqlQuery = sqlQuery.Replace("@NOMBRE", nombreVar);
                sqlQuery = sqlQuery.Replace("@ID",idVar.ToString());
                sqlQuery = sqlQuery.Replace("@SIMBOLO", simboloVar);



                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al actualizar activo", Ex);
                throw Excepcion;
            }


        }


        public void updatetActivoPrincipal(string nombreVar)
        {
            try
            {
                this.OpenConnection();
                SqlCommand updateSQL = null;

                string sqlQuery = "UPDATE Dim_Activo SET ESPRINCIPAL = CASE WHEN NOMBRE = '@NOMBRE' THEN 1 ELSE 0 END";

                sqlQuery = sqlQuery.Replace("@NOMBRE", nombreVar);




                updateSQL = new SqlCommand(sqlQuery, SqlConn);

                updateSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al actualizar activo principal", Ex);
                throw Excepcion;
            }


        }

        public void updatetActivoRef(string nombreVar)
        {
            try
            {
                this.OpenConnection();
                SqlCommand updateSQL = null;

                string sqlQuery = "UPDATE Dim_Activo SET ESREFERENCIA = CASE WHEN NOMBRE = '@NOMBRE' THEN 1 ELSE 0 END";

                sqlQuery = sqlQuery.Replace("@NOMBRE", nombreVar);


                updateSQL = new SqlCommand(sqlQuery, SqlConn);

                updateSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al actualizar activo de referencia", Ex);
                throw Excepcion;
            }


        }

        public List<Activo> GetPares()
        {
            List<Activo> ListaActivos = new List<Activo>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT idActivo, simbolo FROM Dim_Activo ORDER BY ESREFERENCIA DESC;";

                SqlCommand cmdActivos = null;

                cmdActivos = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdActivos.ExecuteReader();

                while (reader.Read())
                {

                    Activo activo = new Activo();
                    activo.IDACTIVO = (int)reader["idActivo"];
                    activo.SIMBOLO = (string)reader["simbolo"];
                    ListaActivos.Add(activo);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar las activos", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaActivos;
        }

    }
       
}

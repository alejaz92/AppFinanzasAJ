using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFinanzasAJ.Negocio;


namespace AppFinanzasAJ.Data
{
    public class MonedaAdapter : Adapter
    {
        public List<Moneda> GetMonedas()
        {
            List<Moneda> ListaMonedas = new List<Moneda>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT NOMBRE FROM Dim_Moneda;";

                SqlCommand cmdMonedas = null;

                cmdMonedas = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdMonedas.ExecuteReader();

                while (reader.Read())
                {
                    Moneda newMoneda = new Moneda();
                    newMoneda.NOMBRE = (string)reader["NOMBRE"];
                    ListaMonedas.Add(newMoneda);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar las monedas", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaMonedas;
        }

        public List<Moneda> GetMonedasPrincipal()
        {
            List<Moneda> ListaMonedas = new List<Moneda>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT NOMBRE, ESPRINCIPAL FROM Dim_Moneda;";

                SqlCommand cmdMonedas = null;

                cmdMonedas = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdMonedas.ExecuteReader();

                while (reader.Read())
                {
                    Moneda newMoneda = new Moneda();
                    newMoneda.NOMBRE = (string)reader["NOMBRE"];
                    newMoneda.ESPRINCIPAL = (bool)reader["ESPRINCIPAL"];
                    ListaMonedas.Add(newMoneda);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar las monedas", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaMonedas;
        }

        public List<Moneda> GetMonedasEdit(string nombreVar)
        {
            List<Moneda> ListaMonedas = new List<Moneda>();
            try
            {
                OpenConnection();
                string sqlQuery = "SELECT IDMONEDA, SIMBOLO,NOMBRE, ESFIAT FROM Dim_Moneda WHERE NOMBRE = '@NOMBRE';";

                sqlQuery = sqlQuery.Replace("@NOMBRE", nombreVar);

                SqlCommand cmdMonedas = null;

                cmdMonedas = new SqlCommand(sqlQuery, SqlConn);

                SqlDataReader reader = cmdMonedas.ExecuteReader();

                while (reader.Read())
                {
                    Moneda newMoneda = new Moneda();
                    newMoneda.NOMBRE = (string)reader["NOMBRE"];
                    newMoneda.SIMBOLO = (string)reader["SIMBOLO"];
                    newMoneda.ESFIAT = (bool)reader["ESFIAT"];
                    newMoneda.IDMONEDA = (int)reader["IDMONEDA"];
                    ListaMonedas.Add(newMoneda);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar las monedas", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaMonedas;
        }

        public void deleteMoneda(string nombreVar)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;

                string sqlQuery = "DELETE FROM Dim_Moneda WHERE NOMBRE = '@NOMBRE'";

                sqlQuery = sqlQuery.Replace("@NOMBRE", nombreVar);

                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al eliminar moneda", Ex);
                throw Excepcion;
            }
        }


        public void insertMoneda(string nombreVar, string simboloVar, bool esFiatVar)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;

                string sqlQuery = "INSERT INTO Dim_Moneda (simbolo, nombre, esFiat, esPrincipal) VALUES ('@SIMBOLO', '@NOMBRE', @ESFIAT, 0)";

                sqlQuery = sqlQuery.Replace("@NOMBRE", nombreVar);
                sqlQuery = sqlQuery.Replace("@SIMBOLO", simboloVar);

                if (esFiatVar == true)
                {
                    sqlQuery = sqlQuery.Replace("@ESFIAT", "1");
                }
                else
                {
                    sqlQuery = sqlQuery.Replace("@ESFIAT", "0");
                }
                

                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al insertar moneda", Ex);
                throw Excepcion;
            }


        }

        public void updatetMoneda(int idVar, string nombreVar, string simboloVar, bool esFiatVar)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;

                string sqlQuery = "UPDATE Dim_Moneda SET simbolo = '@SIMBOLO', nombre = '@NOMBRE', esFiat = @ESFIAT WHERE IDMONEDA = @ID";

                sqlQuery = sqlQuery.Replace("@NOMBRE", nombreVar);
                sqlQuery = sqlQuery.Replace("@ID",idVar.ToString());
                sqlQuery = sqlQuery.Replace("@SIMBOLO", simboloVar);

                if (esFiatVar == true)
                {
                    sqlQuery = sqlQuery.Replace("@ESFIAT", "1");
                }
                else
                {
                    sqlQuery = sqlQuery.Replace("@ESFIAT", "0");
                }


                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al actualizar moneda", Ex);
                throw Excepcion;
            }


        }


        public void updatetMonedaPrincipal(string nombreVar)
        {
            try
            {
                this.OpenConnection();
                SqlCommand updateSQL = null;

                string sqlQuery = "UPDATE Dim_Moneda SET ESPRINCIPAL = CASE WHEN NOMBRE = '@NOMBRE' THEN 1 ELSE 0 END";

                sqlQuery = sqlQuery.Replace("@NOMBRE", nombreVar);




                updateSQL = new SqlCommand(sqlQuery, SqlConn);

                updateSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al actualizar moneda principal", Ex);
                throw Excepcion;
            }


        }

    }
       
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFinanzasAJ.Negocio;


namespace AppFinanzasAJ.Data
{
    public class ClaseMovimientoAdapter : Adapter
    {
        public List<ClaseMovimiento> GetClasesMovimiento()
        {
            List<ClaseMovimiento> ListaClasesMovimiento = new List<ClaseMovimiento>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT DESCRIPCION, INGEGR FROM Dim_ClaseMovimiento";

                SqlCommand cmdClasesMovimiento = null;

                cmdClasesMovimiento = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdClasesMovimiento.ExecuteReader();

                while (reader.Read())
                {
                    ClaseMovimiento newClaseMovimiento = new ClaseMovimiento();
                    newClaseMovimiento.DESCRIPCION = (string)reader["DESCRIPCION"];
                    newClaseMovimiento.INGEGR = (string)reader["INGEGR"];
                    ListaClasesMovimiento.Add(newClaseMovimiento);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar los clases de movimiento", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaClasesMovimiento;
        }

        public void insertClaseMovimiento(string nombreVar, string claseVar)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;

                string sqlQuery = "INSERT INTO Dim_ClaseMovimiento (descripcion, ingEgr) VALUES ('@NOMBRE', '@CLASE')";

                sqlQuery = sqlQuery.Replace("@NOMBRE", nombreVar);
                sqlQuery = sqlQuery.Replace("@CLASE", claseVar);

                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al insertar clase de Movimiento", Ex);
                throw Excepcion;
            }
        }

        public void deleteClaseMovimiento(string nombreVar, string claseVar)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;

                string sqlQuery = "DELETE FROM Dim_ClaseMovimiento WHERE descripcion = '@NOMBRE' AND INGEGR = '@CLASE'";


                sqlQuery = sqlQuery.Replace("@NOMBRE", nombreVar);
                sqlQuery = sqlQuery.Replace("@CLASE", claseVar);

                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al eliminar clase de movimiento", Ex);
                throw Excepcion;
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AppFinanzasAJ.Negocio;


namespace AppFinanzasAJ.Data
{
    public class MovTarjetaAdapter : Adapter
    {
        public void insertMovimiento(string fechaMov, string detalle, string tarjeta, string claseMovimiento, string monedaMovimiento,
           string montototal, string cuotas, string fecha1, string fecha2, string repite)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;

                string sqlTarjeta  = "(SELECT DISTINCT idTarjeta FROM Dim_Tarjeta WHERE nombre = '" + tarjeta + "')";
                string sqlMoneda = "(SELECT DISTINCT idMoneda FROM Dim_Moneda WHERE nombre = '" + monedaMovimiento + "')";
                string sqlClase = "(SELECT DISTINCT idClaseMovimiento FROM Dim_ClaseMovimiento WHERE descripcion = '" + claseMovimiento + "')";


                string sqlQuery = "INSERT INTO Fact_Tarjetas (fechaMov, detalle, idTarjeta, idClaseMovimiento, idMoneda, montoTotal, cuotas, mesPrimerCuota, mesUltimaCuota, repite, montoCuota) "
                    + "VALUES ('@FECHAMOV', '@DETALLE', @IDTARJETA, @IDCLASEMOVIMIENTO, @IDMONEDA, @MONTOTOTAL, @CUOTAS, '@FECHA1', '@FECHA2', '@REPITE', @MONTOTOTAL / @CUOTAS)";

                sqlQuery = sqlQuery.Replace("@FECHAMOV", fechaMov);
                sqlQuery = sqlQuery.Replace("@DETALLE", detalle);
                sqlQuery = sqlQuery.Replace("@IDTARJETA", sqlTarjeta);
                sqlQuery = sqlQuery.Replace("@IDCLASEMOVIMIENTO", sqlClase);
                sqlQuery = sqlQuery.Replace("@IDMONEDA", sqlMoneda);
                sqlQuery = sqlQuery.Replace("@MONTOTOTAL", montototal);
                sqlQuery = sqlQuery.Replace("@CUOTAS", cuotas);
                sqlQuery = sqlQuery.Replace("@FECHA1", fecha1);
                sqlQuery = sqlQuery.Replace("@FECHA2", fecha2);
                sqlQuery = sqlQuery.Replace("@REPITE", repite);



                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al insertar movimiento de tarjeta", Ex);
                throw Excepcion;
            }

            
        }

        public List<MovTarjeta> GetMovsTarj(string tarjeta)
        {
            List<MovTarjeta> ListaMovTarj = new List<MovTarjeta>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT detalle,  FROM Fact_Tarjetas T ;";

                SqlCommand cmdTipoActivo = null;

                cmdTipoActivo = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdTipoActivo.ExecuteReader();

                while (reader.Read())
                {
                    TipoActivo newTipoActivo = new TipoActivo();
                    newTipoActivo.NOMBRE = (string)reader["NOMBRE"];
                    //ListaTiposActivo.Add(newTipoActivo);
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

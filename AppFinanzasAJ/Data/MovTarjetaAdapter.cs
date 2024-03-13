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
                string sqlMoneda = "(SELECT DISTINCT idActivo FROM Dim_Activo WHERE nombre = '" + monedaMovimiento + "')";
                string sqlClase = "(SELECT DISTINCT idClaseMovimiento FROM Dim_ClaseMovimiento WHERE descripcion = '" + claseMovimiento + "')";


                string sqlQuery = "INSERT INTO Fact_Tarjetas (fechaMov, detalle, idTarjeta, idClaseMovimiento, idActivo, montoTotal, cuotas, mesPrimerCuota, mesUltimaCuota, repite, montoCuota) "
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


        public void actualizarRecurrente(string fechaMov, string detalle, string montoNuevo, string fechaNueva)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;

                string sqlQuery = "INSERT INTO Fact_Tarjetas (FECHAMOV, DETALLE, IDTARJETA, IDCLASEMOVIMIENTO, "
                    + " IDACTIVO, MONTOTOTAL, CUOTAS, MESPRIMERCUOTA, MESULTIMACUOTA, REPITE, MONTOCUOTA) " +
                    "SELECT '@FECHANUEVA', DETALLE, IDTARJETA, IDCLASEMOVIMIENTO, IDACTIVO, @MONTONUEVO, 1, " +
                    "DATEADD(MONTH, 1, CAST(LEFT(@FECHANUEVA, 7) + '01' AS DATETIME)), '1900-01-01' , REPITE, @MONTONUEVO FROM " +
                    "Fact_Tarjetas WHERE FECHAMOV = '@FECHAMOV' AND DETALLE = '@DETALLE' AND REPITE = 'SI';";

                sqlQuery = sqlQuery.Replace("@FECHAMOV", fechaMov);
                sqlQuery = sqlQuery.Replace("@DETALLE", detalle);
                sqlQuery = sqlQuery.Replace("@MONTONUEVO", montoNuevo.Replace(",", "."));
                sqlQuery = sqlQuery.Replace("@FECHANUEVA", fechaNueva);




                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al actualizar movimiento de tarjeta recurrente", Ex);
                throw Excepcion;
            }
        }

            public void cerrarRecurrente(string fechaMov, string detalle)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;

                string sqlQuery = "UPDATE Fact_Tarjetas SET repite = 'Cerrado' WHERE FECHAMOV = '@FECHAMOV' AND DETALLE = '@DETALLE' AND REPITE = 'SI';";

                sqlQuery = sqlQuery.Replace("@FECHAMOV", fechaMov);
                sqlQuery = sqlQuery.Replace("@DETALLE", detalle);




                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al cerrar movimiento de tarjeta recurrente", Ex);
                throw Excepcion;
            }


        }
        public List<MovTarjeta> getMovsTarjGrid()
        {
            List<MovTarjeta> ListaMovTarj = new List<MovTarjeta>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT fechaMov, T.nombre NOMBRETARJ, CM.descripcion TIPOMOV, FT.detalle, CASE WHEN FT.repite"
                    +"= 'SI' THEN 'Recurrente' ELSE CAST(FT.cuotas AS varchar) END CUOTATEXTO ,A.nombre NOMBREMON, FT.montoTotal,"
                    +"FT.mesPrimerCuota, CASE WHEN repite = 'SI' THEN 'NA' ELSE CAST( FT.mesUltimaCuota AS VARCHAR) "
                    + "END ULTCUOTATEXTO, FT.montoCuota FROM [dbo].[Fact_Tarjetas] FT INNER JOIN Dim_Tarjeta T ON "
                    + "T.idTarjeta = FT.idTarjeta INNER JOIN Dim_ClaseMovimiento CM ON CM.idClaseMovimiento = "
                    +"ft.idClaseMovimiento INNER JOIN Dim_Activo A ON A.idActivo = FT.idActivo WHERE FT.repite = "
                    +"'SI' OR DATEADD(month ,1, FT.mesUltimaCuota) >= GETDATE();";



                SqlCommand cmdMovTarjeta = null;
                cmdMovTarjeta = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdMovTarjeta.ExecuteReader();

                while (reader.Read())
                {
                    MovTarjeta newMovTarjeta = new MovTarjeta();
                    newMovTarjeta.FECHAMOV = (DateTime)reader["FECHAMOV"];
                    newMovTarjeta.NOMBRETARJ = (string)reader["NOMBRETARJ"];
                    newMovTarjeta.TIPOMOV = (string)reader["TIPOMOV"];
                    newMovTarjeta.DETALLE = (string)reader["DETALLE"];
                    newMovTarjeta.CUOTATEXTO = (string)reader["CUOTATEXTO"];
                    newMovTarjeta.NOMBREMON = (string)reader["NOMBREMON"];
                    newMovTarjeta.MONTOTOTAL = (decimal)reader["MONTOTOTAL"];
                    newMovTarjeta.MESPRIMERCUOTA = (DateTime)reader["MESPRIMERCUOTA"];
                    newMovTarjeta.ULTCUOTATEXTO = (string)reader["ULTCUOTATEXTO"];
                    newMovTarjeta.MONTOCUOTA = (decimal)reader["MONTOCUOTA"];

                    

                    ListaMovTarj.Add(newMovTarjeta);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar los movimientos de tarjeta", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaMovTarj;
        }
        public List<MovTarjeta> GetMovsTarj(string fecha, string tarjeta)
        {
            List<MovTarjeta> ListaMovTarj = new List<MovTarjeta>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT T.fechaMov,CM.descripcion ,T.detalle, A.nombre,CASE WHEN "
                    + "T.repite = 'SI' THEN 'Recurrente' ELSE CAST(DATEDIFF(MONTH, T.MESPRIMERCUOTA, '@FECHA')+ 1 AS"
                    + " VARCHAR) + '/' + cast(T.cuotas as varchar) END Cuota,T.montoCuota, CASE WHEN A.NOMBRE = "
                    + "'Peso Argentino' THEN T.montoCuota ELSE (T.montoCuota * CA.VALOR)  END valPesos FROM "
                    + "[dbo].[Fact_Tarjetas] T INNER JOIN [dbo].[Dim_Activo] A ON T.idActivo = A.idActivo INNER "
                    + "JOIN [dbo].[Cotizacion_Activo] CA ON CA.idActivoComp = (SELECT idActivo FROM Dim_Activo "
                    + "WHERE simbolo = 'ARS') AND CA. TIPO = 'TARJETA' AND CA.fechaHora = (SELECT MAX(fechaHora) "
                    + "FROM Cotizacion_Activo) INNER JOIN Dim_ClaseMovimiento CM ON CM.idClaseMovimiento = T.idClaseMovimiento INNER JOIN [dbo].[Dim_Tarjeta] TA ON T.idTarjeta = TA.idTarjeta "
                    + " LEFT JOIN Pago_Tarjeta PT ON PT.idTarjeta = T.idTarjeta AND PT.fechaMes = '@FECHA' WHERE  "
                    + "(T.mesUltimaCuota >= '@FECHA' OR T.repite = 'SI') AND T.mesPrimerCuota <= '@FECHA' AND "
                    +" TA.nombre = '@TARJETA' AND PT.idTarjeta IS NULL;";

                consulta_select = consulta_select.Replace("@TARJETA", tarjeta);
                consulta_select = consulta_select.Replace("@FECHA", fecha);

                SqlCommand cmdMovTarjeta = null;
                cmdMovTarjeta = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdMovTarjeta.ExecuteReader();

                while (reader.Read())
                {
                    MovTarjeta newMovTarjeta = new MovTarjeta();
                    newMovTarjeta.FECHAMOV = (DateTime)reader["FECHAMOV"];
                    newMovTarjeta.DETALLE = (string)reader["DETALLE"];
                    newMovTarjeta.NOMBREMON = (string)reader["NOMBRE"];
                    newMovTarjeta.CUOTATEXTO = (string)reader["CUOTA"];
                    newMovTarjeta.MONTOCUOTA = (decimal)reader["MONTOCUOTA"];
                    newMovTarjeta.VALORPESOS = (decimal)reader["VALPESOS"];
                    newMovTarjeta.TIPOMOV = (string)reader["DESCRIPCION"];

                    ListaMovTarj.Add(newMovTarjeta);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar los movimientos de tarjeta", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaMovTarj;


        }

    }

}

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
                string sqlFechaMov = "(SELECT DISTINCT IDFECHA FROM Dim_Tiempo WHERE FECHA  = '" + fechaMov + "')";
                string sqlFecha1 = "(SELECT DISTINCT IDFECHA FROM Dim_Tiempo WHERE FECHA  = '" + fecha1 + "')";
                string sqlFecha2 = "(SELECT DISTINCT IDFECHA FROM Dim_Tiempo WHERE FECHA  = '" + fecha2 + "')";

                string sqlQuery = "INSERT INTO Fact_Tarjetas (fechaMov, detalle, idTarjeta, idClaseMovimiento, idActivo, montoTotal, cuotas, mesPrimerCuota, mesUltimaCuota, repite, montoCuota) "
                    + "VALUES (@FECHAMOV, '@DETALLE', @IDTARJETA, @IDCLASEMOVIMIENTO, @IDMONEDA, @MONTOTOTAL, @CUOTAS, '@FECHA1', '@FECHA2', '@REPITE', @MONTOTOTAL / @CUOTAS)";

                sqlQuery = sqlQuery.Replace("@FECHAMOV", sqlFechaMov);
                sqlQuery = sqlQuery.Replace("@DETALLE", detalle);
                sqlQuery = sqlQuery.Replace("@IDTARJETA", sqlTarjeta);
                sqlQuery = sqlQuery.Replace("@IDCLASEMOVIMIENTO", sqlClase);
                sqlQuery = sqlQuery.Replace("@IDMONEDA", sqlMoneda);
                sqlQuery = sqlQuery.Replace("@MONTOTOTAL", montototal);
                sqlQuery = sqlQuery.Replace("@CUOTAS", cuotas);
                sqlQuery = sqlQuery.Replace("@FECHA1", sqlFecha1);
                sqlQuery = sqlQuery.Replace("@FECHA2", sqlFecha2);
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

                string sqlFechaMov = "(SELECT DISTINCT IDFECHA FROM Dim_Tiempo WHERE FECHA  = '" + fechaMov + "')";

                string sqlQuery = "INSERT INTO Fact_Tarjetas (FECHAMOV, DETALLE, IDTARJETA, IDCLASEMOVIMIENTO, "
                    + " IDACTIVO, MONTOTOTAL, CUOTAS, MESPRIMERCUOTA, MESULTIMACUOTA, REPITE, MONTOCUOTA) " +
                    "SELECT CAST(FORMAT(@FECHANUEVA, 'yyyyMMdd') as int), DETALLE, IDTARJETA, IDCLASEMOVIMIENTO, IDACTIVO, @MONTONUEVO, 1, " +
                    "CAST(FORMAT(DATEADD(MONTH, 1, CAST(LEFT(@FECHANUEVA, 7) + '01' AS DATETIME)), 'yyyyMMdd') AS INT), 0 , REPITE, @MONTONUEVO FROM " +
                    "Fact_Tarjetas WHERE FECHAMOV = @FECHAMOV AND DETALLE = '@DETALLE' AND REPITE = 'SI';";

                sqlQuery = sqlQuery.Replace("@FECHAMOV", sqlFechaMov);
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

                string sqlQuery = "UPDATE Fact_Tarjetas SET repite = 'Cerrado' WHERE FECHAMOV = CAST(FORMAT(@FECHAMOV, 'yyyyMMdd') AS INT) AND DETALLE = '@DETALLE' AND REPITE = 'SI';";

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
                string consulta_select = "SELECT T1.FECHA FECHAMOV, T.nombre NOMBRETARJ, CM.descripcion TIPOMOV, FT.detalle, CASE WHEN FT.repite"
                    +"= 'SI' THEN 'Recurrente' ELSE CAST(FT.cuotas AS varchar) END CUOTATEXTO ,A.nombre NOMBREMON, FT.montoTotal,"
                    +"T2.FECHA MESPRIMERCUOTA, CASE WHEN repite = 'SI' THEN 'NA' ELSE CAST( T3.FECHA AS VARCHAR) "
                    + "END ULTCUOTATEXTO, FT.montoCuota FROM [dbo].[Fact_Tarjetas] FT INNER JOIN Dim_Tarjeta T ON "
                    + "T.idTarjeta = FT.idTarjeta INNER JOIN Dim_ClaseMovimiento CM ON CM.idClaseMovimiento = "
                    +"ft.idClaseMovimiento INNER JOIN Dim_Activo A ON A.idActivo = FT.idActivo INNER JOIN Dim_Tiempo T1 ON " +
                    "T1.IDFECHA = FT.FECHAMOV INNER JOIN Dim_Tiempo T2 ON T2.IDFECHA = FT.MESPRIMERCUOTA INNER JOIN " +
                    "Dim_Tiempo T3 ON T3.IDFECHA = FT.MESULTIMACUOTA WHERE FT.repite = "
                    + "'SI' OR DATEADD(month ,1, T3.FECHA) >= GETDATE();";



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
                string consulta_select = "SELECT T1.FECHA FECHAMOV,CM.descripcion ,T.detalle, A.nombre,CASE WHEN "
                    + "T.repite = 'SI' THEN 'Recurrente' ELSE CAST(DATEDIFF(MONTH, T2.FECHA, '@FECHA') + 1 AS"
                    + " VARCHAR) + '/' + cast(T.cuotas as varchar) END Cuota,T.montoCuota, CASE WHEN A.NOMBRE = "
                    + "'Peso Argentino' THEN T.montoCuota ELSE (T.montoCuota * CA.VALOR)  END valPesos FROM "
                    + "[dbo].[Fact_Tarjetas] T INNER JOIN [dbo].[Dim_Activo] A ON T.idActivo = A.idActivo INNER "
                    + "JOIN [dbo].[Cotizacion_Activo] CA ON CA.idActivoComp = (SELECT idActivo FROM Dim_Activo "
                    + "WHERE simbolo = 'ARS') AND CA. TIPO = 'TARJETA' AND CA.IDFECHA = (SELECT MAX(IDFECHA) "
                    + "FROM Cotizacion_Activo) INNER JOIN Dim_ClaseMovimiento CM ON CM.idClaseMovimiento = T.idClaseMovimiento INNER JOIN [dbo].[Dim_Tarjeta] TA ON T.idTarjeta = TA.idTarjeta "
                    + " LEFT JOIN Pago_Tarjeta PT ON PT.idTarjeta = T.idTarjeta AND FORMAT(PT.fechaMes, 'yyyy-MM-dd') = '@FECHA' INNER JOIN Dim_Tiempo T1 ON " +
                    "  T1.IDFECHA = T.FECHAMOV INNER JOIN Dim_Tiempo T2 ON T2.IDFECHA = T.MESPRIMERCUOTA INNER JOIN " +
                    "   Dim_Tiempo T3 ON T3.IDFECHA = T.MESULTIMACUOTA WHERE  "
                    + "(T3.FECHA >= '@FECHA' OR T.repite = 'SI') AND T2.FECHA <= '@FECHA' AND "
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

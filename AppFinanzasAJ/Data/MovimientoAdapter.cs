using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppFinanzasAJ.Negocio;


namespace AppFinanzasAJ.Data
{
    public class MovimientoAdapter : Adapter
    {
        public List<Movimiento> getTopMovimientos()
        {
            List<Movimiento> listaMovimientos = new List<Movimiento>();

            try
            {
                OpenConnection();
                string consulta_select = "SELECT  TOP 20 F.fecha, MO.tipoMovimiento TIPO,CM.descripcion CLASEMOV "
                    + ", MO.comentario , "
                    + "C.nombre CUENTA, A.nombre MONEDA, CAST(MO.monto AS decimal (18,2)) MONTO, MO.IDMOVIMIENTO FROM [dbo].[Fact_Movimiento] "
                    + "MO "
                    + "INNER JOIN [dbo].[Dim_ClaseMovimiento] CM ON CM.idClaseMovimiento = MO.idClaseMovimiento "
                    + "INNER JOIN Dim_Activo A ON A.idActivo = MO.idActivo INNER JOIN Dim_Cuenta C ON C.idCuenta = "
                    + "MO.idCuenta INNER JOIN Dim_Tiempo F ON MO.IDFECHA = F.IDFECHA ORDER BY MO.IDfecha DESC , idMovimiento DESC";

                SqlCommand cmdMovimientos = null;

                cmdMovimientos = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdMovimientos.ExecuteReader();

                while (reader.Read())
                {
                    Movimiento newMovimiento = new Movimiento();
                    newMovimiento.FECHA = (DateTime)reader["FECHA"];
                    newMovimiento.TIPOMOVIMIENTO = (string)reader["TIPO"];
                    newMovimiento.CLASEMOVTEXT = (string)reader["CLASEMOV"];
                    newMovimiento.COMENTARIO = (string)reader["COMENTARIO"];
                    newMovimiento.CUENTATEXT = (string)reader["CUENTA"];
                    newMovimiento.MONEDATEXT = (string)reader["MONEDA"];
                    newMovimiento.MONTO = (decimal)reader["MONTO"];
                    newMovimiento.IDMOVIMIENTO = (int)reader["IDMOVIMIENTO"];
                    listaMovimientos.Add(newMovimiento);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar los movimientos", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return listaMovimientos;
        }

        public List<Movimiento> GetNextID()
        {
            List<Movimiento> ListaMovimiento = new List<Movimiento>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT COALESCE(MAX(idMovimiento), 0) + 1 numMov FROM Fact_Movimiento;";

                SqlCommand cmdMovimientos = null;

                cmdMovimientos = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdMovimientos.ExecuteReader();

                while (reader.Read())
                {
                    Movimiento newMovimiento = new Movimiento();
                    newMovimiento.IDMOVIMIENTO = (int)reader["numMov"];
                    ListaMovimiento.Add(newMovimiento);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar los movimientos", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaMovimiento;
        }

        public void registrarReintegro(string idMov, string reintegro)
        {
            try 
            {
                this.OpenConnection();
                SqlCommand updateSQL = null;

                string sqlQuery = "UPDATE Fact_Movimiento SET MONTO = MONTO + @REINT WHERE IDMOVIMIENTO = @IDMOV";

                sqlQuery = sqlQuery.Replace("@REINT", reintegro);
                sqlQuery = sqlQuery.Replace("@IDMOV", idMov);

                updateSQL = new SqlCommand(sqlQuery, SqlConn);
                updateSQL.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al registrar reintegro", Ex);
                throw Excepcion;

            }
        }

        public void insertMovimiento(string idMovimiento ,string tipoMovimiento, string fechaMovimiento, string monedaMovimiento, string ctaMovimiento, string claseMovimiento,
            string detalleMovimiento, string montoMovimiento, string precioCotiz)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;


                string sqlCuenta = "(SELECT DISTINCT idCuenta FROM Dim_Cuenta WHERE nombre = '" + ctaMovimiento + "')";
                string sqlMoneda = "(SELECT DISTINCT idActivo FROM Dim_Activo WHERE nombre = '" + monedaMovimiento + "')";
                string sqlClase = "(SELECT DISTINCT idClaseMovimiento FROM Dim_ClaseMovimiento WHERE descripcion = '" + claseMovimiento + "')";
                string sqlFecha = "(SELECT DISTINCT IDFECHA FROM Dim_Tiempo WHERE FECHA  = '" + fechaMovimiento + "')";

                
                string sqlPrecioCotiz;
                if (precioCotiz != "")
                {
                    if (monedaMovimiento == "Peso Argentino")
                    {
                        sqlPrecioCotiz = precioCotiz;
                    }
                    else
                    {
                        sqlPrecioCotiz = Convert.ToString(1 / Convert.ToDecimal(precioCotiz));
                    }
                    
                }
                else
                {
                    sqlPrecioCotiz = "(SELECT TOP 1 VALOR FROM [dbo].[Cotizacion_Activo] CA WHERE IDACTIVOCOMP = " +
                        "" + sqlMoneda + " AND IDFECHA <= " + fechaMovimiento.Replace("-", "") + " ORDER BY " +
                        "idFecha DESC)";
                }


                string sqlQuery = "INSERT INTO Fact_Movimiento (idMovimiento, idCuenta, idActivo, IDFECHA, tipoMovimiento," +
                    " idClaseMovimiento, comentario, monto, precioCotiz) "
                    + "VALUES ('@IDMOVIMIENTO', @IDCUENTA, @IDMONEDA, @FECHA, '@IDTIPOMOVIMIENTO', @IDCLASEMOVIMIENTO, " +
                    "'@COMENTARIO', @MONTO, @PRECIOCOTIZ)";

                sqlQuery = sqlQuery.Replace("@IDMOVIMIENTO", idMovimiento);
                sqlQuery = sqlQuery.Replace("@IDCUENTA", sqlCuenta);
                sqlQuery = sqlQuery.Replace("@IDMONEDA", sqlMoneda);
                sqlQuery = sqlQuery.Replace("@FECHA", sqlFecha);
                sqlQuery = sqlQuery.Replace("@IDTIPOMOVIMIENTO", tipoMovimiento);
                sqlQuery = sqlQuery.Replace("@IDCLASEMOVIMIENTO", sqlClase);
                sqlQuery = sqlQuery.Replace("@COMENTARIO", detalleMovimiento);                
                sqlQuery = sqlQuery.Replace("@MONTO", montoMovimiento.Replace(",", "."));
                sqlQuery = sqlQuery.Replace("@PRECIOCOTIZ", sqlPrecioCotiz.Replace(",", "."));



                insertSQL = new SqlCommand(sqlQuery, SqlConn);
                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al insertar movimiento", Ex);
                throw Excepcion;
            }


        }

        public string getTotalEnPesos()
        {
            string total;
            try
            {
                
                this.OpenConnection();
                SqlCommand cmdMovimientos = null;

                string sqlQuery = "SELECT CAST( SUM( CASE WHEN A.esReferencia = 1 THEN MONTO ELSE CASE WHEN " +
                    "CA.valor IS NOT NULL THEN MONTO / CA.VALOR ELSE 0 END END) AS DECIMAL (18,2)) * " +
                    "(SELECT VALOR FROM [dbo].[Cotizacion_Activo] WHERE TIPO = 'BLUE' AND IDFECHA = (SELECT " +
                    "MAX(IDFECHA) FROM [dbo].[Cotizacion_Activo])) TOT FROM [dbo].[Fact_Movimiento] M INNER JOIN " +
                    "Dim_Activo A ON M.idActivo = A.idActivo LEFT JOIN [dbo].[Cotizacion_Activo] CA ON " +
                    "CA.idActivoComp = A.idActivo AND CA.idFecha = (SELECT MAX(IDFECHA) FROM " +
                    "[dbo].[Cotizacion_Activo]) AND CA.tipo <> 'TARJETA' AND CA.tipo <> 'BOLSA'";

                cmdMovimientos = new SqlCommand(sqlQuery, SqlConn);

                SqlDataReader reader = cmdMovimientos.ExecuteReader();
                decimal tot = 0;

                while (reader.Read())
                {
                    tot = (decimal)reader["tot"];
                   
                }
                
                total = tot.ToString("N", new CultureInfo("es-AR"));

                reader.Close();

                



            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al recuperar saldo en Pesos", Ex);
                throw Excepcion;
            }
            
            return total;
        }


        public string getTotalEnDolares()
        {
            string total;
            try
            {

                this.OpenConnection();
                SqlCommand cmdMovimientos = null;

                string sqlQuery = "SELECT CAST( SUM( CASE WHEN A.esReferencia = 1 THEN MONTO ELSE CASE WHEN " +
                    "CA.valor IS NOT NULL THEN MONTO / CA.VALOR ELSE 0 END END) AS DECIMAL (18,2)) tot FROM " +
                    "[dbo].[Fact_Movimiento] M INNER JOIN Dim_Activo A ON M.idActivo = A.idActivo LEFT JOIN " +
                    "[dbo].[Cotizacion_Activo] CA ON CA.idActivoComp = A.idActivo AND CA.idFecha = (SELECT " +
                    "MAX(IDFECHA) FROM [dbo].[Cotizacion_Activo]) AND CA.tipo <> 'TARJETA' AND CA.tipo <> " +
                    "'BOLSA'";

                cmdMovimientos = new SqlCommand(sqlQuery, SqlConn);

                SqlDataReader reader = cmdMovimientos.ExecuteReader();
                decimal tot = 0;

                while (reader.Read())
                {
                    tot = (decimal)reader["tot"];

                }

                total = tot.ToString("N", new CultureInfo("es-AR"));

                reader.Close();





            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al recuperar saldo en Pesos", Ex);
                throw Excepcion;
            }

            return total;
        }

        public decimal getTotalDevBSF(string dateFrom, string dateTo)
        {
            try
            {
                decimal total;
                this.OpenConnection();
                SqlCommand cmdMovimientos = null;


                string sqlQuery = "SELECT COALESCE(SUM(monto), 0) totalDev FROM [dbo].[Fact_Movimiento]" +
                    "WHERE tipoMovimiento = 'devBSF' AND MONTH(fecha) = MONTH(DATEADD(HOUR, -3,GETDATE())) AND YEAR(FECHA) = " +
                    "YEAR(DATEADD(HOUR, -3,GETDATE()))";

                cmdMovimientos = new SqlCommand(sqlQuery, SqlConn);

                SqlDataReader reader = cmdMovimientos.ExecuteReader();

               
                total = (int)reader["totalDev"];                
           
                reader.Close();

                return total;

                
                
            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al recuperar saldo restante BSF", Ex);
                throw Excepcion;
            }
        }

        public List<Movimiento> getTotalesPorCuentaMon(string activoV)
        {
            List<Movimiento> ListaMovimiento = new List<Movimiento>();
            try
            {
                OpenConnection();
                string consulta_select = "SELECT C.nombre, SUM(MONTO) MONTO FROM [dbo].[Fact_Movimiento] FM " +
                    "INNER JOIN [dbo].[Dim_Cuenta] C ON C.idCuenta = FM.idCuenta INNER JOIN " +
                    "[dbo].[Dim_Activo] A ON A.idActivo = FM.idActivo WHERE A.nombre = '@ACTIVO' " +
                    "GROUP BY C.nombre;";

                consulta_select = consulta_select.Replace("@ACTIVO", activoV);

                SqlCommand cmdMovimientos = null;

                cmdMovimientos = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdMovimientos.ExecuteReader();

                while (reader.Read())
                {
                    Movimiento newMovimiento = new Movimiento();
                    newMovimiento.CUENTATEXT = (string)reader["NOMBRE"];
                    newMovimiento.MONTO = (decimal)reader["MONTO"];
                    ListaMovimiento.Add(newMovimiento);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar los totales por cuenta", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaMovimiento;
        }

        public List<Movimiento> getTotalesPorCuenta(string activoV, string tipoV)
        {
            List<Movimiento> ListaMovimiento = new List<Movimiento>();
            try
            {
                OpenConnection();

                string consulta_select;
                if (tipoV == "Criptomoneda")
                {
                    consulta_select = "SELECT C.nombre, SUM(FM.MONTO) MONTO FROM [dbo].[Fact_Movimiento] FM INNER JOIN " +
                        "[dbo].[Dim_Activo] A ON A.idActivo = FM.idActivo INNER JOIN [dbo].[Dim_Cuenta] C ON C.idCuenta = " +
                        "FM.idCuenta WHERE A.nombre = '@ACTIVO' GROUP BY C.nombre";
                }
                else
                {
                    consulta_select = "SELECT C.nombre, CAST(SUM(FM.MONTO) AS DECIMAL (18,2) ) MONTO FROM " +
                        "[dbo].[Fact_Movimiento] FM INNER JOIN [dbo].[Dim_Activo] A ON A.idActivo = FM.idActivo INNER " +
                        "JOIN [dbo].[Dim_Cuenta] C ON C.idCuenta = FM.idCuenta WHERE A.nombre = '@ACTIVO' " +
                        "GROUP BY C.nombre";
                }
                 

                consulta_select = consulta_select.Replace("@ACTIVO", activoV);

                SqlCommand cmdMovimientos = null;

                cmdMovimientos = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdMovimientos.ExecuteReader();

                while (reader.Read())
                {
                    Movimiento newMovimiento = new Movimiento();
                    newMovimiento.CUENTATEXT = (string)reader["NOMBRE"];
                    newMovimiento.MONTO = (decimal)reader["MONTO"];
                    ListaMovimiento.Add(newMovimiento);
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar los totales por cuenta", Ex);
                throw Excepcion;
            }
            finally
            {
                this.CloseConnection();
            }
            return ListaMovimiento;
        }
    }
       
}

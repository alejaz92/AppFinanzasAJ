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
    public class MovimientoAdapter : Adapter
    {
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

        //public int getTotalDevBSF()
        //{

        //}

        public void insertMovimiento(string idMovimiento ,string tipoMovimiento, string fechaMovimiento, string monedaMovimiento, string ctaMovimiento, string claseMovimiento,
            string detalleMovimiento, string montoMovimiento)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;


                string sqlCuenta = "(SELECT DISTINCT idCuenta FROM Dim_Cuenta WHERE nombre = '" + ctaMovimiento + "')";
                string sqlMoneda = "(SELECT DISTINCT idMoneda FROM Dim_Moneda WHERE nombre = '" + monedaMovimiento + "')";
                string sqlClase = "(SELECT DISTINCT idClaseMovimiento FROM Dim_ClaseMovimiento WHERE descripcion = '" + claseMovimiento + "')";


                string sqlQuery = "INSERT INTO Fact_Movimiento (idMovimiento, idCuenta, idMoneda, fecha, tipoMovimiento, idClaseMovimiento, comentario, monto) "
                    + "VALUES ('@IDMOVIMIENTO', @IDCUENTA, @IDMONEDA, '@FECHA', '@IDTIPOMOVIMIENTO', @IDCLASEMOVIMIENTO, '@COMENTARIO', @MONTO)";

                sqlQuery = sqlQuery.Replace("@IDMOVIMIENTO", idMovimiento);
                sqlQuery = sqlQuery.Replace("@IDCUENTA", sqlCuenta);
                sqlQuery = sqlQuery.Replace("@IDMONEDA", sqlMoneda);
                sqlQuery = sqlQuery.Replace("@FECHA", fechaMovimiento);
                sqlQuery = sqlQuery.Replace("@IDTIPOMOVIMIENTO", tipoMovimiento);
                sqlQuery = sqlQuery.Replace("@IDCLASEMOVIMIENTO", sqlClase);
                sqlQuery = sqlQuery.Replace("@COMENTARIO", detalleMovimiento);
                sqlQuery = sqlQuery.Replace("@MONTO", montoMovimiento.Replace(",", "."));



                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al insertar movimiento", Ex);
                throw Excepcion;
            }


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
    }
       
}

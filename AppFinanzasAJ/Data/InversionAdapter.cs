using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFinanzasAJ.Negocio;


namespace AppFinanzasAJ.Data
{
    public class InversionAdapter : Adapter
    {
        public void insertInversion(string fechaMovimiento, string tipoMovimiento,  string activoMovimiento, 
            string ctaMovimiento, string cantidadMovimiento,
             string precioMovimiento)
        {
            try
            {
                this.OpenConnection();
                SqlCommand insertSQL = null;


                string sqlCuenta = "(SELECT DISTINCT idCuenta FROM Dim_Cuenta WHERE nombre = '" + ctaMovimiento + "')";
                string sqlActivo = "(SELECT DISTINCT idActivo FROM Dim_Activo WHERE nombre = '" + activoMovimiento + "')";

                string sqlQuery = "INSERT INTO Fact_Inversion (idFecha, tipoMov, idActivo, idCuenta, cantidad, precio) "
                    + "VALUES (@FECHA,'@IDTIPOMOVIMIENTO',@IDACTIVO, @IDCUENTA, @CANTIDAD, @PRECIO)";


                sqlQuery = sqlQuery.Replace("@IDCUENTA", sqlCuenta);
                sqlQuery = sqlQuery.Replace("@IDACTIVO", sqlActivo);
                sqlQuery = sqlQuery.Replace("@FECHA", fechaMovimiento);
                sqlQuery = sqlQuery.Replace("@IDTIPOMOVIMIENTO", tipoMovimiento);
                sqlQuery = sqlQuery.Replace("@CANTIDAD", cantidadMovimiento.Replace(",", "."));
                sqlQuery = sqlQuery.Replace("@PRECIO", precioMovimiento.Replace(",", "."));



                insertSQL = new SqlCommand(sqlQuery, SqlConn);

                insertSQL.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception Excepcion = new Exception("Error al insertar movimiento de Inversiones", Ex);
                throw Excepcion;
            }


        }

    }
       
}

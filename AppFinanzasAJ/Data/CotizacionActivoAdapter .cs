using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AppFinanzasAJ.Negocio;
using Newtonsoft.Json.Linq;


namespace AppFinanzasAJ.Data
{
    public class CotizacionActivoAdapter : Adapter
    {
        public Boolean checkDatosDia()
        {
            Boolean checkDatosDia;

            checkDatosDia = false;
            try
            {
                OpenConnection();
                string consulta_select = "SELECT COUNT(*) CONTADOR FROM Cotizacion_Activo WHERE IDFECHA = CAST(FORMAT(DATEADD(HOUR, -3,GETDATE()), 'yyyyMMdd') AS INTEGER);";

                SqlCommand cmdContador = null;

                cmdContador= new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdContador.ExecuteReader();

                while (reader.Read())
                {
                    int contador;
                    contador = (int)reader["CONTADOR"];
                    
                    if (contador > 0) 
                    {
                        checkDatosDia = true; 
                    }
                    else 
                    {
                        checkDatosDia = false;
                    }
                }

                reader.Close();



            }

            catch (Exception Ex)
            {
                checkDatosDia = false;
                ; Exception Excepcion = new Exception("Error al recuperar las cotizaciones", Ex);
                throw Excepcion;
                ;
            }
            finally
            {                
                this.CloseConnection();
            }
            return checkDatosDia;
        }
        
        public string checkCotizacion(string par)
        {
            string cotiz;
            string url;
            if (par == "USDARSB")
            {
                url = $"https://dolarapi.com/v1/dolares/blue";       
            }
            else if (par == "USDARST")
            {
                url = $"https://dolarapi.com/v1/dolares/tarjeta";
            }
            else
            {
                string apiKey = "FDYDOY4B5LA56344";
                string currencyPair = par;

                url = $"https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency={currencyPair.Substring(0,3)}&to_currency={currencyPair.Substring(3)}&apikey={apiKey}";

                

               
            }

            try
            {
                using (WebClient wc = new WebClient())
                {

                    string json = wc.DownloadString(url);
                    JObject data = JObject.Parse(json);

                    if (data["Error Message"] != null)
                    {
                        //Console.WriteLine(data["Error Message"]);
                        cotiz = null;
                    }
                    else
                    {
                        if (par == "USDARST" | par == "USDARSB")
                        {

                            decimal cot1 = (Convert.ToDecimal(data["venta"]));
                            decimal cot2 = (Convert.ToDecimal(data["compra"]));
                            cotiz = Convert.ToString((cot1 + cot2) / 2);
                        }
                        else 
                        {
                            string check = Convert.ToString(data["Information"]);

                            if (!check.Contains("limit is 25"))
                            {

                               decimal  cotizDec = Convert.ToDecimal(data["Realtime Currency Exchange Rate"]["5. Exchange Rate"]);
                                cotiz = Convert.ToString(1 / cotizDec);
                            }
                            else
                            {
                                cotiz = null;
                            }
                        }
                        
                        
                    }

                }

            }

            catch (WebException ex)

            {
                // Si hay un error de red, muestra el mensaje de error
                Console.WriteLine("Error de red: " + ex.Message);
                cotiz = null;

            }

            catch (Exception ex)
            {
                // Si hay otro tipo de error, muestra el mensaje de error
                Console.WriteLine("Error: " + ex.Message);
                cotiz = null;
            }

            return cotiz;

        }

        public void insertCotizaciones(string idMon1, string idMon2, string par)
        {
            try
            {

                string valorCotiz = checkCotizacion(par);
                string tipo;

                if (valorCotiz != null)
                {
                    this.OpenConnection();
                    SqlCommand insertSQL = null;
                    
                    if (par == "USDARST")
                    {
                        tipo = "TARJETA";
                    }
                    else if (par == "USDARSB")
                    {
                        tipo = "BLUE";
                    }
                    else
                    {
                        tipo = "NA";
                    }

                    string sqlQuery = "INSERT INTO Cotizacion_Activo (idActivoBase, idActivoComp, idFecha, tipo, valor) VALUES ('@ID1', '@ID2', CAST(FORMAT(DATEADD(HOUR, -3,GETDATE()), 'yyyyMMdd') AS INTEGER), '@TIPO', @VALOR)";

                    sqlQuery = sqlQuery.Replace("@ID1", idMon1);
                    sqlQuery = sqlQuery.Replace("@ID2", idMon2);
                    sqlQuery = sqlQuery.Replace("@TIPO", tipo);
                    sqlQuery = sqlQuery.Replace("@VALOR", valorCotiz.Replace(",","."));

         

                    insertSQL = new SqlCommand(sqlQuery, SqlConn);

                    insertSQL.ExecuteNonQuery();
                }



            }

            catch (Exception Ex)
            {

                ; Exception Excepcion = new Exception("Error al recuperar las cotizaciones", Ex);
                throw Excepcion;
                ;
            }
            finally
            {

            }
        }

        public decimal getCotizDolarTarjeta()
        {
            decimal cotizDolar = 0;
            try
            {
                
                OpenConnection();
                string consulta_select = "SELECT VALOR FROM Cotizacion_Activo CA INNER JOIN Dim_Activo A1 "
                    + " ON CA.IDACTIVOBASE = A1.IDACTIVO INNER JOIN Dim_Activo A2 ON CA.IDACTIVOCOMP = "
                    + "A2.IDACTIVO WHERE A1.SIMBOLO = 'USD' AND A2.SIMBOLO = 'ARS' AND CA.TIPO = 'TARJETA' "
                    + " AND IDFECHA = (SELECT MAX(IDFECHA) FROM Cotizacion_Activo)";

                SqlCommand cmdCotizacion = null;

                cmdCotizacion = new SqlCommand(consulta_select, SqlConn);

                SqlDataReader reader = cmdCotizacion.ExecuteReader();

                while (reader.Read())
                {
                    cotizDolar = (decimal)reader["VALOR"];
                }

                reader.Close();
                


            }

            catch (Exception Ex)
            {
                ; Exception Excepcion = new Exception("Error al recuperar las cotizaciones", Ex);
                throw Excepcion;
                ;
            }
            finally
            {
                
                this.CloseConnection();
            }
            return cotizDolar;
        }
       
    }
       
}

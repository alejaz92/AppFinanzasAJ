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
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;
using ScrapySharp.Extensions;


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
        
        public string checkCotizacionScrap(string simbolo, string tipo)
        {
            string cotiz = "0";

            if (tipo == "FCI")
            {
                HtmlWeb oWeb = new HtmlWeb();
                HtmlDocument doc = oWeb.Load("https://bullmarketbrokers.com/Information/FundData?ticker=" + simbolo);

                //HtmlNode Body = doc.DocumentNode.CssSelect("body").First();
                //string sBody = Body.InnerHtml;

                //Console.WriteLine("https://bullmarketbrokers.com/Information/FundData?ticker=" + simbolo);
       

                var nodo1 = doc.DocumentNode.CssSelect(".table-hover").Last();

                var nodo2 = nodo1.CssSelect("tr").First();

                var nodo3 = nodo2.CssSelect("td").Last();


                cotiz = nodo3.InnerHtml;

                cotiz = cotiz.Replace(",", ".");

                                
            }
            else if (tipo == "Bonos")
            {
                HtmlWeb oWeb = new HtmlWeb();
                HtmlDocument doc = oWeb.Load("https://www.allaria.com.ar/Bono/Especie/" + simbolo);

                HtmlNode Body = doc.DocumentNode.CssSelect("body").First();
                //string sBody = Body.InnerHtml;

                var nodo1 = doc.DocumentNode.CssSelect(".float-left").First();
                cotiz = nodo1.InnerHtml;
                char delimiter = ',';
                string[] substrings  = cotiz.Split(delimiter);
                cotiz = substrings[0].Replace("$", "").Replace(".", "");
            }
            else if (tipo == "CEDEAR" || tipo == "Accion Argentina")
            {
                HtmlWeb oWeb = new HtmlWeb();
                HtmlDocument doc = oWeb.Load("https://www.cohen.com.ar/Bursatil/Especie/" + simbolo);

                //HtmlNode Body = doc.DocumentNode.CssSelect("body").First();
                //string sBody = Body.InnerHtml;

                var nodo1 = doc.DocumentNode.CssSelect(".tdCotizEspecie").First();
                cotiz = nodo1.InnerHtml;
                cotiz = cotiz.Replace(".", "").Replace("$", "").Replace(" ", "");
                cotiz = cotiz.Replace(",", ".");
            }

            //decimal transformacion = 1 / Convert.ToDecimal(cotiz);
            //cotiz = transformacion.ToString();
            //cotiz = cotiz.Replace(",", ".");

            return cotiz;
        }
        public string checkCotizacion(string par, int contCotiz)
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
            else if (par == "USDARSBO")
            {
                url = $"https://dolarapi.com/v1/dolares/bolsa";
            }
            else
            {
                string apiKey;
                if (contCotiz <= 25)
                {
                    apiKey = "VMFI7FT36ZW14QLB";
                }
                else if (contCotiz <= 50)
                {
                    apiKey = "FDYDOY4B5LA56344";
                }
                else
                {
                    apiKey = "CUKHS041RB7MRZSV";
                }

                
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
                        if (par == "USDARSB" | par == "USDARSBO")
                        {

                            decimal cot1 = (Convert.ToDecimal(data["venta"]));
                            decimal cot2 = (Convert.ToDecimal(data["compra"]));
                            cotiz = Convert.ToString((cot1 + cot2) / 2);
                        }
                        else if (par == "USDARST")
                        {
                            cotiz = Convert.ToString(data["venta"]);
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

        public void insertCotizaciones(string idMon1, string idMon2, string par, int contCotiz, string tipoActivo)
        {
            try
            {
                string valorCotiz;
                if(tipoActivo == "Moneda" || tipoActivo == "Criptomoneda")
                {
                    if(par == "USDTUSD" || par == "DAIUSD")
                    {
                        valorCotiz = "1";
                    }
                    else
                    {
                        valorCotiz = checkCotizacion(par, contCotiz);
                    }                                  
                }
                else
                {
                    valorCotiz = checkCotizacionScrap(par, tipoActivo);
                }
                
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
                    else if (par == "USDARSBO")
                    {
                        tipo = "BOLSA";
                    }
                    else
                    {
                        tipo = "NA";
                    }

                    string sqlQuery = "INSERT INTO Cotizacion_Activo (idActivoBase, idActivoComp, idFecha, tipo, valor) VALUES ('@ID1', '@ID2', CAST(FORMAT(DATEADD(HOUR, -3,GETDATE()), 'yyyyMMdd') AS INTEGER), '@TIPO', @VALOR)";

                    sqlQuery = sqlQuery.Replace("@ID1", idMon1);
                    sqlQuery = sqlQuery.Replace("@ID2", idMon2);
                    sqlQuery = sqlQuery.Replace("@TIPO", tipo);

                    if (tipoActivo == "FCI" || tipoActivo == "Bonos" || tipoActivo == "CEDEAR" || 
                        tipoActivo == "Accion Argentina")
                    {
                        string sqlValor = "1/(" + valorCotiz + "/ (SELECT VALOR FROM Cotizacion_Activo WHERE TIPO = 'BLUE' AND " +
                            "IDFECHA = (SELECT MAX(IDFECHA) FROM Cotizacion_Activo WHERE TIPO = 'BOLSA')))";
                        sqlQuery = sqlQuery.Replace("@VALOR", sqlValor);
                        
                    }
                    else
                    {
                        sqlQuery = sqlQuery.Replace("@VALOR", valorCotiz.Replace(",", "."));
                    }
                    



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

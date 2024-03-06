﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AppFinanzasAJ.Negocio;
using Newtonsoft.Json.Linq;


namespace AppFinanzasAJ.Data
{
    public class CotizacionMonedaAdapter : Adapter
    {
        public Boolean checkDatosDia()
        {
            Boolean checkDatosDia;

            checkDatosDia = false;
            try
            {
                OpenConnection();
                string consulta_select = "SELECT COUNT(*) CONTADOR FROM Cotizacion_Moneda WHERE CAST(fechaHora AS DATE) = CAST(GETDATE() AS DATE);";

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
            string apiKey = "FDYDOY4B5LA56344";
            string currencyPair = par;

            string url = $"https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency={currencyPair.Substring(0, 3)}&to_currency={currencyPair.Substring(3)}&apikey={apiKey}";

            string cotiz;

            try
            {
                using (WebClient wc = new WebClient())
                {



                    string json = wc.DownloadString(url);
                    JObject data = JObject.Parse(json);

                    if (data["Error Message"] != null )
                    {
                        //Console.WriteLine(data["Error Message"]);
                        cotiz = null;
                    }
                    else
                    {
                        cotiz = data["Realtime Currency Exchange Rate"]["5. Exchange Rate"].ToString();
                        
                    }



                    
                    //Console.WriteLine(data["Realtime Currency Exchange Rate"]["5. Exchange Rate"]);
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

                if (valorCotiz != null)
                {
                    this.OpenConnection();
                    SqlCommand insertSQL = null;

                    string sqlQuery = "INSERT INTO Cotizacion_Moneda (idMoneda, idMonedaComp, fechaHora, valor) VALUES ('@ID1', '@ID2', GETDATE(), @VALOR)";

                    sqlQuery = sqlQuery.Replace("@ID1", idMon1);
                    sqlQuery = sqlQuery.Replace("@ID2", idMon2);
                    sqlQuery = sqlQuery.Replace("@VALOR", valorCotiz);

         

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

       
    }
       
}

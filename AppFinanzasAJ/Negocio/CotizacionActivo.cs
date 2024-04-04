using AppFinanzasAJ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace AppFinanzasAJ.Negocio
{
    public class CotizacionActivo
    {
        public int IDACTIVOBASE;
        public int IDACTIVOCOMP;
        public int FECHA;
        public decimal VALOR;
    }

    public class CotizacionActivoLogic
    {
        public CotizacionActivoAdapter _cotizacionActivoData;
        public CotizacionActivoAdapter CotizacionMonedaData
        {
            get { return _cotizacionActivoData; }
            set { _cotizacionActivoData = value; }
        }

        public CotizacionActivoLogic()
        {
            CotizacionMonedaData = new CotizacionActivoAdapter();
        }

        public void updateCotizacionesGral()
        {
            Boolean yaActualizado;

            yaActualizado = CotizacionMonedaData.checkDatosDia();

            if (yaActualizado == false)
            {   
                ActivoLogic activo = new ActivoLogic();
                List<Activo> listaActivos = activo.GetPares();

                Activo mon1 = listaActivos.First();

                int contCotiz = 0;

                foreach(Activo mon2 in listaActivos )
                {
                    if (mon1.IDACTIVO != mon2.IDACTIVO)
                    {
                        string par = mon1.SIMBOLO + mon2.SIMBOLO;

                        if (mon2.TIPOACTIVO != "Moneda" && mon2.TIPOACTIVO != "Criptomoneda")
                        {
                            par = mon2.SIMBOLO;
                            CotizacionMonedaData.insertCotizaciones(mon1.IDACTIVO.ToString(), mon2.IDACTIVO.ToString(), par, contCotiz, mon2.TIPOACTIVO);  
                        }

                        else
                        {
                            if (par == "USDARS")
                            {
                                CotizacionMonedaData.insertCotizaciones(mon1.IDACTIVO.ToString(), mon2.IDACTIVO.ToString(), par + "B", 0, mon2.TIPOACTIVO);
                                CotizacionMonedaData.insertCotizaciones(mon1.IDACTIVO.ToString(), mon2.IDACTIVO.ToString(), par + "BO", 0, mon2.TIPOACTIVO);
                                CotizacionMonedaData.insertCotizaciones(mon1.IDACTIVO.ToString(), mon2.IDACTIVO.ToString(), par + "T", 0, mon2.TIPOACTIVO);
                            }
                            else 
                            {
                                contCotiz++;
                                par = mon2.SIMBOLO + mon1.SIMBOLO;
                                CotizacionMonedaData.insertCotizaciones(mon1.IDACTIVO.ToString(), mon2.IDACTIVO.ToString(), par, contCotiz, mon2.TIPOACTIVO);
                            }
                        }                         
                    }
                }
            }
        }
        public decimal GetCotizDolar()
        {
            return CotizacionMonedaData.getCotizDolarTarjeta();
        }
    }
}

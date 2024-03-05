using AppFinanzasAJ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinanzasAJ.Negocio
{
    public class CotizacionMoneda
    {
        public int IDMONEDA;
        public int IDMONEDACOMP;
        public DateTime FECHAHORA;
        public decimal VALOR;


    }

    public class CotizacionMonedaLogic
    {
        public CotizacionMonedaAdapter _cotizacionMonedaData;
        public CotizacionMonedaAdapter CotizacionMonedaData
        {
            get { return _cotizacionMonedaData; }
            set { _cotizacionMonedaData = value; }
        }

        public CotizacionMonedaLogic()
        {
            CotizacionMonedaData = new CotizacionMonedaAdapter();
        }

        public void updateCotizacionesGral()
        {
            Boolean yaActualizado;

            yaActualizado = CotizacionMonedaData.checkDatosDia();

            if (yaActualizado == false)
            {   
                MonedaLogic moneda = new MonedaLogic();
                List<Moneda> listaMonedas = moneda.GetPares();

      

                foreach (Moneda mon1 in listaMonedas)
                {
                    foreach(Moneda mon2 in listaMonedas )
                    {
                        if (mon1.IDMONEDA != mon2.IDMONEDA)
                        {
                            string par = mon1.SIMBOLO + mon2.SIMBOLO;

                            CotizacionMonedaData.insertCotizaciones(mon1.IDMONEDA.ToString(), mon2.IDMONEDA.ToString(), par);
                        }
                    }
                }


            }

            //CotizacionMonedaData.updateCotizaciones();
        }



      
    }
}

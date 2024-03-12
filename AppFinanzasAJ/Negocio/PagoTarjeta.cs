using AppFinanzasAJ.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinanzasAJ.Negocio
{
    public class PagoTarjeta
    {
        public int IDTARJETA;
        public DateTime FECHAMES;

    }

    public class PagoTarjetaLogic
    {
        public PagoTarjetaAdapter _pagoTarjetaData;
        public PagoTarjetaAdapter PagoTarjetaData
        {
            get { return _pagoTarjetaData; }
            set { _pagoTarjetaData = value; }
        }

        public PagoTarjetaLogic()
        {
            PagoTarjetaData = new PagoTarjetaAdapter();
        }




        public void insertPago(string tarjeta, string fecha)
        {
            PagoTarjetaData.insertPago(tarjeta, fecha);
        }
    }
}

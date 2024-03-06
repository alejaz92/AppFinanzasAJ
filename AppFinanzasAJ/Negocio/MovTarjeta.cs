using AppFinanzasAJ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinanzasAJ.Negocio
{
    public class MovTarjeta
    {
        public int IDMOVIMIENTO;
        public DateTime FECHAMOV;
        public string DETALLE;
        public int IDTARJETA;
        public int IDCLASEMOVIMIENTO;
        public int IDMONEDA;
        public decimal MONTOTOTAL;
        public int CUOTAS;
        public DateTime MESPRIMERCUOTA;
        public DateTime MESULTIMACUOTA;
        public string REPITE;       
    }

    public class MovTarjetaLogic
    {
        public MovTarjetaAdapter _movTarjetaData;
        public MovTarjetaAdapter MovTarjetaData
        {
            get { return _movTarjetaData; }
            set { _movTarjetaData = value; }
        }

        public MovTarjetaLogic()
        {
            MovTarjetaData = new MovTarjetaAdapter();
        }

        public void insertMovimiento(string fechaMov, string detalle, string tarjeta, string claseMovimiento, string monedaMovimiento,
           string montototal, string cuotas, string fecha1, string fecha2)
        {
            string repite;
            if (fecha2 == null)
            { repite = "SI"; }
            else { repite = "NO"; }

            MovTarjetaData.insertMovimiento(fechaMov, detalle, tarjeta, claseMovimiento, monedaMovimiento, montototal, cuotas, fecha1, fecha2, repite);
        }
    }
}

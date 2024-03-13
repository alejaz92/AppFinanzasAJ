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
        public string NOMBREMON;
        public decimal MONTOCUOTA;
        public string CUOTATEXTO;
        public decimal VALORPESOS;
        public string TIPOMOV;
        public string NOMBRETARJ;
        public string ULTCUOTATEXTO;
        
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
           string montototal, string cuotas, string fecha1, string fecha2, string repite)
        {

            MovTarjetaData.insertMovimiento(fechaMov, detalle, tarjeta, claseMovimiento, monedaMovimiento, montototal, cuotas, fecha1, fecha2, repite);
        }

        public List<MovTarjeta> getMovsTarjetaLista(string fecha, string tarjeta)
        {
            return MovTarjetaData.GetMovsTarj(fecha, tarjeta);
        }

        public List<MovTarjeta> getMovsTarjetaGrid()
        {
            return MovTarjetaData.getMovsTarjGrid();
        }

        public void cerrarRecurrente(string fecha, string detalle)
        {
            MovTarjetaData.cerrarRecurrente(fecha, detalle);
        }

        public void actualizarRecurrente(string fecha, string detalle, string montoNuevo, string fechaNueva)
        {

            MovTarjetaData.actualizarRecurrente(fecha, detalle, montoNuevo, fechaNueva);
            MovTarjetaData.cerrarRecurrente(fecha, detalle);
        }
    }
}

using AppFinanzasAJ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinanzasAJ.Negocio
{
    public class Movimiento
    {
        public int IDMOVIMIENTO;
        public int IDCUENTA;
        public int IDMONEDA;
        public int IDFECHA;
        public DateTime FECHA;
        public string TIPOMOVIMIENTO;
        public int IDCLASEMOVIMIENTO;
        public string COMENTARIO;
        public decimal MONTO;
        public string MONEDATEXT;
        public string CLASEMOVTEXT;
        public string CUENTATEXT;

    }

    public class MovimientoLogic
    {
        public MovimientoAdapter _movimientoData;
        public MovimientoAdapter MovimientoData
        {
            get { return _movimientoData; }
            set { _movimientoData = value; }
        }

        public MovimientoLogic()
        {
            MovimientoData = new MovimientoAdapter();
        }
        public void insertMovimientoRegular(string tipoMovimiento, string fechaMovimiento, string monedaMovimiento, 
            string ctaIngresoMovimiento, string claseIngresoMovimiento,
            string ctaEgresoMovimiento, string claseEgresoMovimiento, string detalleMovimiento, string montoMovimiento)
        {
            var idMovimiento = MovimientoData.GetNextID()[0].IDMOVIMIENTO.ToString();
            

            if (tipoMovimiento == "Ingreso")
            {
                MovimientoData.insertMovimiento(idMovimiento, tipoMovimiento, fechaMovimiento, monedaMovimiento, ctaIngresoMovimiento, claseIngresoMovimiento, detalleMovimiento,
                montoMovimiento);
            }
            if (tipoMovimiento == "Egreso")
            {
                MovimientoData.insertMovimiento(idMovimiento, tipoMovimiento, fechaMovimiento, monedaMovimiento, ctaEgresoMovimiento, claseEgresoMovimiento, detalleMovimiento,
                "-" + montoMovimiento);
            }

            if (tipoMovimiento == "Intercambio")
            {
                MovimientoData.insertMovimiento(idMovimiento, tipoMovimiento, fechaMovimiento, monedaMovimiento, ctaEgresoMovimiento, claseEgresoMovimiento, detalleMovimiento,
                "-" + montoMovimiento);

                MovimientoData.insertMovimiento(idMovimiento, tipoMovimiento, fechaMovimiento, monedaMovimiento, ctaIngresoMovimiento, claseIngresoMovimiento, detalleMovimiento,
                montoMovimiento);
            }

        }

        public List<Movimiento> getTopMovimientos()
        {
            return MovimientoData.getTopMovimientos();
        }

        public string getTotalEnPesos()
        {
            return MovimientoData.getTotalEnPesos();
        }
        public string getTotalEnDolares()
        {
            return MovimientoData.getTotalEnDolares();
        }

        //public void insertMovBSF()
        //{
        //    //consulta devoluciones actuales

        //    decimal devActual = MovimientoData.getTotalDevBSF();

        //    //consulta montoMaximo


        //    paramsBSFLogic paramsBSFLogic = new paramsBSFLogic();

        //    /*decimal montoTotal = paramsBSFLogic */

        //}


    }
}

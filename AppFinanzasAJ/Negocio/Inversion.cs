using AppFinanzasAJ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinanzasAJ.Negocio
{
    public class Inversion
    {
        public int IDINVERSION;
        public decimal PRECIO;
    }

    public class InversionLogic
    {
        public InversionAdapter _inversionData;
        public InversionAdapter InversionData
        {
            get { return _inversionData; }
            set { _inversionData = value; }
        }

        public InversionLogic()
        {
            InversionData = new InversionAdapter();
        }

        public void insertInversion(string fechaMovimiento, string tipoMovimiento, string activoMovimiento, string ctaMovimiento,
            string cantidadMovimiento, string precioMovimiento)
        {
            InversionData.insertInversion(fechaMovimiento, tipoMovimiento, activoMovimiento, ctaMovimiento,
                cantidadMovimiento, precioMovimiento);
        }

    }
}

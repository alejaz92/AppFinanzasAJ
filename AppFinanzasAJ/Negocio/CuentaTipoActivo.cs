using AppFinanzasAJ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinanzasAJ.Negocio
{
    public class CuentaTipoActivo
    {
        public int IDCUENTA;
        public int IDTIPOACTIVO;
    }

    public class CuentaTipoActivoLogic
    {
        public CuentaTipoActivoAdapter _cuentaTipoActivoData;
        public CuentaTipoActivoAdapter CuentaTipoActivoData
        {
            get { return _cuentaTipoActivoData; }
            set { _cuentaTipoActivoData = value; }
        }

        public CuentaTipoActivoLogic()
        {
            CuentaTipoActivoData = new CuentaTipoActivoAdapter();
        } 

        public void clearCuenta(string cuenta)
        {
            CuentaTipoActivoData.clearCuenta(cuenta);
        }

        public void insertCuenta(string cuenta, string tipoActivo)
        {
            CuentaTipoActivoData.InsertCuenta(cuenta, tipoActivo);
        }

    }
}

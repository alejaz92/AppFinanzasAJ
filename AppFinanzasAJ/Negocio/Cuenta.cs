using AppFinanzasAJ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinanzasAJ.Negocio
{
    public class Cuenta
    {
        public int IDCUENTA;
        public string NOMBRE;
    }

    public class CuentaLogic
    {
        public CuentaAdapter _cuentaData;
        public CuentaAdapter CuentaData
        {
            get { return _cuentaData; }
            set { _cuentaData = value; }
        }

        public CuentaLogic()
        {
            CuentaData = new CuentaAdapter();
        }

  

        public List<Cuenta> GetCuentas(string tipoCta)
        {
            return CuentaData.Getcuentas(tipoCta);
        }

        public void insertCuenta(string nombreVar, string tipoVar)
        {
            CuentaData.insertCuenta(nombreVar, tipoVar);
        }

        public void deleteCuenta(string nombreVar)
        {
            CuentaData.deleteCuenta(nombreVar);
        }
    }
}

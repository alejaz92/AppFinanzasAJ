using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFinanzasAJ.Data;

namespace AppFinanzasAJ.Negocio
{
    public class TipoMovimiento
    {
        public int IDTIPOMOVIMIENTO;
        public string DESCRIPCION;
        public string INGEGR;
    }

    public class TipoMovimientoLogic
    {
        public TipoMovimientoAdapter _tipoMovimientoData;
        public TipoMovimientoAdapter TipoMovimientoData
        {
            get { return _tipoMovimientoData; }
            set { _tipoMovimientoData = value; }
        }

        public TipoMovimientoLogic()
        {
            TipoMovimientoData = new TipoMovimientoAdapter();
        }

        public List<TipoMovimiento> GetTiposMovimiento()
        {
            return TipoMovimientoData.GetTiposMovimiento();
        }
    }

}

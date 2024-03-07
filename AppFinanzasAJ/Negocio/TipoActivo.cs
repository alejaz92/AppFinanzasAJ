using AppFinanzasAJ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinanzasAJ.Negocio
{
    public class TipoActivo
    {
        public int IDTIPOACTIVO;
        public string NOMBRE;
    }

    public class TipoActivoLogic
    {
        public TipoActivoAdapter _tipoActivoData;
        public TipoActivoAdapter TipoActivoData
        {
            get { return _tipoActivoData; }
            set { _tipoActivoData = value; }
        }

        public TipoActivoLogic()
        {
            TipoActivoData = new TipoActivoAdapter();
        }

        public List<TipoActivo> GetTiposActivo()
        {
            return TipoActivoData.GetTiposActivo();
        }
    }
}

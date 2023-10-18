using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFinanzasAJ.Data;

namespace AppFinanzasAJ.Negocio
{
    public class paramsBSF
    {
        public string parametro;
        public decimal valor;

    }

    public class paramsBSFLogic
    {
        public ParamsBSFAdapter _paramsBSFData;
        public ParamsBSFAdapter ParamsBSFData
        {
            get { return _paramsBSFData; }
            set { _paramsBSFData = value; }
        }

        public paramsBSFLogic()
        {
            ParamsBSFData = new ParamsBSFAdapter();
        }

        public List<paramsBSF> getValues()
        {
            return ParamsBSFData.GetValues();
        }

        public void updateValues(string montoVar, string porcentajeVar)
        {
            ParamsBSFData.updateParams(montoVar, porcentajeVar);
        }
    }
}

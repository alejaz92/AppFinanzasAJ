using AppFinanzasAJ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinanzasAJ.Negocio
{
    public class Moneda
    {
        public int IDMONEDA;
        public string SIMBOLO;
        public string NOMBRE;
        public bool ESFIAT;
        public bool ESPRINCIPAL;
    }

    public class MonedaLogic
    {
        public MonedaAdapter _monedaData;
        public MonedaAdapter MonedaData
        {
            get { return _monedaData; }
            set { _monedaData = value; }
        }

        public MonedaLogic()
        {
            MonedaData = new MonedaAdapter();
        }

        public List<Moneda> GetMonedas()
        {
            return MonedaData.GetMonedas();
        }

        public List<Moneda> GetMonedasEdit(string nombreVar)
        {
            return MonedaData.GetMonedasEdit(nombreVar);
        }

        public void deleteMoneda(string nombreVar)
        {
            MonedaData.deleteMoneda(nombreVar);
        }

        public void insertMoneda(string nombreVar, string simboloVar, bool esFiatVar)
        {
            MonedaData.insertMoneda(nombreVar, simboloVar, esFiatVar);
        }

        public void updateMoneda(int idVar,string nombreVar, string simboloVar, bool esFiatVar)
        {
            MonedaData.updatetMoneda(idVar,nombreVar, simboloVar, esFiatVar);
        }

    }
}

using AppFinanzasAJ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinanzasAJ.Negocio
{
    public class Tarjeta
    {
        public int IDTARJETA;
        public string NOMBRE;

    }

    public class TarjetaLogic
    {
        public TarjetaAdapter _tarjetaData;
        public TarjetaAdapter TarjetaData
        {
            get { return _tarjetaData; }
            set { _tarjetaData = value; }
        }

        public TarjetaLogic()
        {
            TarjetaData = new TarjetaAdapter();
        }


        public List<Tarjeta> GetTarjetas()
        {
            return TarjetaData.GetTarjetas();
        }

        public void insertTarjeta(string nombreVar)
        {
            TarjetaData.insertTarjeta(nombreVar);
        }

        public void deleteTarjeta(string nombreVar)
        {
            TarjetaData.deleteTarjeta(nombreVar);
        }
    }
}

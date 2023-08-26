using AppFinanzasAJ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinanzasAJ.Negocio
{
    public class ClaseMovimiento
    {
        public int IDCLASEMOVIMIENTO;
        public string DESCRIPCION;
        public string INGEGR;

    }

    public class ClaseMovimientoLogic
    {
        public ClaseMovimientoAdapter _claseMovimientoData;
        public ClaseMovimientoAdapter ClaseMovimientoData
        {
            get { return _claseMovimientoData; }
            set { _claseMovimientoData = value; }
        }

        public ClaseMovimientoLogic()
        {
            ClaseMovimientoData = new ClaseMovimientoAdapter();
        }

        public List<ClaseMovimiento> GetClasesMovimiento()
        {
            return ClaseMovimientoData.GetClasesMovimiento();
        }

        public void insertClaseMovimiento(string nombreVar, string claseVar)
        {
            ClaseMovimientoData.insertClaseMovimiento(nombreVar, claseVar);
        }

        public void deleteClaseMovimiento(string nombreVar, string claseVar)
        {
            ClaseMovimientoData.deleteClaseMovimiento(nombreVar, claseVar);
        }
    }
}

using AppFinanzasAJ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinanzasAJ.Negocio
{
    public class Activo
    {
        public int IDACTIVO;
        public int IDTIPOACTIVO;
        public string SIMBOLO;
        public string NOMBRE;
        public bool ESPRINCIPAL;
        public bool ESREFERENCIACOTIZ;
        public string TIPOACTIVO;
    }

    public class ActivoLogic
    {
        public ActivoAdapter _activoData;
        public ActivoAdapter ActivoData
        {
            get { return _activoData; }
            set { _activoData = value; }
        }

        public ActivoLogic()
        {
            ActivoData = new ActivoAdapter();
        }

        public List<Activo> GetActivos(string tipoAct)
        {
            return ActivoData.GetActivos(tipoAct);
        }

        public List<Activo> GetActivosPrincipal()
        {
            return ActivoData.GetActivosPrincipal();
        }

        public List<Activo> GetActivoRef()
        {
            return ActivoData.GetActivoRef();
        }

        public List<Activo> GetActivosEdit(string nombreVar)
        {
            return ActivoData.GetActivosEdit(nombreVar);
        }

        public void deleteActivo(string nombreVar)
        {
            ActivoData.deleteActivo(nombreVar);
        }

        public void insertActivo(string nombreVar, string simboloVar, string tipoAct)
        {
            ActivoData.insertActivo(nombreVar, simboloVar, tipoAct);
        }

        public void updateActivo(int idVar,string nombreVar, string simboloVar)
        {
            ActivoData.updatetActivo(idVar,nombreVar, simboloVar);
        }

        public void updateActivoPrincipal( string nombreVar)
        {
            ActivoData.updatetActivoPrincipal(nombreVar);
        }

        public void updateActivoRef(string nombreVar)
        {
            ActivoData.updatetActivoRef(nombreVar);
        }

        public List<Activo> GetPares()
        {
            return ActivoData.GetPares();
        }
    }
}

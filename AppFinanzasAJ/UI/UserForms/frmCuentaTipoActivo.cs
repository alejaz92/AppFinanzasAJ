using AppFinanzasAJ.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFinanzasAJ.UI.UserForms
{
    public partial class frmCuentaTipoActivo : Form
    {
        public frmCuentaTipoActivo()
        {
            InitializeComponent();
        }

        private void frmCuentaTipoActivo_Load(object sender, EventArgs e)
        {
            cboCuentas.Items.Clear();
            CuentaLogic cuentaLogic = new CuentaLogic();    
            List<Cuenta> listadoCuentas = cuentaLogic.GetCuentas();

            foreach (Cuenta cta in listadoCuentas)
            {
                cboCuentas.Items.Add(cta.NOMBRE);
            }

            lstTipoActivo.Items.Clear();

            TipoActivoLogic tipoActivoLogic = new TipoActivoLogic();
            List<TipoActivo> listadoTipoActivos = tipoActivoLogic.GetTiposActivo(); 

            foreach (TipoActivo tActivo in listadoTipoActivos)
            {
                lstTipoActivo.Items.Add(tActivo.NOMBRE);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSeleccionados.Items.Clear();
            TipoActivoLogic tipoActivoLogic = new TipoActivoLogic();
            List<TipoActivo> listadoTipoActivos = tipoActivoLogic.GetTiposActivosPorCuenta(cboCuentas.Text);

            foreach (TipoActivo tActivo in listadoTipoActivos)
            {
                lstSeleccionados.Items.Add(tActivo.NOMBRE);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (cboCuentas != null)
            {
                lstSeleccionados.Items.Clear();


                foreach (object item in lstTipoActivo.SelectedItems)
                {
                    lstSeleccionados.Items.Add(item.ToString());
                }
            }           

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboCuentas != null)
            {
                CuentaTipoActivoLogic cuentaTipoActivoLogic = new CuentaTipoActivoLogic();
                cuentaTipoActivoLogic.clearCuenta(cboCuentas.Text);

                foreach(var item in lstSeleccionados.Items)
                {
                    cuentaTipoActivoLogic.insertCuenta(cboCuentas.Text, item.ToString());
                }

                MessageBox.Show("Cuenta actualizada");
            }
        }
    }
}

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
    public partial class frmMonedaRef : Form
    {
        public frmMonedaRef()
        {
            InitializeComponent();
        }

        private void frmMonedaRef_Load(object sender, EventArgs e)
        {
            lstMonedas.Items.Clear();
            ActivoLogic monedalogic = new ActivoLogic();

            List<Activo> listaMonedas = monedalogic.GetActivoRef();

            foreach (var moneda in listaMonedas)
            {
                lstMonedas.Items.Add(moneda.NOMBRE);
                if (moneda.ESREFERENCIACOTIZ == true)
                {
                    lstMonedas.SelectedIndex = lstMonedas.Items.Count - 1;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ActivoLogic monedaLogic = new ActivoLogic();
            string nombreVar = lstMonedas.GetItemText(lstMonedas.SelectedItem);

            monedaLogic.updateActivoRef(nombreVar);


            this.Close();
        }
    }
}

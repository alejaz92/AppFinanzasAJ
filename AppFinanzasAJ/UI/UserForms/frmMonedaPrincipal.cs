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
    public partial class frmMonedaPrincipal : Form
    {
        public frmMonedaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMonedaPrincipal_Load(object sender, EventArgs e)
        {
            lstMonedas.Items.Clear();
            MonedaLogic monedalogic = new MonedaLogic();

            List<Moneda> listaMonedas = monedalogic.GetMonedasPrincipal();

            foreach (var moneda in listaMonedas)
            {
                lstMonedas.Items.Add(moneda.NOMBRE);
                if (moneda.ESPRINCIPAL == true)
                {
                    lstMonedas.SelectedIndex = lstMonedas.Items.Count - 1;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MonedaLogic monedaLogic = new MonedaLogic();
            string nombreVar = lstMonedas.GetItemText(lstMonedas.SelectedItem);

            monedaLogic.updateMonedaPrincipal(nombreVar);




            this.Close();
        }
    }
}

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
    public partial class frmAdminCuentas : Form
    {
        public frmAdminCuentas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdminCuentas_Load(object sender, EventArgs e)
        {
            CuentaLogic cuentalogic = new CuentaLogic();

            List<Cuenta> listaCuentas = cuentalogic.GetCuentas();

            foreach(var cta in listaCuentas)
            {
                lstCuentas.Items.Add(cta.NOMBRE);
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtAddCta.Text.Length != 0)
            {
                CuentaLogic cuentaLogic = new CuentaLogic();

                cuentaLogic.insertCuenta(txtAddCta.Text);

                lstCuentas.Items.Add(txtAddCta.Text);

                txtAddCta.Text = "";
            }
            else
            {
                MessageBox.Show("Debe colocar un nombre de cuenta para insertar", "Importante");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreVar = lstCuentas.Text;

            

            if (nombreVar.Length != 0)
            {
                CuentaLogic cuentaLogic = new CuentaLogic();

                cuentaLogic.deleteCuenta(nombreVar);


                lstCuentas.Items.Remove(nombreVar);
            }

        }

        private void lstCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAddCta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

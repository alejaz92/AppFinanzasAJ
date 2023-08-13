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
    }
}

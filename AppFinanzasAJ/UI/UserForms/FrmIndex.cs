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
using AppFinanzasAJ.UI.UserForms;

namespace AppFinanzasAJ
{
    public partial class FrmIndex : Form
    {
        public FrmIndex()
        {
            InitializeComponent();
        }



        private void btnCuentas_Click(object sender, EventArgs e)
        {
            frmAdminCuentas frmAC = new frmAdminCuentas();

            frmAC.ShowDialog();
        }

        private void btnMonedas_Click(object sender, EventArgs e)
        {
            frmAdminMonedas frmAM = new frmAdminMonedas();

            frmAM.ShowDialog();
        }

        private void FrmIndex_Load(object sender, EventArgs e)
        {
        }

        private void btnClaseMovimiento_Click(object sender, EventArgs e)
        {
            frmAdminClaseMovimiento frmCM = new frmAdminClaseMovimiento();
            frmCM.ShowDialog();
        }

        private void btnRegMovimiento_Click(object sender, EventArgs e)
        {
            frmRegistrarMovimiento frmRM = new frmRegistrarMovimiento();
            frmRM.ShowDialog();
        }
    }
}

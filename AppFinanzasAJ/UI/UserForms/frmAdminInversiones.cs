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
    public partial class frmAdminInversiones : Form
    {
        public frmAdminInversiones()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnMovCrypto_Click(object sender, EventArgs e)
        {
            frmMovCrypto frmMovCrypto = new frmMovCrypto();
            frmMovCrypto.ShowDialog();
        }

        private void btnMovBolsa_Click(object sender, EventArgs e)
        {
            frmMovBolsa frmMovBolsa = new frmMovBolsa();
            frmMovBolsa.ShowDialog();  
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            frmIntMoneda frmIntMon = new frmIntMoneda();
            frmIntMon.ShowDialog();
        }
    }
}

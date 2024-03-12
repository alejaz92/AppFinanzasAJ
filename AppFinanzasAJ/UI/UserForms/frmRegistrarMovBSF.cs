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
    public partial class frmRegistrarMovBSF : Form
    {
        public frmRegistrarMovBSF()
        {
            InitializeComponent();
        }

        
        private void checkEnabled()
        {
            if (this.cboFecha.Text != "" && this.cboCtaEgreso.Text != "" && this.cboClaseEgreso.Text != "" && this.txtMonto.Text != "")
            {
                this.btnInsertar.Enabled = true;
            }
            else
            {
                this.btnInsertar.Enabled = false;
            }
        }

        private void cboFecha_ValueChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }
        private void cboCtaEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void cboClaseEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistrarMovBSF_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmParamsBSF : Form
    {
        public frmParamsBSF()
        {
            InitializeComponent();
        }

        private void frmParamsBSF_Load(object sender, EventArgs e)
        {
            

            paramsBSFLogic paramsBSFLogic = new paramsBSFLogic();
            List<paramsBSF> listaParamsBSF = paramsBSFLogic.getValues();

            foreach (paramsBSF param in listaParamsBSF) 
            {
                if (param.parametro == "totalMes")
                {
                    this.txtMonto.Text = param.valor.ToString();
                }
                else
                {
                    this.txtPorcentaje.Text = param.valor.ToString();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtMonto != null && this.txtPorcentaje != null)
            {
                paramsBSFLogic paramsBSFLogic = new paramsBSFLogic();
                paramsBSFLogic.updateValues(this.txtMonto.Text, this.txtPorcentaje.Text);

                MessageBox.Show("Datos actualizados correctamente");
            }
        }
    }
}

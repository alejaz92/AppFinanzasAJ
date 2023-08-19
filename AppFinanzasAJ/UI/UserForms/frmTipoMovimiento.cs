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
    public partial class frmTipoMovimiento : Form
    {

        public string descripcionEdit;
        public frmTipoMovimiento()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void frmTipoMovimiento_Load(object sender, EventArgs e)
        {
            lstTipoIngreso.Items.Clear();
            lstTipoEgreso.Items.Clear();

            TipoMovimientoLogic tipoMovimientoLogic = new TipoMovimientoLogic();

            List<TipoMovimiento> listaTiposMovmiento = tipoMovimientoLogic.GetTiposMovimiento();

            foreach (var tipoMovimiento in listaTiposMovmiento)
            {
                if (tipoMovimiento.INGEGR == "Ingreso")
                {
                    lstTipoIngreso.Items.Add(tipoMovimiento.DESCRIPCION);
                }
                else
                {
                    lstTipoEgreso.Items.Add(tipoMovimiento.DESCRIPCION);
                }
                
            }
        }


        private void btnAgregarI_Click(object sender, EventArgs e)
        {
            descripcionEdit = "";
            frmEditTipoMovimiento frmETM = new frmEditTipoMovimiento(descripcionEdit);



            frmETM.Show();
        }

        private void btnAgregarE_Click(object sender, EventArgs e)
        {
            descripcionEdit = "";
            frmEditTipoMovimiento frmETM = new frmEditTipoMovimiento(descripcionEdit);



            frmETM.Show();
        }

        private void btnEditarI_Click(object sender, EventArgs e)
        {
            descripcionEdit = lstTipoIngreso.Text;
            frmEditTipoMovimiento frmETM = new frmEditTipoMovimiento(descripcionEdit);



            frmETM.Show();
        }

        private void btnEditarE_Click(object sender, EventArgs e)
        {
            descripcionEdit = lstTipoEgreso.Text;
            frmEditTipoMovimiento frmETM = new frmEditTipoMovimiento(descripcionEdit);



            frmETM.Show();
        }
    }
}

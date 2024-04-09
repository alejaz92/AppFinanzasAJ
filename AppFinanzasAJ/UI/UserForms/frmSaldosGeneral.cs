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
    public partial class frmSaldosGeneral : Form
    {
        public frmSaldosGeneral()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSaldosGeneral_Load(object sender, EventArgs e)
        {
            MovimientoLogic movimientoLogic = new MovimientoLogic();

            lblTotalPesos.Text = "$ " + movimientoLogic.getTotalEnPesos().ToString();
            lblTotalDolar.Text = "U$S " + movimientoLogic.getTotalEnDolares().ToString();


            loadTiposActivo();

        }

        private void loadTiposActivo()
        {
            cboTipoActivo.Items.Clear();
            TipoActivoLogic tipoActivoLogic = new TipoActivoLogic();

            List<TipoActivo> ListaTiposActivo = tipoActivoLogic.GetTiposActivo();

            foreach (TipoActivo ta in ListaTiposActivo)
            {
                cboTipoActivo.Items.Add(ta.NOMBRE);
            }
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }




        private void cboTipoActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadActivos();
        }

        private void loadActivos()
        {
            cboActivo.Items.Clear();
            cboActivo.Text = "";

            ActivoLogic activoLogic = new ActivoLogic();

            List<Activo> ListaActivos = activoLogic.GetActivos(cboTipoActivo.Text);

            foreach (Activo activo in ListaActivos)
            {
                cboActivo.Items.Add(activo.NOMBRE);
            }
        }

        private void cboActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTenencias();
        }

        private void loadTenencias()
        {
            dgvCuentas.Rows.Clear();

            MovimientoLogic movimientoLogic = new MovimientoLogic();

            List<Movimiento> ListaMovimientos = movimientoLogic.getTotalesPorCuenta(cboActivo.Text, cboTipoActivo.Text);


            foreach (Movimiento mov in ListaMovimientos)
            {
                dgvCuentas.Rows.Add(mov.CUENTATEXT, mov.MONTO);
               
            }
        }
    }
}

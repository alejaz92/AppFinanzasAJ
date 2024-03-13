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
    public partial class frmRecurrente : Form
    {
        public string fechaVar;
        public string detalleVar;
        public string montoVar;
        public string tarjetaVar;
        frmGestTarjeta frmGest;
        public frmRecurrente(frmGestTarjeta f, string fecha, string detalle, string monto, string tarjeta)
        {
            InitializeComponent();

            frmGest = f;
            fechaVar = fecha;
            detalleVar = detalle;
            montoVar = monto;
            tarjetaVar = tarjeta;


        }

        private void radCerrar_CheckedChanged(object sender, EventArgs e)
        {
            cboFechaNueva.Enabled = false;
            txtMontoNuevo.Enabled = false;
        }

        private void radEditar_CheckedChanged(object sender, EventArgs e)
        {
            cboFechaNueva.Enabled = true;
            txtMontoNuevo.Enabled = true;
        }

        private void frmRecurrente_Load(object sender, EventArgs e)
        {
            txtDetalle.Text = detalleVar;
            txtFecha.Text = fechaVar;
            txtMontoAct.Text = montoVar;
            txtTarjeta.Text = tarjetaVar;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (radCerrar.Checked)
            {
                MovTarjetaLogic movTarjetaLogic = new MovTarjetaLogic();
                movTarjetaLogic.cerrarRecurrente(txtFecha.Text, txtDetalle.Text);

                MessageBox.Show("Movimiento recurrente cerrado");
                Close();
            }
            else if (radEditar.Checked && txtMontoNuevo.Text != "")
            {
                MovTarjetaLogic movTarjetaLogic = new MovTarjetaLogic();
                movTarjetaLogic.actualizarRecurrente(txtFecha.Text, txtDetalle.Text, txtMontoNuevo.Text, cboFechaNueva.Value.ToString("yyyy-MM-dd"));

                MessageBox.Show("Movimiento recurrente actualizado");
                Close();
            }
        }
    }
}

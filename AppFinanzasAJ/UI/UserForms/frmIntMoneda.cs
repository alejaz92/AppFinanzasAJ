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
    public partial class frmIntMoneda : Form
    {
        public frmIntMoneda()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmIntMoneda_Load(object sender, EventArgs e)
        {
            ActivoLogic activoLogic = new ActivoLogic();
            List<Activo> ListaActivosMoneda = activoLogic.GetActivos("Moneda");

            foreach(Activo activo in ListaActivosMoneda)
            {
                cboActivoEgreso.Items.Add(activo.NOMBRE);
                cboActivoIngreso.Items.Add(activo.NOMBRE);
            }

            CuentaLogic cuentaLogic = new CuentaLogic();
            List<Cuenta> ListaCuentasMoneda = cuentaLogic.GetCuentasPorTipo("Moneda");

            foreach(Cuenta cta in ListaCuentasMoneda)
            {
                cboCtaEgreso.Items.Add(cta.NOMBRE);
                cboCtaIngreso.Items.Add(cta.NOMBRE);
            }

            checkEnabled();
        }

        private void checkEnabled()
        {
            if (cboFecha.Text != ""  && cboActivoEgreso.Text != "" && cboActivoIngreso.Text != "" &&
                cboActivoEgreso.Text != cboActivoIngreso.Text && cboCtaEgreso.Text != "" &&
                cboCtaIngreso.Text != "" && txtCantidadEgreso.Text != "" && txtCantidadIngreso.Text != "")
            {
                btnInsertar.Enabled = true;
            } 
            else
            {
                btnInsertar.Enabled = false;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            MovimientoLogic movimientoLogic = new MovimientoLogic();

            movimientoLogic.insertMovimientoRegular("IngMoneda", cboFecha.Value.ToString("yyyyMMdd"),
                    cboActivoIngreso.Text, cboCtaIngreso.Text, null, null, null, null, txtCantidadIngreso.Text,
                    "");

            movimientoLogic.insertMovimientoRegular("EgrMoneda", cboFecha.Value.ToString("yyyyMMdd"),
                        cboActivoEgreso.Text, null, null, cboCtaEgreso.Text, null, null, txtCantidadEgreso.Text,
                        "");

            MessageBox.Show("Intercambio registrado");
            Close();
        }

        private void cboFecha_ValueChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void cboActivoEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void cboCtaEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void txtCantidadEgreso_TextChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void cboActivoIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void cboCtaIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void txtCantidadIngreso_TextChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }
    }
}

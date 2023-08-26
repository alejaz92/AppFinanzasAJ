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
    public partial class frmRegistrarMovimiento : Form
    {
        public frmRegistrarMovimiento()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radIngreso_CheckedChanged(object sender, EventArgs e)
        {
            cboCtaIngreso.Enabled = true;
            cboClaseIngreso.Enabled = true; 
            cboCtaEgreso.Enabled = false;
            cboClaseEgreso.Enabled = false;
            cboCtaEgreso.Text = "";
            cboClaseEgreso.Text = "";
            checkEnabled();
        }

        private void radEgreso_CheckedChanged(object sender, EventArgs e)
        {
            cboCtaIngreso.Enabled = false;
            cboClaseIngreso.Enabled= false;
            cboCtaEgreso.Enabled = true;
            cboClaseEgreso.Enabled = true;
            cboCtaIngreso.Text = "";
            cboClaseIngreso.Text = "";
            checkEnabled();
        }

        private void radIntercambio_CheckedChanged(object sender, EventArgs e)
        {
            cboCtaIngreso.Enabled = true;
            cboClaseIngreso.Enabled = false;
            cboCtaEgreso.Enabled = true;
            cboClaseEgreso.Enabled = false;
            checkEnabled();
        }

        private void checkEnabled()
        {
            if (radEgreso.Checked)
            {
                if (cboFecha.Text != "" && cboCtaEgreso.Text != "" && cboClaseEgreso.Text != "" && cboMoneda.Text != "" && txtMonto.Text != "")
                {
                    btnInsertar.Enabled = true;
                }
                else
                {
                    btnInsertar.Enabled = false;
                }
            }
            else if (radIngreso.Checked)
            {
                if (cboFecha.Text != "" && cboCtaIngreso.Text != "" && cboClaseIngreso.Text != ""  && cboMoneda.Text != "" && txtMonto.Text != "")
                {
                    btnInsertar.Enabled = true;
                }
                else
                {
                    btnInsertar.Enabled = false;
                }
            }
            else if (radIntercambio.Checked)
            {
                if (cboFecha.Text != "" && cboCtaIngreso.Text != "" && cboCtaEgreso.Text != "" && cboMoneda.Text != "" && txtMonto.Text != "")
                {
                    btnInsertar.Enabled = true;
                }
                else
                {
                    btnInsertar.Enabled = false;
                }
            }
            else
            {
                btnInsertar.Enabled = false;
            }
        }

        private void cboFecha_ValueChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void cboCtaIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void cboCtaEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void frmRegistrarMovimiento_Load(object sender, EventArgs e)
        {

            //Cargar monedas
            MonedaLogic monedalogic = new MonedaLogic();

            List<Moneda> listaMonedas = monedalogic.GetMonedas();

            foreach (var moneda in listaMonedas)
            {
                cboMoneda.Items.Add(moneda.NOMBRE);
            }

            // Cargar cuentas

            CuentaLogic cuentalogic = new CuentaLogic();

            List<Cuenta> listaCuentas = cuentalogic.GetCuentas();

            foreach (var cta in listaCuentas)
            {
                cboCtaEgreso.Items.Add(cta.NOMBRE);
                cboCtaIngreso.Items.Add(cta.NOMBRE);
            }

            //Cargar clases de movimiento


            ClaseMovimientoLogic claseMovimientoLogic = new ClaseMovimientoLogic();

            List<ClaseMovimiento> listaClasesMovmiento = claseMovimientoLogic.GetClasesMovimiento();

            foreach (var claseMovimiento in listaClasesMovmiento)
            {
                if (claseMovimiento.INGEGR == "Ingreso")
                {
                    cboClaseIngreso.Items.Add(claseMovimiento.DESCRIPCION);
                }
                else
                {
                    cboClaseEgreso.Items.Add(claseMovimiento.DESCRIPCION);
                }


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

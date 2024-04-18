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
    public partial class frmReintegro : Form
    {
        public string fechaV;
        public string claseMovV;
        public string detalleV;
        public string cuentaOrigV;
        public string montoTotV;
        public string idMovimientoV;

        public frmReintegro(string fecha, string claseMov, string detalle, string cuentaOrig, string montoTot, string idMovimiento)
        {
            InitializeComponent();

            fechaV = fecha;
            claseMovV = claseMov;
            detalleV = detalle;
            cuentaOrigV = cuentaOrig;
            montoTotV = montoTot;
            idMovimientoV = idMovimiento;
        }

        private void frmReintegro_Load(object sender, EventArgs e)
        {
            txtFecha.Text = fechaV;
            txtClase.Text = claseMovV;
            txtDetalle.Text = detalleV;
            txtCtaOrig.Text = cuentaOrigV;
            txtMontoTot.Text = montoTotV.Replace("-", "");

            CuentaLogic cuentaLogic = new CuentaLogic();
            List<Cuenta> ListaCuentas = cuentaLogic.GetCuentasPorTipo("Moneda");

            foreach (Cuenta cta in ListaCuentas)
            {
                cboCtaReint.Items.Add(cta.NOMBRE);
            }
            cboCtaReint.Text = cuentaOrigV;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkEnabled()
        {
            decimal total = Convert.ToDecimal(txtMontoTot.Text);
            
            if (cboCtaReint.Text != "" && txtMontoReint.Text != "")
            {
                decimal reintegro = Convert.ToDecimal(txtMontoReint.Text.Replace(",", "."));
                if (reintegro <= total)
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

        private void cboCtaReint_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void txtMontoReint_TextChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }
    }
}

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


            showTenenciasMonetarias();

        }

        private void showTenenciasMonetarias()
        {
            foreach (Panel panel in this.Controls)
            {

                if (panel.Name == "panTenenciasMonetarias")
                {
                    panel.Visible = true;
                    panel.Location = new Point(247, 0);

                    //llenar combobox de monedas

                    ActivoLogic activoLogic = new ActivoLogic();   
                    List<Activo> listaActivos = activoLogic.GetActivos("Moneda");

                    foreach (Activo activo in listaActivos)
                    {
                        cboActivoTenencias.Items.Add(activo.NOMBRE);
                        if (activo.ESPRINCIPAL == true)
                        {
                            cboActivoTenencias.Text = activo.NOMBRE;
                        }
                    }

                    updateTenenciasMonetarias();

                }
                else if (panel.Name != "panMenu")
                {
                    panel.Visible = false;
                    panel.Location = new Point(30000, 0);
                }
                   

            }

        }

        private void updateTenenciasMonetarias()
        {
            charTenencias1.Series[0].Points.Clear();

            MovimientoLogic movimientoLogic = new MovimientoLogic();
            List<Movimiento> listaTotalesCuenta = movimientoLogic.getTotalesPorCuentaMon(cboActivoTenencias.Text);

            foreach (Movimiento movimiento in listaTotalesCuenta)
            {
                charTenencias1.Series[0].Points.AddXY(movimiento.CUENTATEXT, movimiento.MONTO);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cboActivoTenencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTenenciasMonetarias();
        }

        private void btnPBI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }
    }
}

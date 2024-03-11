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
    public partial class frmPagoTarjeta : Form
    {
        public decimal cotizDolar;
        public frmPagoTarjeta()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPagoTarjeta_Load(object sender, EventArgs e)
        {

            cboMesPago.Format = DateTimePickerFormat.Custom;
            cboMesPago.CustomFormat = "MMMM yyyy";
            cboMesPago.ShowUpDown = true;

            cboMesPago.Value = DateTime.Now.AddMonths(-1);


            TarjetaLogic tarjetaLogic = new TarjetaLogic();
            List<Tarjeta> listaTarjeas = tarjetaLogic.GetTarjetas();

            foreach (Tarjeta tarjeta in listaTarjeas)
            {
                cboTarjeta.Items.Add(tarjeta.NOMBRE.ToString());
            }

            CuentaLogic cuentaLogic = new CuentaLogic();
            List<Cuenta> listaCuentas = cuentaLogic.GetCuentas();

            foreach (Cuenta cuenta in listaCuentas)
            {
                cboCuenta.Items.Add(cuenta.NOMBRE.ToString());
            }

            CotizacionActivoLogic cotizacionActivoLogic = new CotizacionActivoLogic();

            cotizDolar = cotizacionActivoLogic.GetCotizDolar();
        }

        private void cboTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTarjeta.Text != "" && cboMesPago != null)
            {
                refreshList();
            }
        }

        

        private void cboMesPago_ValueChanged(object sender, EventArgs e)
        {
            if (cboTarjeta.Text != "" && cboMesPago != null)
            {
                refreshList();
            }
        }

        public void refreshList()
        {
            string mesSel = cboMesPago.Value.ToString("yyyy-MM") + "-01";
            string tarjetaSel  = cboTarjeta.Text;

            lstErogaciones.Rows.Clear();
            
            MovTarjetaLogic movTarjetaLogic = new MovTarjetaLogic();

            List<MovTarjeta> ListamovTarjeta = movTarjetaLogic.getMovsTarjetaLista(mesSel, tarjetaSel);




            foreach (MovTarjeta movTarjeta in  ListamovTarjeta)
            {
                lstErogaciones.Rows.Add(movTarjeta.FECHAMOV.ToString("yyyy/MM/dd"),movTarjeta.TIPOMOV, movTarjeta.DETALLE, movTarjeta.NOMBREMON, movTarjeta.CUOTATEXTO, movTarjeta.MONTOCUOTA, movTarjeta.VALORPESOS);
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radPesos_CheckedChanged(object sender, EventArgs e)
        {
            txtDolar.Enabled = false;
            txtDolar.Text = string.Empty;

        }

        private void radDolar_CheckedChanged(object sender, EventArgs e)
        {
            txtDolar.Enabled = true;
        }

        private void checkResto()
        {
            decimal total = 0;
            if ( txtPesos.Text != "")
            {

                for (int i = 0; i < lstErogaciones.Rows.Count; i++)
                {
                    total = total + Convert.ToDecimal( lstErogaciones.Rows[i].Cells[6].Value);           
                }

                if (txtDolar.Text != "")
                {
                    txtGtosTarj.Text = (Convert.ToDecimal(txtPesos.Text) - total + Convert.ToDecimal(txtDolar.Text) * cotizDolar).ToString();
                }
                else
                {
                    txtGtosTarj.Text = (Convert.ToDecimal(txtPesos.Text) - total).ToString();
                } 
                
            }
            
        }

        private void txtPesos_TextChanged(object sender, EventArgs e)
        {
            checkResto();
        }

        private void txtDolar_TextChanged(object sender, EventArgs e)
        {
            checkResto();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtGtosTarj) >= 0)
            {
                

                for (int i = 0; i < lstErogaciones.Rows.Count; i++)
                {
                    MovimientoLogic movimientoLogic = new MovimientoLogic();

                    //movimientoLogic.insertMovimientoRegular();
                }

            }
            else
            {
                MessageBox.Show("Debe colocar un monto mayor", "Importante");
            }
        }
    }
}

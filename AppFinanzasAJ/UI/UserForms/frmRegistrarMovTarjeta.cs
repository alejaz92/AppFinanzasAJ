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
    public partial class frmRegistrarMovTarjeta : Form
    {
        public frmRegistrarMovTarjeta()
        {
            InitializeComponent();
        }

        private void frmRegistrarMovTarjeta_Load(object sender, EventArgs e)
        {

            // cargar años

            cboAnio1.Maximum = DateTime.Now.Year + 5;
            //boAnio2.Maximum = DateTime.Now.Year + 5;
            cboAnio1.Minimum = DateTime.Now.Year - 2;
           // cboAnio2.Minimum = DateTime.Now.Year - 2;
            cboAnio1.Value = DateTime.Now.Year;
            cboAnio2.Value = DateTime.Now.Year;

            cboAnio2.Enabled = false;
            cboMes2.Enabled = false;   

            //Cargar monedas
            MonedaLogic monedalogic = new MonedaLogic();

            List<Moneda> listaMonedas = monedalogic.GetMonedas();

            foreach (var moneda in listaMonedas)
            {
                cboMoneda.Items.Add(moneda.NOMBRE);
            }



            //Cargar clases de movimiento


            ClaseMovimientoLogic claseMovimientoLogic = new ClaseMovimientoLogic();

            List<ClaseMovimiento> listaClasesMovmiento = claseMovimientoLogic.GetClasesMovimiento();

            foreach (var claseMovimiento in listaClasesMovmiento)
            {
                if (claseMovimiento.INGEGR == "Egreso")
                {
                    cboClaseMov.Items.Add(claseMovimiento.DESCRIPCION);
                }
            }

            // Cargar tarjetas

            TarjetaLogic tarjetaLogic = new TarjetaLogic();
            List <Tarjeta> listaTarjetas = tarjetaLogic.GetTarjetas();

            foreach (var tarjeta in listaTarjetas)
            {
                cboTarjeta.Items.Add(tarjeta.NOMBRE);
            }

            radUnico.Checked = true;
            checkEnabled();
            //updateUltimaCuota();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radRecurrente_CheckedChanged(object sender, EventArgs e)
        {
            updateUltimaCuota();
            checkEnabled();
        }

        private void radUnico_CheckedChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void updateUltimaCuota()
        {
            if (radUnico.Checked) 
            {
                int cuotas = Convert.ToInt32(cboCuotas.Value);
                string mes1 = Convert.ToString(cboMes1.Value);
                string anio1 = Convert.ToString(cboAnio1.Value);
                string fecha1 = anio1 + "-" + mes1 + "-01";

                DateTime fecha2 = Convert.ToDateTime(fecha1).AddMonths(cuotas - 1);
                int mes2 = fecha2.Month;
                int anio2 = fecha2.Year;

                cboAnio2.Value = anio2;
                cboMes2.Value = mes2;
            }
            else
            {
                cboAnio2.Value = 0;
                cboMes2.Value = 0;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //MovimientoLogic movimientoLogic = new MovimientoLogic();

            MovTarjetaLogic movTarjetaLogic = new MovTarjetaLogic();
            string cuotas;
            string fecha1;
            string fecha2;

            string mes1 = Convert.ToString(cboMes1.Value);
            string anio1 = Convert.ToString(cboAnio1.Value);
            fecha1 = anio1 + "-" + mes1 + "-01";


            if (radUnico.Checked)
            {
                cuotas = cboCuotas.Value.ToString();

                string mes2 = Convert.ToString(cboMes2.Value);
                string anio2 = Convert.ToString(cboAnio2.Value);
                fecha2 = anio2 + "-" + mes2 + "-01";
            }
            else
            {
                cuotas = "";
                fecha2 = "";
            }

            movTarjetaLogic.insertMovimiento(cboFecha.Value.ToString("yyyyMMdd"), txtDetalle.Text, cboTarjeta.Text, cboClaseMov.Text, cboMoneda.Text, txtMonto.Text, cuotas, fecha1, fecha2);

        }

        private void cboCuotas_ValueChanged(object sender, EventArgs e)
        {
            updateUltimaCuota();
            checkEnabled();
        }

        private void cboMes1_ValueChanged(object sender, EventArgs e)
        {
            updateUltimaCuota();
            checkEnabled();
        }

        private void cboAnio1_ValueChanged(object sender, EventArgs e)
        {
            updateUltimaCuota();
            checkEnabled();
        }


        private void checkEnabled()
        {

            if (cboFecha.Text != "" && cboMoneda.Text != "" && cboTarjeta.Text != "" && cboClaseMov.Text != "" && txtDetalle.Text != "" && txtMonto.Text != "")
            {
                btnInsertar.Enabled = true;
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

        private void cboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void cboTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void cboClaseMov_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void txtDetalle_TextChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }
    }
}

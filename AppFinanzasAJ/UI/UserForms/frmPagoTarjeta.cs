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

        private void checkEnabled()
        {
            if (cboTarjeta.Text != string.Empty && cboMesPago.Text != string.Empty && cboFecha.Text != string.Empty && 
                cboCuenta.Text != string.Empty && txtPesos.Text != string.Empty && Convert.ToDecimal(txtGtosTarj.Text) >= 0)
            {
                this.btnInsertar.Enabled = true;
            }
            else
            {
                this.btnInsertar.Enabled = false;
            }
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

            List<Cuenta> listaCuentas = cuentaLogic.GetCuentasPorTipo("Moneda");

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
            checkEnabled();
        }

        

        private void cboMesPago_ValueChanged(object sender, EventArgs e)
        {
            if (cboTarjeta.Text != "" && cboMesPago != null)
            {
                refreshList();
            }
            checkEnabled();
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
                lstErogaciones.Rows.Add(movTarjeta.FECHAMOV.ToString("yyyy/MM/dd"),movTarjeta.TIPOMOV, movTarjeta.DETALLE, movTarjeta.NOMBREMON, movTarjeta.CUOTATEXTO, movTarjeta.MONTOCUOTA, movTarjeta.VALORPESOS, true);
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            checkResto();
            checkEnabled();
        }

        private void radPesos_CheckedChanged(object sender, EventArgs e)
        {
            txtDolar.Enabled = false;
            txtDolar.Text = string.Empty;
            checkEnabled();
        }

        private void radDolar_CheckedChanged(object sender, EventArgs e)
        {
            txtDolar.Enabled = true;
            checkEnabled();
        }

        private void checkResto()
        {
            decimal total = 0;
            if ( txtPesos.Text != "")
            {

                for (int i = 0; i < lstErogaciones.Rows.Count; i++)
                {
                    if (lstErogaciones.Rows[i].Cells[7].Value is true)
                    {
                        total = total + Convert.ToDecimal(lstErogaciones.Rows[i].Cells[6].Value);
                    }                              
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
            checkEnabled();
        }

        private void txtDolar_TextChanged(object sender, EventArgs e)
        {
            checkResto();
            checkEnabled();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtGtosTarj.Text) >= 0)
            {
                MovimientoLogic movimientoLogic = new MovimientoLogic();

                string tipoMovimiento = "Egreso";
                string fechaMovimiento = cboMesPago.Value.ToString("yyyy-MM") + "-01";
                string monedaMovimiento;
                string ctaEgresoMov;
                string claseEgreso;
                string detalleMov;
                string montoMov;
                ctaEgresoMov = cboCuenta.Text;

                CotizacionActivoLogic cotizacionActivoLogic = new CotizacionActivoLogic();
                decimal cotizacion = cotizacionActivoLogic.getCotizDolarPorDia(cboFecha.Value.ToString("yyyy-MM-dd"));



                for (int i = 0; i <= lstErogaciones.Rows.Count -1; i++)
                {
                    if (lstErogaciones.Rows[i].Cells[7].Value is true)
                    {
                        string precioCotiz;

                        if (radDolar.Checked && lstErogaciones.Rows[i].Cells[3].Value.ToString() == "Dolar Estadounidense")
                        {
                            monedaMovimiento = "Dolar Estadounidense";
                            montoMov = lstErogaciones.Rows[i].Cells[5].Value.ToString();
                            precioCotiz = "1";
                        }
                        else
                        {
                            monedaMovimiento = "Peso Argentino";
                            montoMov = lstErogaciones.Rows[i].Cells[6].Value.ToString();
                            precioCotiz = cotizacion.ToString();
                        }


                        claseEgreso = lstErogaciones.Rows[i].Cells[1].Value.ToString();


                        detalleMov = "(Tarjeta | " + lstErogaciones.Rows[i].Cells[4].Value.ToString() + ") " + lstErogaciones.Rows[i].Cells[2].Value.ToString();


                        movimientoLogic.insertMovimientoRegular(tipoMovimiento, fechaMovimiento, monedaMovimiento,
                            "", "", ctaEgresoMov, claseEgreso, detalleMov, montoMov, precioCotiz);

                    }

                }

                // gastos tarjeta

                if (Convert.ToDecimal(txtGtosTarj.Text) != 0)
                {
                    fechaMovimiento = cboFecha.Value.ToString("yyyy-MM-dd");

                    monedaMovimiento = "Peso Argentino";
                    claseEgreso = "Gastos Tarjeta";

                    detalleMov = "Gastos Tarjeta - " + cboTarjeta.Text;
                    montoMov = txtGtosTarj.Text;

                    movimientoLogic.insertMovimientoRegular(tipoMovimiento, fechaMovimiento, monedaMovimiento,
                            "", "", ctaEgresoMov, claseEgreso, detalleMov, montoMov, cotizacion.ToString());
                }
                


                //registrar el pago

                PagoTarjetaLogic pagoTarjetaLogic = new PagoTarjetaLogic();

                pagoTarjetaLogic.insertPago(cboTarjeta.Text, cboMesPago.Value.ToString("yyyy-MM") + "-01");

                MessageBox.Show("Pago registrado");
                Close();
            }
            else
            {
                MessageBox.Show("Debe colocar un monto mayor", "Importante");
            }
        }

        private void cboFecha_ValueChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void cboCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }
    }
}

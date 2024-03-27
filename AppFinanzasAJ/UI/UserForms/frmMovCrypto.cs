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
    public partial class frmMovCrypto : Form
    {
        public frmMovCrypto()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMovCrypto_Load(object sender, EventArgs e)
        {

        }

        private void radIngreso_CheckedChanged(object sender, EventArgs e)
        {
            cboTipoComercio.Items.Clear();
            cboTipoComercio.Text = "";
            cboTipoComercio.Enabled = true;


            cboTipoComercio.Items.Add("Ajuste de Saldos");
            cboTipoComercio.Items.Add("Comercio Fiat/Cripto");
            //cboTipoComercio.Items.Add("Transferencia Bancaria");
            //cboTipoComercio.Items.Add("Trading");

            cboActivoEgreso.Text = "";
            cboActivoIngreso.Text = "";
            cboCtaEgreso.Text = "";
            cboCtaIngreso.Text = "";
            txtCantidadEgreso.Text = "";
            txtCantidadIngreso.Text = "";
            txtCotizacionEgreso.Text = "";
            txtCotizacionIngreso.Text = "";
           
        }

        private void radEgreso_CheckedChanged(object sender, EventArgs e)
        {
            cboTipoComercio.Items.Clear();
            cboTipoComercio.Text = "";
            cboTipoComercio.Enabled = true;

            cboTipoComercio.Items.Add("Ajuste de Saldos");
            cboTipoComercio.Items.Add("Comercio Fiat/Cripto");
            //cboTipoComercio.Items.Add("Transferencia Bancaria");
            //cboTipoComercio.Items.Add("Trading");

            cboActivoEgreso.Text = "";
            cboActivoIngreso.Text = "";
            cboCtaEgreso.Text = "";
            cboCtaIngreso.Text = "";
            txtCantidadEgreso.Text = "";
            txtCantidadIngreso.Text = "";
            txtCotizacionEgreso.Text = "";
            txtCotizacionIngreso.Text = "";
        }

        private void radIntercambio_CheckedChanged(object sender, EventArgs e)
        {
            cboTipoComercio.Items.Clear();
            cboTipoComercio.Text = "";
            cboTipoComercio.Enabled = true;

            //cboTipoComercio.Items.Add("Ajuste de Saldos");
            //cboTipoComercio.Items.Add("Comercio P2P");
            //cboTipoComercio.Items.Add("Transferencia Bancaria");
            cboTipoComercio.Items.Add("Trading");


            cboActivoEgreso.Text = "";
            cboActivoIngreso.Text = "";
            cboCtaEgreso.Text = "";
            cboCtaIngreso.Text = "";
            txtCantidadEgreso.Text = "";
            txtCantidadIngreso.Text = "";
            txtCotizacionEgreso.Text = "";
            txtCotizacionIngreso.Text = "";
        }

        private void cboTipoComercio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboActivoEgreso.Text = "";
            cboActivoIngreso.Text = "";
            cboCtaEgreso.Text = "";
            cboCtaIngreso.Text = "";
            txtCantidadEgreso.Text = "";
            txtCantidadIngreso.Text = "";
            txtCotizacionEgreso.Text = "";
            txtCotizacionIngreso.Text = "";

            if (radIngreso.Checked)
            {
                if (cboTipoComercio.Text == "Ajuste de Saldos")
                {
                    cboActivoEgreso.Items.Clear();
                    cboCtaEgreso.Items.Clear();
                    txtCantidadEgreso.Text = "";
                    txtCotizacionEgreso.Text = "";
                    cboActivoIngreso.Items.Clear();
                    cboCtaIngreso.Items.Clear();
                    txtCantidadIngreso.Text = "";
                    txtCotizacionIngreso.Text = "";

                    cboActivoEgreso.Enabled = false;                    
                    cboCtaEgreso.Enabled = false;
                    txtCantidadEgreso.Enabled = false;
                    txtCotizacionEgreso.Enabled = false;
                    cboActivoIngreso.Enabled = true;
                    cboCtaIngreso.Enabled = true;
                    txtCantidadIngreso.Enabled = true;
                    txtCotizacionIngreso.Enabled = true;


                    cboActivoIngreso.Items.Clear();
                    ActivoLogic activoLogic = new ActivoLogic(); 
                    List<Activo> listaActivos = activoLogic.GetActivos("Criptomoneda");
                    foreach (Activo activo in listaActivos)
                    {
                        cboActivoIngreso.Items.Add(activo.NOMBRE);
                    }

                    cboCtaIngreso.Items.Clear();

                    CuentaLogic cuentaLogic = new CuentaLogic();

                    List<Cuenta> listaCuentas = cuentaLogic.GetCuentasPorTipo("Criptomoneda");
                    foreach (Cuenta cuenta in listaCuentas)
                    {
                        cboCtaIngreso.Items.Add(cuenta.NOMBRE);
                    }

                }
                else if ( cboTipoComercio.Text == "Comercio Fiat/Cripto")
                {
                    cboActivoEgreso.Items.Clear();
                    cboCtaEgreso.Items.Clear();
                    txtCantidadEgreso.Text = "";
                    txtCotizacionEgreso.Text = "";
                    cboActivoIngreso.Items.Clear();
                    cboCtaIngreso.Items.Clear();
                    txtCantidadIngreso.Text = "";
                    txtCotizacionIngreso.Text = "";

                    cboActivoEgreso.Enabled = true;
                    cboCtaEgreso.Enabled = true;
                    txtCantidadEgreso.Enabled = true;
                    txtCotizacionEgreso.Enabled = false;
                    cboActivoIngreso.Enabled = true;
                    cboCtaIngreso.Enabled = true;
                    txtCantidadIngreso.Enabled = true;
                    txtCotizacionIngreso.Enabled = true;


                    cboActivoIngreso.Items.Clear();
                    ActivoLogic activoLogic = new ActivoLogic();

                    List<Activo> listaActivos = activoLogic.GetActivos("Moneda");
                    foreach (Activo activo in listaActivos)
                    {
                        cboActivoEgreso.Items.Add(activo.NOMBRE);
                    }

                    listaActivos = activoLogic.GetActivos("Criptomoneda");
                    foreach (Activo activo in listaActivos)
                    {
                        cboActivoIngreso.Items.Add(activo.NOMBRE);
                    }

                    cboCtaIngreso.Items.Clear();

                    CuentaLogic cuentaLogic = new CuentaLogic();

                    List<Cuenta> listaCuentas = cuentaLogic.GetCuentasPorTipo("Criptomoneda");
                    foreach (Cuenta cuenta in listaCuentas)
                    {
                        cboCtaIngreso.Items.Add(cuenta.NOMBRE);
                    }

                    listaCuentas = cuentaLogic.GetCuentasPorTipo("Moneda");
                    foreach (Cuenta cuenta in listaCuentas)
                    {
                        cboCtaEgreso.Items.Add(cuenta.NOMBRE);
                    }
                }

            }
            else if (radEgreso.Checked)
            {
                if (cboTipoComercio.Text == "Ajuste de Saldos")
                {
                    cboActivoEgreso.Items.Clear();
                    cboCtaEgreso.Items.Clear();
                    txtCantidadEgreso.Text = "";
                    txtCotizacionEgreso.Text = "";
                    cboActivoIngreso.Items.Clear();
                    cboCtaIngreso.Items.Clear();
                    txtCantidadIngreso.Text = "";
                    txtCotizacionIngreso.Text = "";

                    cboActivoEgreso.Enabled = true;
                    cboCtaEgreso.Enabled = true;
                    txtCantidadEgreso.Enabled = true;
                    txtCotizacionEgreso.Enabled = true;
                    cboActivoIngreso.Enabled = false;
                    cboCtaIngreso.Enabled = false;
                    txtCantidadIngreso.Enabled = false;
                    txtCotizacionIngreso.Enabled = false;


                    cboActivoEgreso.Items.Clear();
                    ActivoLogic activoLogic = new ActivoLogic();
                    List<Activo> listaActivos = activoLogic.GetActivos("Criptomoneda");
                    foreach (Activo activo in listaActivos)
                    {
                        cboActivoEgreso.Items.Add(activo.NOMBRE);
                    }

                    cboCtaEgreso.Items.Clear();

                    CuentaLogic cuentaLogic = new CuentaLogic();

                    List<Cuenta> listaCuentas = cuentaLogic.GetCuentasPorTipo("Criptomoneda");
                    foreach (Cuenta cuenta in listaCuentas)
                    {
                        cboCtaEgreso.Items.Add(cuenta.NOMBRE);
                    }
                }
                else if (cboTipoComercio.Text == "Comercio Fiat/Cripto")
                {
                    cboActivoEgreso.Items.Clear();
                    cboCtaEgreso.Items.Clear();
                    txtCantidadEgreso.Text = "";
                    txtCotizacionEgreso.Text = "";
                    cboActivoIngreso.Items.Clear();
                    cboCtaIngreso.Items.Clear();
                    txtCantidadIngreso.Text = "";
                    txtCotizacionIngreso.Text = "";

                    cboActivoEgreso.Enabled = true;
                    cboCtaEgreso.Enabled = true;
                    txtCantidadEgreso.Enabled = true;
                    txtCotizacionEgreso.Enabled = true;
                    cboActivoIngreso.Enabled = true;
                    cboCtaIngreso.Enabled = true;
                    txtCantidadIngreso.Enabled = true;
                    txtCotizacionIngreso.Enabled = false;


                    cboActivoIngreso.Items.Clear();
                    ActivoLogic activoLogic = new ActivoLogic();

                    List<Activo> listaActivos = activoLogic.GetActivos("Moneda");
                    foreach (Activo activo in listaActivos)
                    {
                        cboActivoIngreso.Items.Add(activo.NOMBRE);
                    }
                    cboActivoEgreso.Items.Clear();
                    listaActivos = activoLogic.GetActivos("Criptomoneda");
                    foreach (Activo activo in listaActivos)
                    {
                        cboActivoEgreso.Items.Add(activo.NOMBRE);
                    }

                    cboCtaEgreso.Items.Clear();

                    CuentaLogic cuentaLogic = new CuentaLogic();

                    List<Cuenta> listaCuentas = cuentaLogic.GetCuentasPorTipo("Criptomoneda");
                    foreach (Cuenta cuenta in listaCuentas)
                    {
                        cboCtaEgreso.Items.Add(cuenta.NOMBRE);
                    }

                    cboCtaIngreso.Items.Clear();
                    listaCuentas = cuentaLogic.GetCuentasPorTipo("Moneda");
                    foreach (Cuenta cuenta in listaCuentas)
                    {
                        cboCtaIngreso.Items.Add(cuenta.NOMBRE);
                    }
                }
            }
            else if (radIntercambio.Checked && cboTipoComercio.Text == "Trading")
            {
                cboActivoEgreso.Items.Clear();
                cboCtaEgreso.Items.Clear();
                txtCantidadEgreso.Text = "";
                txtCotizacionEgreso.Text = "";
                cboActivoIngreso.Items.Clear();
                cboCtaIngreso.Items.Clear();
                txtCantidadIngreso.Text = "";
                txtCotizacionIngreso.Text = "";

                cboActivoEgreso.Enabled = true;
                cboCtaEgreso.Enabled = true;
                txtCantidadEgreso.Enabled = true;
                txtCotizacionEgreso.Enabled = true;
                cboActivoIngreso.Enabled = true;
                cboCtaIngreso.Enabled = true;
                txtCantidadIngreso.Enabled = true;
                txtCotizacionIngreso.Enabled = true;


                cboActivoIngreso.Items.Clear();
                cboActivoEgreso.Items.Clear();

                ActivoLogic activoLogic = new ActivoLogic();

                List<Activo> listaActivos = activoLogic.GetActivos("Criptomoneda");
                foreach (Activo activo in listaActivos)
                {
                    cboActivoIngreso.Items.Add(activo.NOMBRE);
                    cboActivoEgreso.Items.Add(activo.NOMBRE);
                }
                    
                cboCtaEgreso.Items.Clear();
                cboCtaIngreso.Items.Clear();

                CuentaLogic cuentaLogic = new CuentaLogic();

                List<Cuenta> listaCuentas = cuentaLogic.GetCuentasPorTipo("Criptomoneda");
                foreach (Cuenta cuenta in listaCuentas)
                {
                    cboCtaEgreso.Items.Add(cuenta.NOMBRE);
                    cboCtaIngreso.Items.Add(cuenta.NOMBRE);
                }                    
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            MovimientoLogic movimientoLogic = new MovimientoLogic();
            if (radIngreso.Checked)
            {
                movimientoLogic.insertMovimientoRegular("Ingreso", cboFecha.Value.ToString("yyyyMMdd"),
                    cboActivoIngreso.Text, cboCtaIngreso.Text, null, null, null, null, txtCantidadIngreso.Text,
                    txtCotizacionIngreso.Text);

                if (cboTipoComercio.Text == "Comercio Fiat/Cripto")
                {
                    movimientoLogic.insertMovimientoRegular("Egreso", cboFecha.Value.ToString("yyyyMMdd"),
                        cboActivoEgreso.Text, null, null, cboCtaEgreso.Text, "Inversion", null, txtCantidadEgreso.Text,
                        "");
                }
            }
            else if (radEgreso.Checked)
            {
                movimientoLogic.insertMovimientoRegular("Egreso", cboFecha.Value.ToString("yyyyMMdd"),
                    cboActivoEgreso.Text, null, null,cboCtaEgreso.Text, null, null, txtCantidadEgreso.Text,
                    txtCotizacionEgreso.Text);

                if (cboTipoComercio.Text == "Comercio Fiat/Cripto")
                {
                    movimientoLogic.insertMovimientoRegular("Ingreso", cboFecha.Value.ToString("yyyyMMdd"),
                        cboActivoIngreso.Text, cboCtaIngreso.Text, "Ingreso Inversiones", null, null, null, txtCantidadIngreso.Text,
                        "");
                }
            }
            else if (radIntercambio.Checked && cboTipoComercio.Text == "Trading")
            {
                movimientoLogic.insertMovimientoRegular("Ingreso", cboFecha.Value.ToString("yyyyMMdd"),
                    cboActivoIngreso.Text, cboCtaIngreso.Text, null, null, null, null, txtCantidadIngreso.Text,
                    txtCotizacionIngreso.Text);

                movimientoLogic.insertMovimientoRegular("Egreso", cboFecha.Value.ToString("yyyyMMdd"),
                    cboActivoEgreso.Text, null, null, cboCtaEgreso.Text, null, null, txtCantidadEgreso.Text,
                    txtCotizacionEgreso.Text);

            }

            MessageBox.Show("Movimiento registrado");

            cboActivoEgreso.Text = "";
            cboCtaEgreso.Text = "";
            txtCantidadEgreso.Text = "";
            txtCotizacionEgreso.Text = "";
            cboActivoIngreso.Text = "";
            cboCtaIngreso.Text = "";
            txtCantidadIngreso.Text = "";
            txtCotizacionIngreso.Text = "";
        }
    }
}

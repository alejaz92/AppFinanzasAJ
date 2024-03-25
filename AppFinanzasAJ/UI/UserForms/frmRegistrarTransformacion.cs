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
    public partial class frmRegistrarTransformacion : Form
    {
        public frmRegistrarTransformacion()
        {
            InitializeComponent();
        }

        private void frmRegistrarTransformacion_Load(object sender, EventArgs e)
        {
            
        }

        private void updateCombosCuenta()
        {
            cboActivoEgreso.Items.Clear();
            cboActivoIngreso.Items.Clear();
            cboCtaEgreso.Items.Clear();
            cboCtaIngreso.Items.Clear();
            
            ActivoLogic activoLogic = new ActivoLogic();
            CuentaLogic cuentaLogic = new CuentaLogic();

            List<Activo> ListaActivos;
            List<Cuenta> ListaCuentas;

            if (radIngreso.Checked && radCrypto.Checked)
            {
                ListaCuentas = cuentaLogic.GetCuentasActivas("Dinero");

                foreach (Cuenta cta in ListaCuentas)
                {
                    cboCtaEgreso.Items.Add(cta.NOMBRE.ToString());
                }

                ListaActivos = activoLogic.GetActivos("Moneda");

                foreach (Activo activo in ListaActivos)
                {
                    cboActivoEgreso.Items.Add(activo.NOMBRE.ToString());  
                }

                ListaCuentas = cuentaLogic.GetCuentas("Crypto");

                foreach (Cuenta cta in ListaCuentas)
                {
                    cboCtaIngreso.Items.Add(cta.NOMBRE.ToString());
                }

                ListaActivos = activoLogic.GetActivos("Criptomoneda");

                foreach (Activo activo in ListaActivos)
                {
                    cboActivoIngreso.Items.Add(activo.NOMBRE.ToString());
                }
                ListaActivos = activoLogic.GetActivos("Moneda");

                foreach (Activo activo in ListaActivos)
                {
                    cboActivoIngreso.Items.Add(activo.NOMBRE.ToString());
                }


            }
            else if(radIngreso.Checked && radBolsa.Checked)
            {
                ListaCuentas = cuentaLogic.GetCuentasActivas("Dinero");

                foreach (Cuenta cta in ListaCuentas)
                {
                    cboCtaEgreso.Items.Add(cta.NOMBRE.ToString());
                }

                ListaActivos = activoLogic.GetActivos("Moneda");

                foreach (Activo activo in ListaActivos)
                {
                    cboActivoEgreso.Items.Add(activo.NOMBRE.ToString());
                }

                ListaCuentas = cuentaLogic.GetCuentas("Broker Bolsa");

                foreach (Cuenta cta in ListaCuentas)
                {
                    cboCtaIngreso.Items.Add(cta.NOMBRE.ToString());
                }

                
                foreach (Activo activo in ListaActivos)
                {
                    cboActivoIngreso.Items.Add(activo.NOMBRE.ToString());
                }
            }
            else if (radEgreso.Checked && radIngreso.Checked)
            {
                ListaCuentas = cuentaLogic.GetCuentas("Dinero");

                foreach (Cuenta cta in ListaCuentas)
                {
                    cboCtaIngreso.Items.Add(cta.NOMBRE.ToString());
                }

                ListaActivos = activoLogic.GetActivos("Moneda");

                foreach (Activo activo in ListaActivos)
                {
                    cboActivoIngreso.Items.Add(activo.NOMBRE.ToString());
                }

                ListaCuentas = cuentaLogic.GetCuentasActivas("Crypto");

                foreach (Cuenta cta in ListaCuentas)
                {
                    cboCtaEgreso.Items.Add(cta.NOMBRE.ToString());
                }

                ListaActivos = activoLogic.GetActivos("Criptomoneda");

                foreach (Activo activo in ListaActivos)
                {
                    cboActivoEgreso.Items.Add(activo.NOMBRE.ToString());
                }
                ListaActivos = activoLogic.GetActivos("Moneda");

                foreach (Activo activo in ListaActivos)
                {
                    cboActivoEgreso.Items.Add(activo.NOMBRE.ToString());
                }
            }
            else if (radEgreso.Checked && radEgreso.Checked)
            {
                ListaCuentas = cuentaLogic.GetCuentas("Dinero");

                foreach (Cuenta cta in ListaCuentas)
                {
                    cboCtaIngreso.Items.Add(cta.NOMBRE.ToString());
                }

                ListaActivos = activoLogic.GetActivos("Moneda");

                foreach (Activo activo in ListaActivos)
                {
                    cboActivoIngreso.Items.Add(activo.NOMBRE.ToString());
                }

                ListaCuentas = cuentaLogic.GetCuentasActivas("Broker Bolsa");

                foreach (Cuenta cta in ListaCuentas)
                {
                    cboCtaEgreso.Items.Add(cta.NOMBRE.ToString());
                }


                foreach (Activo activo in ListaActivos)
                {
                    cboActivoEgreso.Items.Add(activo.NOMBRE.ToString());
                }
            }
        }

        private void radIngreso_CheckedChanged(object sender, EventArgs e)
        {


            if (radBolsa.Checked)
            {
                txtCotizEgr.Enabled = false;
                txtCotizEgr.Text = "";
                txtCotizIng.Enabled = false;
            }
            else
            {
                txtCotizEgr.Enabled = false;
                txtCotizEgr.Text = "";
                txtCotizIng.Enabled = true;
            }
            
            updateCombosCuenta();
            checkEnabled();
        }

        private void radEgreso_CheckedChanged(object sender, EventArgs e)
        {
            if (radBolsa.Checked)
            {
                txtCotizEgr.Enabled = false;
                txtCotizIng.Text = "";
                txtCotizIng.Enabled = false;
            }
            else
            {
                txtCotizEgr.Enabled = true;
                txtCotizIng.Text = "";
                txtCotizIng.Enabled = false;
            }
            
            updateCombosCuenta();
            checkEnabled();
        }

        private void radCrypto_CheckedChanged(object sender, EventArgs e)
        {
            cboActivoIngreso.Enabled = true;
            txtMontoIngreso.Enabled = true;
            if (radEgreso.Checked)
            {
                txtCotizEgr.Enabled = true;
                txtCotizIng.Text = "";
                txtCotizIng.Enabled = false;
            }
            else
            {
                txtCotizEgr.Enabled = false;
                txtCotizEgr.Text = "";
                txtCotizIng.Enabled = true;
            }

            updateCombosCuenta();
            checkEnabled();
        }

        private void radBolsa_CheckedChanged(object sender, EventArgs e)
        {
            txtCotizEgr.Enabled = false;
            txtCotizEgr.Text = "";
            txtCotizIng.Text = "";
            txtCotizIng.Enabled = false;
            cboActivoIngreso.Enabled = false;
            txtMontoIngreso.Enabled = false;    
            updateCombosCuenta();
            checkEnabled();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboCtaEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();                                                                                                                                                                                                                                                                                                                                                  
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (radCrypto.Checked)
            {
                if (radIngreso.Checked)
                {
                    // insertar activos en tabla inversiones y restar activos dinero de fact movimientos

                    MovimientoLogic movimientoLogic = new MovimientoLogic();
                    movimientoLogic.insertMovimientoRegular("Egreso", cboFecha.Value.ToString("yyyyMMdd"),
                        cboActivoEgreso.Text, "", "", cboCtaEgreso.Text, "Inversiones", "Compra de criptomoneda", 
                        txtMontoEgreso.Text);



                    // insertar en tabla inversiones
                    InversionLogic inversionLogic = new InversionLogic();
                    inversionLogic.insertInversion(cboFecha.Value.ToString("yyyyMMdd"), "Ingreso", cboActivoIngreso.Text,
                        cboCtaIngreso.Text, txtMontoIngreso.Text, txtCotizIng.Text);
               



                }
                else
                {
                    // insertar activos en tabla movimientos y restar activos dinero de fact inversiones

                    MovimientoLogic movimientoLogic = new MovimientoLogic();
                    movimientoLogic.insertMovimientoRegular("Egreso", cboFecha.Value.ToString("yyyyMMdd"),
                        cboActivoIngreso.Text,cboCtaIngreso.Text, "Ingreso Inversiones", cboCtaEgreso.Text, "" , "Venta de criptomoneda",
                        txtMontoIngreso.Text);

                    InversionLogic inversionLogic = new InversionLogic();
                    inversionLogic.insertInversion(cboFecha.Value.ToString("yyyyMMdd"), "Egreso", cboActivoEgreso.Text,
                        cboCtaEgreso.Text, txtMontoEgreso.Text, txtCotizEgr.Text);
                }
            }
            else
            {
                string detalle;
                if (radIngreso.Checked)
                {
                    detalle = "Ingreso a Broker de Bolsa";
                }
                else
                {
                    detalle = "Ingreso desde Broker de Bolsa";
                }
                MovimientoLogic movimientoLogic = new MovimientoLogic();
                movimientoLogic.insertMovimientoRegular("Intercambio", cboFecha.Value.ToString("yyyyMMdd"), 
                    cboActivoEgreso.Text, cboCtaIngreso.Text, null, cboCtaEgreso.Text, null, detalle,txtMontoEgreso.Text);
              
            }

            MessageBox.Show("Movimiento registrado");

            Close();
        }

        private void checkEnabled()
        {
            if (radBolsa.Checked)
            {
                if (cboFecha.Text != "" && cboCtaEgreso.Text != "" && cboActivoEgreso.Text != "" && txtMontoEgreso.Text != ""
               && cboCtaIngreso.Text != "" )

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
               if (cboFecha.Text != "" && cboCtaEgreso.Text != "" && cboActivoEgreso.Text != "" && txtMontoEgreso.Text != ""
               && cboCtaIngreso.Text != "" && cboActivoIngreso.Text != "" && (txtMontoIngreso.Text != "" || txtMontoEgreso.Text != "") && (txtCotizEgr.Text != "" ||
               txtCotizIng.Text != ""))

                {
                    btnInsertar.Enabled = true;
                }
                else
                {
                    btnInsertar.Enabled = false;
                }
            }
           
        }

        private void cboFecha_ValueChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void cboActivoEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void txtMontoEgreso_TextChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void cboCtaIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void cboActivoIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void txtMontoIngreso_TextChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void txtCotizEgr_TextChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }
    }
}

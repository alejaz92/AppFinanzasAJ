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

        private void updateCombos()
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
                ListaCuentas = cuentaLogic.GetCuentas("Dinero");

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


            }
            else if(radIngreso.Checked && radBolsa.Checked)
            {
                ListaCuentas = cuentaLogic.GetCuentas("Dinero");

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

                ListaCuentas = cuentaLogic.GetCuentas("Crypto");

                foreach (Cuenta cta in ListaCuentas)
                {
                    cboCtaEgreso.Items.Add(cta.NOMBRE.ToString());
                }

                ListaActivos = activoLogic.GetActivos("Criptomoneda");

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

                ListaCuentas = cuentaLogic.GetCuentas("Broker Bolsa");

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
            updateCombos();
            checkEnabled();
        }

        private void radEgreso_CheckedChanged(object sender, EventArgs e)
        {
            updateCombos();
            checkEnabled();
        }

        private void radCrypto_CheckedChanged(object sender, EventArgs e)
        {
            updateCombos();
            checkEnabled();
        }

        private void radBolsa_CheckedChanged(object sender, EventArgs e)
        {
            updateCombos();
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



                    // FALTA VER COMO INSERTAR EL PRECIO
                    InversionLogic inversionLogic = new InversionLogic();
                    inversionLogic.insertInversion(cboFecha.Value.ToString("yyyyMMdd"), "Ingreso", cboActivoIngreso.Text,
                        cboCtaIngreso.Text, txtMontoIngreso.Text, "poner precio");
               



                }
                else
                {
                    // insertar activos en tabla movimientos y restar activos dinero de fact inversiones

                    MovimientoLogic movimientoLogic = new MovimientoLogic();
                    movimientoLogic.insertMovimientoRegular("Ingreso", cboFecha.Value.ToString("yyyyMMdd"),
                        cboActivoIngreso.Text,cboCtaIngreso.Text, , cboCtaEgreso.Text, "Inversiones", "Compra de criptomoneda",
                        txtMontoEgreso.Text);
                }
            }
            else
            {
                if (radIngreso.Checked)
                {
                    //hacer interacambio de acticvos hacia la cuenta del broker
                }
                else
                {
                    //hacer intercambio de activos desde la cuenta del broker
                }
            }
        }

        private void checkEnabled()
        {
            if (cboFecha.Text != "" && cboCtaEgreso.Text != "" && cboActivoEgreso.Text != "" && txtMontoEgreso.Text != ""
                && cboCtaIngreso.Text != "" && cboActivoIngreso.Text != "" && txtMontoIngreso.Text != "")
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
    }
}

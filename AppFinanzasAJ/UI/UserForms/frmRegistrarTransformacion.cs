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
        }

        private void radEgreso_CheckedChanged(object sender, EventArgs e)
        {
            updateCombos();
        }

        private void radCrypto_CheckedChanged(object sender, EventArgs e)
        {
            updateCombos();
        }

        private void radBolsa_CheckedChanged(object sender, EventArgs e)
        {
            updateCombos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboCtaEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
                                                                                                                                                                                                                                                                                                                                                                 
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

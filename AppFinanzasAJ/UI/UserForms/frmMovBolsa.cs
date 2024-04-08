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
    public partial class frmMovBolsa : Form
    {
        public frmMovBolsa()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radIngreso_CheckedChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }        

        private void radEgreso_CheckedChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void cboTipoComercio_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void frmMovBolsa_Load(object sender, EventArgs e)
        {
            cboTipoComercio.Items.Clear();
            cboTipoComercio.Text = "";
            cboTipoComercio.Enabled = true;

            cboTipoComercio.Items.Add("Ajuste de Saldos");
            cboTipoComercio.Items.Add("General");

            cboActivoEgreso.Text = "";
            cboActivoIngreso.Text = "";
            cboCtaEgreso.Text = "";
            cboCtaIngreso.Text = "";
            txtCantidadEgreso.Text = "";
            txtCantidadIngreso.Text = "";
            txtCotizacionEgreso.Text = "";
            txtCotizacionIngreso.Text = "";


            cboTipoActivo.Items.Add("Accion Argentina");
            cboTipoActivo.Items.Add("Bonos");
            cboTipoActivo.Items.Add("CEDEAR");
            cboTipoActivo.Items.Add("FCI");

        }

        private void checkEnabled()
        {
            if (cboTipoActivo.Text != "")
            {
                cboActivoEgreso.Items.Clear();
                cboActivoIngreso.Items.Clear();
                cboCtaEgreso.Items.Clear();
                cboCtaIngreso.Items.Clear();

                ActivoLogic activoLogic = new ActivoLogic();
                List<Activo> ListaActivosBolsa = activoLogic.GetActivos(cboTipoActivo.Text);

                CuentaLogic cuentaLogic = new CuentaLogic();
                List<Cuenta> ListaCuentasBolsa = cuentaLogic.GetCuentasPorTipo(cboTipoActivo.Text);

                if (radIngreso.Checked)
                {
                    foreach (Activo activo in ListaActivosBolsa)
                    {
                        cboActivoIngreso.Items.Add(activo.NOMBRE);
                    }

                    foreach (Cuenta cuenta in ListaCuentasBolsa)
                    {
                        cboCtaIngreso.Items.Add(cuenta.NOMBRE);
                    }

                    if (cboTipoComercio.Text == "Ajuste de Saldos")
                    {
                        cboActivoEgreso.Enabled = false;
                        cboCtaEgreso.Enabled = false;
                        txtCantidadEgreso.Enabled = false;
                        txtCotizacionEgreso.Enabled = false;

                        cboActivoIngreso.Enabled = true;
                        cboCtaIngreso.Enabled = true;
                        txtCantidadIngreso.Enabled = true;
                        txtCotizacionIngreso.Enabled = true;


                        cboActivoEgreso.Text = "";
                        cboCtaEgreso.Text = "";
                        txtCantidadEgreso.Text = "";
                        txtCotizacionEgreso.Text = "";

                        cboActivoIngreso.Text = "";
                        cboCtaIngreso.Text = "";
                        txtCantidadIngreso.Text = "";
                        txtCotizacionIngreso.Text = "";




                    }
                    else if (cboTipoComercio.Text == "General")
                    {
                        cboActivoEgreso.Enabled = true;
                        cboCtaEgreso.Enabled = true;
                        txtCantidadEgreso.Enabled = true;
                        txtCotizacionEgreso.Enabled = true;

                        cboActivoIngreso.Enabled = true;
                        cboCtaIngreso.Enabled = true;
                        txtCantidadIngreso.Enabled = true;
                        txtCotizacionIngreso.Enabled = true;


                        cboActivoEgreso.Text = "";
                        cboCtaEgreso.Text = "";
                        txtCantidadEgreso.Text = "";
                        txtCotizacionEgreso.Text = "";

                        cboActivoIngreso.Text = "";
                        cboCtaIngreso.Text = "";
                        txtCantidadIngreso.Text = "";
                        txtCotizacionIngreso.Text = "";

                        List<Activo> ListaActivosFIAT = activoLogic.GetActivos("Moneda");

                        foreach (Activo activo in ListaActivosFIAT)
                        {
                            cboActivoEgreso.Items.Add(activo.NOMBRE);
                        }

                        foreach (Cuenta cuenta in ListaCuentasBolsa)
                        {
                            cboCtaEgreso.Items.Add(cuenta.NOMBRE);
                        }
                    }
                    else
                    {
                        cboActivoEgreso.Enabled = false;
                        cboCtaEgreso.Enabled = false;
                        txtCantidadEgreso.Enabled = false;
                        txtCotizacionEgreso.Enabled = false;

                        cboActivoIngreso.Enabled = false;
                        cboCtaIngreso.Enabled = false;
                        txtCantidadIngreso.Enabled = false;
                        txtCotizacionIngreso.Enabled = false;


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
                else if (radEgreso.Checked)
                {

                    foreach (Activo activo in ListaActivosBolsa)
                    {
                        cboActivoEgreso.Items.Add(activo.NOMBRE);
                    }

                    foreach (Cuenta cuenta in ListaCuentasBolsa)
                    {
                        cboCtaEgreso.Items.Add(cuenta.NOMBRE);
                    }

                    if (cboTipoComercio.Text == "Ajuste de Saldos")
                    {
                        cboActivoEgreso.Enabled = true;
                        cboCtaEgreso.Enabled = true;
                        txtCantidadEgreso.Enabled = true;
                        txtCotizacionEgreso.Enabled = true;

                        cboActivoIngreso.Enabled = false;
                        cboCtaIngreso.Enabled = false;
                        txtCantidadIngreso.Enabled = false;
                        txtCotizacionIngreso.Enabled = false;


                        cboActivoEgreso.Text = "";
                        cboCtaEgreso.Text = "";
                        txtCantidadEgreso.Text = "";
                        txtCotizacionEgreso.Text = "";

                        cboActivoIngreso.Text = "";
                        cboCtaIngreso.Text = "";
                        txtCantidadIngreso.Text = "";
                        txtCotizacionIngreso.Text = "";


                    }
                    else if (cboTipoComercio.Text == "General")
                    {
                        cboActivoEgreso.Enabled = true;
                        cboCtaEgreso.Enabled = true;
                        txtCantidadEgreso.Enabled = true;
                        txtCotizacionEgreso.Enabled = true;

                        cboActivoIngreso.Enabled = true;
                        cboCtaIngreso.Enabled = true;
                        txtCantidadIngreso.Enabled = true;
                        txtCotizacionIngreso.Enabled = true;


                        cboActivoEgreso.Text = "";
                        cboCtaEgreso.Text = "";
                        txtCantidadEgreso.Text = "";
                        txtCotizacionEgreso.Text = "";

                        cboActivoIngreso.Text = "";
                        cboCtaIngreso.Text = "";
                        txtCantidadIngreso.Text = "";
                        txtCotizacionIngreso.Text = "";


                        List<Activo> ListaActivosFIAT = activoLogic.GetActivos("Moneda");

                        foreach (Activo activo in ListaActivosFIAT)
                        {
                            cboActivoIngreso.Items.Add(activo.NOMBRE);
                        }

                        foreach (Cuenta cuenta in ListaCuentasBolsa)
                        {
                            cboCtaIngreso.Items.Add(cuenta.NOMBRE);
                        }

                    }
                    else
                    {
                        cboActivoEgreso.Enabled = false;
                        cboCtaEgreso.Enabled = false;
                        txtCantidadEgreso.Enabled = false;
                        txtCotizacionEgreso.Enabled = false;

                        cboActivoIngreso.Enabled = false;
                        cboCtaIngreso.Enabled = false;
                        txtCantidadIngreso.Enabled = false;
                        txtCotizacionIngreso.Enabled = false;


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
        }

        private void cboTipoActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEnabled();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            MovimientoLogic movimientoLogic = new MovimientoLogic();
            if (radIngreso.Checked)
            {
                string cotiz = Convert.ToString(1 / Convert.ToDecimal(txtCotizacionIngreso.Text));

                movimientoLogic.insertMovimientoRegular("Ingreso", cboFecha.Value.ToString("yyyyMMdd"),
                    cboActivoIngreso.Text, cboCtaIngreso.Text, null, null, null, null, txtCantidadIngreso.Text,
                    cotiz);

                if (cboTipoComercio.Text == "General")
                {
                    movimientoLogic.insertMovimientoRegular("Egreso", cboFecha.Value.ToString("yyyyMMdd"),
                        cboActivoEgreso.Text, null, null, cboCtaEgreso.Text, "Inversion", null, txtCantidadEgreso.Text,
                        "");
                }
            }
            else if (radEgreso.Checked)
            {
                string cotiz = Convert.ToString(1 / Convert.ToDecimal(txtCotizacionEgreso.Text));

                movimientoLogic.insertMovimientoRegular("Egreso", cboFecha.Value.ToString("yyyyMMdd"),
                    cboActivoEgreso.Text, null, null, cboCtaEgreso.Text, null, null, txtCantidadEgreso.Text,
                    cotiz);

                if (cboTipoComercio.Text == "General")
                {
                    movimientoLogic.insertMovimientoRegular("Ingreso", cboFecha.Value.ToString("yyyyMMdd"),
                        cboActivoIngreso.Text, cboCtaIngreso.Text, "Ingreso Inversiones", null, null, null, 
                        txtCantidadIngreso.Text, "");
                }
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

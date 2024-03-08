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

        }
    }
}

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
    public partial class frmAdminTarjetas : Form
    {
        public frmAdminTarjetas()
        {
            InitializeComponent();
        }

        private void frmAdminTarjetas_Load(object sender, EventArgs e)
        {
            TarjetaLogic tarjetaLogic = new TarjetaLogic();
            List<Tarjeta> listaTarjetas = tarjetaLogic.GetTarjetas();

            foreach(var tarj in listaTarjetas)
            {
                lstTarjetas.Items.Add(tarj.NOMBRE);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtAgregar.Text.Length != 0)
            {
                TarjetaLogic tarjetaLogic = new TarjetaLogic();

                tarjetaLogic.insertTarjeta(txtAgregar.Text);

                lstTarjetas.Items.Add(txtAgregar.Text);

                txtAgregar.Text = "";
            }
            else
            {
                MessageBox.Show("Debe colocar un nombre de tarjeta para insertar", "Importante");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAgregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreVar = lstTarjetas.Text;



            if (nombreVar.Length != 0)
            {
                TarjetaLogic tarjetaLogic = new TarjetaLogic();

                tarjetaLogic.deleteTarjeta(nombreVar);


                lstTarjetas.Items.Remove(nombreVar);
            }
        }
    }
}

using AppFinanzasAJ.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace AppFinanzasAJ.UI.UserForms
{
    public partial class frmAdminMonedas : Form
    {
        public static string nombreEdit;
        public frmAdminMonedas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAdminMonedas_Load(object sender, EventArgs e)
        {
            reloadList();
        }

     
        private void btnEditar_Click(object sender, EventArgs e)
        {
            

            if (lstMonedas.Text.Length != 0)
            {

                nombreEdit = lstMonedas.Text;

                frmEditMoneda frmEM = new frmEditMoneda(this);
                frmEM.ShowDialog();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            frmEditMoneda frmEM = new frmEditMoneda(this);

            nombreEdit = "";

            frmEM.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreVar = lstMonedas.Text;



            if (nombreVar.Length != 0)
            {
                MonedaLogic monedaLogic = new MonedaLogic();


                monedaLogic.deleteMoneda(nombreVar);


                lstMonedas.Items.Remove(nombreVar);
            }
            else
            {
                MessageBox.Show("Debe colocar un nombre de cuenta para insertar", "Importante");
            }
        }

        public void reloadList()
        {

            lstMonedas.Items.Clear();
            MonedaLogic monedalogic = new MonedaLogic();

            List<Moneda> listaMonedas = monedalogic.GetMonedas();

            foreach (var moneda in listaMonedas)
            {
                lstMonedas.Items.Add(moneda.NOMBRE);
            }
        }

    }
}

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
    public partial class frmAdminActivos : Form
    {
        public  string nombreEdit;
        public string tipoAct;
        public frmAdminActivos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAdminActivos_Load(object sender, EventArgs e)
        {

            //reloadList();

            cboTipoAct.Items.Clear();
            TipoActivoLogic tipoActivologic = new TipoActivoLogic();

            List<TipoActivo> listaTiposActivo = tipoActivologic.GetTiposActivo();

            foreach (var tipoActivo in listaTiposActivo)
            {
                cboTipoAct.Items.Add(tipoActivo.NOMBRE);
            }

            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnMonedaPrincipal.Enabled = false;
            btnMonedaRef.Enabled = false;
            btnEliminar.Enabled = false;
        }

     
        private void btnEditar_Click(object sender, EventArgs e)
        {
            

            if (lstActivos.Text.Length != 0)
            {

                nombreEdit = lstActivos.Text;
                tipoAct = cboTipoAct.Text;

                frmEditActivo frmEM = new frmEditActivo(this, nombreEdit);
                frmEM.ShowDialog();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nombreEdit = "";
            tipoAct = cboTipoAct.Text;
            frmEditActivo frmEM = new frmEditActivo(this, nombreEdit);

           

            frmEM.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreVar = lstActivos.Text;



            if (nombreVar.Length != 0)
            {
                ActivoLogic activoLogic = new ActivoLogic();


                activoLogic.deleteActivo(nombreVar);


                lstActivos.Items.Remove(nombreVar);
            }
            else
            {
                MessageBox.Show("Debe colocar un nombre de cuenta para insertar", "Importante");
            }
        }

        public void reloadList()
        {

            lstActivos.Items.Clear();
            ActivoLogic activologic = new ActivoLogic();

            List<Activo> listaActivos = activologic.GetActivos(cboTipoAct.Text);

            foreach (var activo in listaActivos)
            {
                lstActivos.Items.Add(activo.NOMBRE);
            }
        }


        private void btnMonedaPrincipal_Click(object sender, EventArgs e)
        {
            frmMonedaPrincipal frmMP = new frmMonedaPrincipal();
            frmMP.Show();
        }

        private void btnMonedaRef_Click(object sender, EventArgs e)
        {
            frmMonedaRef frmActivoRef = new frmMonedaRef();
            frmActivoRef.Show();
        }

        private void cboTipoAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;

            if (cboTipoAct.Text == "Moneda")
            {
                btnMonedaRef.Enabled = true;
                btnMonedaPrincipal.Enabled = true;
            }
            else
            {
                btnMonedaRef.Enabled = false;  
                btnMonedaPrincipal.Enabled = false;
            }
            reloadList();
        }
    }
}

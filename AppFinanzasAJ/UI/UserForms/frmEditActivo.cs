using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppFinanzasAJ.Negocio;
using AppFinanzasAJ.UI.UserForms;

namespace AppFinanzasAJ.UI.UserForms
{
    public partial class frmEditActivo : Form
    {
        public bool esAgregar;
        frmAdminActivos frmAM;
        public string nombreEdit;

        public int activoID; 
        public frmEditActivo(frmAdminActivos f, string nEdit)
        {
            InitializeComponent();
            frmAM = f;
            nombreEdit = nEdit;
        }


        private void frmEditActivo_Load(object sender, EventArgs e)
        {
            if (nombreEdit == "")
            {
                esAgregar = true;
                
             

            }
            else
            {
                esAgregar = false;

                ActivoLogic activologic = new ActivoLogic();
                List<Activo> listaActivosEdit = activologic.GetActivosEdit(nombreEdit);



                foreach (var activo in listaActivosEdit)
                {

                    txtNombre.Text = activo.NOMBRE;
                    txtSimbolo.Text = activo.SIMBOLO;
                    activoID = activo.IDACTIVO;


                }


            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(esAgregar == true)
            {
                //insertar activo

                ActivoLogic activoLogic = new ActivoLogic();


               activoLogic.insertActivo(txtNombre.Text, txtSimbolo.Text, frmAM.tipoAct);
       


                frmAM.reloadList();


                this.Close();
                
                
            }
            else
            {
                //actualizar activo
                ActivoLogic activoLogic = new ActivoLogic();


                activoLogic.updateActivo(activoID,txtNombre.Text, txtSimbolo.Text);


                frmAM.reloadList();


                this.Close();

            }
        }
    }
}

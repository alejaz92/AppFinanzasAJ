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

namespace AppFinanzasAJ.UI.UserForms
{
    public partial class frmAdminClaseMovimiento : Form
    {
        public frmAdminClaseMovimiento()
        {
            InitializeComponent();
        }

        private void frmAdminClaseMovimiento_Load(object sender, EventArgs e)
        {
            lstIngresos.Items.Clear();
            lstEgresos.Items.Clear();

            ClaseMovimientoLogic claseMovimientoLogic = new ClaseMovimientoLogic();

            List<ClaseMovimiento> listaClasesMovmiento = claseMovimientoLogic.GetClasesMovimiento();

            foreach (var claseMovimiento in listaClasesMovmiento)
            {
                if (claseMovimiento.INGEGR == "Ingreso")
                {
                    lstIngresos.Items.Add(claseMovimiento.DESCRIPCION);
                }
                else
                {
                    lstEgresos.Items.Add(claseMovimiento.DESCRIPCION);
                }

            }
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarIngreso_Click(object sender, EventArgs e)
        {
            if (txtAgregarIngreso.Text.Length != 0)
            {
                

                ClaseMovimientoLogic claseMovimientoLogic = new ClaseMovimientoLogic();

                claseMovimientoLogic.insertClaseMovimiento (txtAgregarIngreso.Text, "Ingreso");

                lstIngresos.Items.Add(txtAgregarIngreso.Text);

                txtAgregarIngreso.Text = "";
            }
            else
            {
                MessageBox.Show("Debe colocar una descripcion de clase movimiento de ingreso para insertar", "Importante");
            }
        }

        private void brnAgregarEgreso_Click(object sender, EventArgs e)
        {
            if (txtAgregarEgreso.Text.Length != 0)
            {


                ClaseMovimientoLogic claseMovimientoLogic = new ClaseMovimientoLogic();

                claseMovimientoLogic.insertClaseMovimiento(txtAgregarEgreso.Text, "Egreso");

                lstEgresos.Items.Add(txtAgregarEgreso.Text);

                txtAgregarEgreso.Text = "";
            }
            else
            {
                MessageBox.Show("Debe colocar una descripcion de clase movimiento de egreso para insertar", "Importante");
            }
        }

        private void btnEliminarIngreso_Click(object sender, EventArgs e)
        {
            string nombreVar = lstIngresos.Text;



            if (nombreVar.Length != 0)
            {
                ClaseMovimientoLogic claseMovimientoLogic = new ClaseMovimientoLogic();


                claseMovimientoLogic.deleteClaseMovimiento(nombreVar, "Ingreso");


                lstIngresos.Items.Remove(nombreVar);
            }

        }

        private void btnEliminarEgreso_Click(object sender, EventArgs e)
        {
            string nombreVar = lstEgresos.Text;



            if (nombreVar.Length != 0)
            {
                ClaseMovimientoLogic claseMovimientoLogic = new ClaseMovimientoLogic();


                claseMovimientoLogic.deleteClaseMovimiento(nombreVar, "Egreso");


                lstEgresos.Items.Remove(nombreVar);
            }
        }
    }
}

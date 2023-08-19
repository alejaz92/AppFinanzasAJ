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
    public partial class frmEditMoneda : Form
    {
        public bool esAgregar;
        frmAdminMonedas frmAM;
        public string nombreEdit;

        public int monedaID; 
        public frmEditMoneda(frmAdminMonedas f, string nEdit)
        {
            InitializeComponent();
            frmAM = f;
            nombreEdit = nEdit;
        }


        private void frmEditMoneda_Load(object sender, EventArgs e)
        {
            if (nombreEdit == "")
            {
                esAgregar = true;
                
             

            }
            else
            {
                esAgregar = false;

                MonedaLogic monedalogic = new MonedaLogic();
                List<Moneda> listaMonedasEdit = monedalogic.GetMonedasEdit(nombreEdit);


                
                foreach (var moneda in listaMonedasEdit)
                {
                    
                    txtNombre.Text = moneda.NOMBRE;
                    txtSimbolo.Text = moneda.SIMBOLO;
                    monedaID = moneda.IDMONEDA;


                    if (moneda.ESFIAT == true)
                    {
                        radFIAT.Checked = true; 
                    }
                    else
                    {
                        radCripto.Checked = true;
                    }
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
                //insertar moneda

                MonedaLogic monedaLogic = new MonedaLogic();

                if(radFIAT.Checked == true)
                {
                    monedaLogic.insertMoneda(txtNombre.Text, txtSimbolo.Text, true);
                }
                else
                {
                    monedaLogic.insertMoneda(txtNombre.Text, txtSimbolo.Text, false);
                }


                frmAM.reloadList();


                this.Close();
                
                
            }
            else
            {
                //actualizar moneda
                MonedaLogic monedaLogic = new MonedaLogic();

                if (radFIAT.Checked == true)
                {
                    monedaLogic.updateMoneda(monedaID,txtNombre.Text, txtSimbolo.Text, true);
                }
                else
                {
                    monedaLogic.updateMoneda(monedaID,txtNombre.Text, txtSimbolo.Text, false);
                }


                frmAM.reloadList();


                this.Close();

            }
        }
    }
}

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
    public partial class frmGestTarjeta : Form
    {

        
        public frmGestTarjeta()
        {
            InitializeComponent();
        }

        private void btnPagoTarjeta_Click(object sender, EventArgs e)
        {
            frmPagoTarjeta frmPag = new frmPagoTarjeta();
            frmPag.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmRegistrarMovTarjeta frmRegistrarMovTarjeta = new frmRegistrarMovTarjeta();
            frmRegistrarMovTarjeta.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void loadTabla()
        {
            MovTarjetaLogic movTarjetaLogic = new MovTarjetaLogic();
            List<MovTarjeta> ListaMoveTarjeta = movTarjetaLogic.getMovsTarjetaGrid();

            dgLista.Rows.Clear();

            foreach (MovTarjeta mov in ListaMoveTarjeta)
            {
                dgLista.Rows.Add(mov.FECHAMOV.ToString("yyyy/MM/dd"), mov.NOMBRETARJ, mov.TIPOMOV, mov.DETALLE, mov.CUOTATEXTO, mov.NOMBREMON, mov.MONTOTOTAL, mov.MESPRIMERCUOTA.ToString("yyyy-MM"), mov.ULTCUOTATEXTO.ToString(), mov.MONTOCUOTA);
            }

        }

        private void frmGestTarjeta_Activated(object sender, EventArgs e)
        {
            loadTabla();
        }


        private void btnRecurrente_Click(object sender, EventArgs e)
        {


            int dgRow = dgLista.CurrentRow.Index;

            if (dgLista.Rows[dgRow].Cells[4].Value.ToString() == "Recurrente")
            {
                string fecha = dgLista.Rows[dgRow].Cells[0].Value.ToString();
                string detalle = dgLista.Rows[dgRow].Cells[3].Value.ToString();
                string monto = dgLista.Rows[dgRow].Cells[6].Value.ToString();
                string tarjeta = dgLista.Rows[dgRow].Cells[1].Value.ToString();


                frmRecurrente frmR = new frmRecurrente(this, fecha, detalle, monto, tarjeta);
                frmR.ShowDialog();
            }
            
        }

        private void frmGestTarjeta_Load(object sender, EventArgs e)
        {

        }
    }
}

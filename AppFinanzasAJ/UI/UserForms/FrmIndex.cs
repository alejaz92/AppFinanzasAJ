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
using AppFinanzasAJ.UI.UserForms;
using System.Threading;

namespace AppFinanzasAJ
{
    public partial class FrmIndex : Form
    {


        public FrmIndex()
        {
            InitializeComponent();
        }



        private void btnCuentas_Click(object sender, EventArgs e)
        {
            frmAdminCuentas frmAC = new frmAdminCuentas();

            frmAC.ShowDialog();
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            frmAdminActivos frmAM = new frmAdminActivos();

            frmAM.ShowDialog();
        }

        private void loadTabla ()
        {
            MovimientoLogic movimientoLogic = new MovimientoLogic();

            List<Movimiento> listaMovimientos = movimientoLogic.getTopMovimientos();

            dgUltMovs.Rows.Clear();

            foreach (Movimiento mov in listaMovimientos)
            {
                dgUltMovs.Rows.Add(mov.FECHA.ToString("yyyy/MM/dd"), mov.TIPOMOVIMIENTO,mov.CLASEMOVTEXT, mov.COMENTARIO, mov.CUENTATEXT, mov.MONEDATEXT, mov.MONTO);
            }

        }
               

        private void FrmIndex_Load(object sender, EventArgs e)
        {

            ActivoLogic activo = new ActivoLogic();
            List<Activo> listaActivos = activo.GetPares();

            CotizacionActivoLogic cotizacionActivoLogic = new CotizacionActivoLogic();

            bool yaActualizado = cotizacionActivoLogic.checkCotizacionDiaria();

            if (yaActualizado == false)
            {
                int maximo = listaActivos.Count;
                frmProgress frmProgress = new frmProgress(maximo);
                Thread thread = new Thread(() => updateCotiz(listaActivos, frmProgress));
                thread.Start();
                
                frmProgress.ShowDialog();
            }
        }


        private void updateCotiz(List<Activo> listaActivos, frmProgress frm)
        {

            Activo mon1 = listaActivos.First();

            int contCotiz = 0;
            int progresoInd = 1;
            int progresoTotal = 0;

            CotizacionActivoLogic cotizacionActivoLogic = new CotizacionActivoLogic();
            foreach (Activo mon2 in listaActivos)
            {
                contCotiz = cotizacionActivoLogic.updateCotizacionesGral(mon1, mon2, contCotiz);
                progresoTotal = progresoTotal + progresoInd;

                OnProgressChanged(progresoTotal);
            }

            if (frm != null && !frm.IsDisposed)
            {
                frm.Invoke(new Action(() => frm.Close()));
            }
        }

        public delegate void ProgressChangedEventHandler(int progress);
        public event ProgressChangedEventHandler ProgressChanged;
        protected virtual void OnProgressChanged(int progress)
        {
            ProgressChanged?.Invoke(progress);
        }

        private void btnClaseMovimiento_Click(object sender, EventArgs e)
        {
            frmAdminClaseMovimiento frmCM = new frmAdminClaseMovimiento();
            frmCM.ShowDialog();
        }

        private void btnRegMovimiento_Click(object sender, EventArgs e)
        {
            frmRegistrarMovimiento frmRM = new frmRegistrarMovimiento();
            frmRM.ShowDialog();
        }



        private void btnAjustesBSantaFe_Click(object sender, EventArgs e)
        {
            frmParamsBSF frm = new frmParamsBSF();
            frm.ShowDialog();
        }

        private void btnRegMovimientoBSF_Click(object sender, EventArgs e)
        {
            frmRegistrarMovBSF frmRM = new frmRegistrarMovBSF();
            frmRM.ShowDialog();
        }

        private void btnTarjetas_Click(object sender, EventArgs e)
        {
            frmAdminTarjetas frmAdminTarjetas = new frmAdminTarjetas();
            frmAdminTarjetas.ShowDialog();
        }

        private void btnMovTarjeta_Click(object sender, EventArgs e)
        {


            frmGestTarjeta frmGestTarjeta = new frmGestTarjeta();
            frmGestTarjeta.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void FrmIndex_Activated(object sender, EventArgs e)
        {
            loadTabla();
        }

        private void btnSaldos_Click(object sender, EventArgs e)
        {
            frmSaldosGeneral frmSaldosGeneral = new frmSaldosGeneral();
            frmSaldosGeneral.ShowDialog();
        }

        private void btnInversiones_Click(object sender, EventArgs e)
        {
            frmAdminInversiones frmAInv = new frmAdminInversiones();
            frmAInv.ShowDialog();
        }

        private void btnCuentasActivos_Click(object sender, EventArgs e)
        {
            frmCuentaTipoActivo frmCuentaTipoActivo = new frmCuentaTipoActivo();
            frmCuentaTipoActivo.ShowDialog();
        }

        private void btnPBI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://app.powerbi.com/groups/me/reports/4c15ebf5-24c0-494c-9684-272cb1013d11/ReportSection");
        }
    }
}

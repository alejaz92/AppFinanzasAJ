using AppFinanzasAJ.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFinanzasAJ.UI.UserForms
{
    public partial class frmProgress : Form
    {
        public int maximo;
        public frmProgress(int max)
        {
            InitializeComponent();
            maximo = max;

            FrmIndex frmIndex = (FrmIndex)Application.OpenForms["FrmIndex"];
            if (frmIndex != null )
            {
                frmIndex.ProgressChanged += FrmIndex_ProgressChanged;
            }



        }

        private void FrmIndex_ProgressChanged(int progress)
        {
            if (prgCotiz.InvokeRequired)
            {
                prgCotiz.Invoke(new MethodInvoker(delegate { prgCotiz.Value = progress; }));
            }
            else
            {
                prgCotiz.Value = progress;
            }

            
        }

        private void frmProgress_Load(object sender, EventArgs e)
        {
            prgCotiz.Maximum = maximo;
        }


    }
}

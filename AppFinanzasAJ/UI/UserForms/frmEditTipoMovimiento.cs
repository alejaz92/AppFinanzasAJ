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
    public partial class frmEditTipoMovimiento : Form
    {

        public string descripcionEdit;
        public frmEditTipoMovimiento(string dEdit)
        {
            InitializeComponent();
            descripcionEdit = dEdit;
        }

        private void frmEditTipoMovimiento_Load(object sender, EventArgs e)
        {

        }
    }
}

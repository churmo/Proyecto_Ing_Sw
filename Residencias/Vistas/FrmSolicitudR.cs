using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residencias.Vistas
{
    public partial class FrmSolicitudR : Form
    {
        Form x;
        int ac = 0;
        public FrmSolicitudR(Form c)
        {
            InitializeComponent();
            x = c;
        }

        private void FrmSolicitudR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
            {
                this.Dispose();
                x.Visible = true;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}

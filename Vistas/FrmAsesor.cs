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
    public partial class FrmAsesor : Form
    {
        Form x;
        public FrmAsesor(Form c)
        {
            InitializeComponent();
            x = c;
        }

        private void BtnCalificaciones_Click(object sender, EventArgs e)
        {
            new FrmAsignarCalificacion(this).Show();
        }

        private void FrmAsesor_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}

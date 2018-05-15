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
    public partial class FrmAsignarRevisores : Form
    {
        Form x;
        public FrmAsignarRevisores(Form c)
        {
            InitializeComponent();
            x = c;
        }

        private void btNAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            x.Visible = true;
        }

        private void FrmAsignarRevisores_FormClosing(object sender, FormClosingEventArgs e)
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

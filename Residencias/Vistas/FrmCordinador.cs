using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Residencias.Vistas;

namespace Residencias.Vistas
{
    public partial class FrmCordinador : Form
    {
        Form x;
        public FrmCordinador(Form c)
        {
            InitializeComponent();
            x = c;
        }

        private void BtnAT_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FrmAsigAsesor(this).Show();
        }

        private void BtnAR_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            x.Visible = true;
        }

        private void FrmCordinador_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BtnResidente_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FrmSolicitudR(this).Show();
        }
    }
}

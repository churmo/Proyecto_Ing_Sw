using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Residencias.FrontEnd;
using Residencias.BackEnd;

namespace Residencias.Vistas
{
    public partial class FrmSolicitudR : Form
    {
        Form x;
        ResidenteDAO RD = new ResidenteDAO();
        Residente R = new Residente();
        int ac = 0;
        public FrmSolicitudR(Form c)
        {
            InitializeComponent();
            x = c;
        }
        public void lista()
        {

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

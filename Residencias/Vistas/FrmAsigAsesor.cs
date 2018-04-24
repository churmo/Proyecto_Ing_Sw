using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Residencias.BackEnd;
using Residencias.FrontEnd;

namespace Residencias
{
    public partial class FrmAsigAsesor : Form
    {
        Form x;
        public FrmAsigAsesor(Form c)
        {
            InitializeComponent();
            x = c;
            
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            x.Visible = true;
        }
        private void FrmAsigAsesor_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                if(MessageBox.Show("Seguro que desea salir?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    ==DialogResult.Yes)
                {
                    this.Dispose();
                    x.Visible = true;
            }else
            {
                e.Cancel = true;
            }
            
        }
    }
}

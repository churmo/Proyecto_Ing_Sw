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
    public partial class FrmEntregaDeDocuments : Form
    {
        Form x;
        public FrmEntregaDeDocuments(Form c)
        {
            InitializeComponent();
            x = c;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

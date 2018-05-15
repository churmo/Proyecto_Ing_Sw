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

namespace Residencias.Vistas
{
    public partial class FrmResidente : Form
    {
        Form x;
        public FrmResidente(Form c,String id)
        {
            InitializeComponent();
            x = c;
            String d=new ResidenteDAO().Estatus(id);
            if (d.Equals(""))
            {
                LblEstatus.Text = "Estatus: pendiente";
                BtnEntregaDocumentos.Visible = false;
            }else if(d.Equals("Estatus: aceptado")){
                LblEstatus.Text = "Aceptado";
                BtnHoja.Visible = false;
            }
            else if (d.Equals("Rechazado"))
            {
                LblEstatus.Text = "Estatus: rechazado";
                BtnEntregaDocumentos.Visible = false;
                BtnHoja.Visible = false;
            }
        }

        private void FrmResidente_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FrmResidente_Load(object sender, EventArgs e)
        {

        }

        private void BtnEntregaDocumentos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FrmEntregaDeDocuments(this).Show();
        }

        private void BtnCalificaciones_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

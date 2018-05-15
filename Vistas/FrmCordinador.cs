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
using Residencias.FrontEnd;
using Residencias.BackEnd;

namespace Residencias.Vistas
{
    public partial class FrmCordinador : Form
    {
        Form x;
        CoordinadorDAO objCD = new CoordinadorDAO();
        Coordinador objC = new Coordinador();
        String id;
        public FrmCordinador(Form c,String id)
        {
            InitializeComponent();
            x = c;
            objC = objCD.Nombre(id);
            LblCoordi.Text = "Corrdinador: "+objC.NombreCompleto;
            this.id = id;
        }
        
        private void BtnAT_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FrmAsigAsesor(this).Show();
        }

        private void BtnAR_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FrmAsignarRevisores(this).Show();
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

        private void BtnCalificarDocumentos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FrmAsignarCalificacion(this,id).Show();
        }

        private void BtnDictamen_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FrmDictamenes(this).Show();
        }

        private void BtnFinalizarResidente_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FrmFinalizacionDelTrabajo(this).Show();
        }
    }
}

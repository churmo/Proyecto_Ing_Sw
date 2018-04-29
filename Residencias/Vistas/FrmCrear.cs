
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
    public partial class FrmCrear : Form
    {
        Form x;
        public FrmCrear(Form c)
        {
            InitializeComponent();
            x = c;
        }
        public bool Comprobar()
        {
            String tx = "";
            bool bien = true;
            if (Txtid.Text.Equals(""))
            {
                bien = false;
                tx = tx + "Falta usuario\n";

            }
            if (TxtContrasenia.Text.Equals(""))
            {
                bien = false;
                tx = tx + "Falta contraseñia\n";
            }           
            if (bien)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Los siguientes datos faltan o estan mal:\n" + tx, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

        }
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                AlumnoDAO DaoAlu = new AlumnoDAO();
                Alumno Alu = new Alumno();
                Alu = DaoAlu.Obtener(Txtid.Text);
                if (Alu.idAlumno == null)
                {
                    MessageBox.Show("El codigo de control no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Visible = false;
                    new FrmSRP(x, Txtid.Text, TxtContrasenia.Text).Show();
                }
            }
            
           
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            x.Visible = true;
        }

        private void FrmCrear_FormClosing(object sender, FormClosingEventArgs e)
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

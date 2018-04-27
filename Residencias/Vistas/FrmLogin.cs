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
using Residencias.BackEnd;

namespace Residencias.Vistas
{
    public partial class FrmLogin : Form
    {
        
        public FrmLogin()
        {
            InitializeComponent();
            ChbxConexion.AutoCheck = false;
            if(new Conexion().Conectar())
            {
                ChbxConexion.Checked = true;
            }else
            {
                ChbxConexion.Checked = false;
            }

            
        }        
        public void limpiar()
        {
            TxtContrasenia.Text = "";
            TxtUsuario.Text = "";
            CbxTipo.SelectedIndex = -1;
        }
        public bool Comprobar()
        {
            String tx = "";
            bool bien = true;
            if (TxtUsuario.Text.Equals(""))
            {
                bien = false;
                tx = tx + "Falta usuario\n";

            }
            if (TxtContrasenia.Text.Equals(""))
            {
                bien = false;
                tx = tx + "Falta contraseñia\n";
            }
            if (CbxTipo.Text.Equals(""))
            {
                bien = false;
                tx = tx + "Falta elegir si eres alumno o coordinador\n";
            }
            if (bien)
            {
                return true;
            }else
            {
                MessageBox.Show("Los siguientes datos faltan o estan mal:\n"+tx,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return false;
            }

        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                if (CbxTipo.Text.Equals("Residente"))
                {
                    limpiar();
                    this.Visible = false;
                    new FrmResidente(this).Show();
                }
                else if (CbxTipo.Text.Equals("Coordinador"))
                {
                    limpiar();
                    this.Visible = false;
                    new FrmCordinador(this).Show();
                }
            }
            
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            limpiar();
            new FrmCrear(this).Show();
            this.Visible = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}

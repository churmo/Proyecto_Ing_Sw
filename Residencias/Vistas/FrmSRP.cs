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

namespace Residencias
{
    public partial class FrmSRP : Form
        
    {
        Form x;
        String idA = "", ConA="";
        public FrmSRP(Form c,String id,String Con)
        {
            InitializeComponent();
            x = c;
            idA = id;
            ConA = Con;
            Carga();
        }
        public FrmSRP()
        {
            InitializeComponent();
        }
        private void Carga()
        {
            AlumnoDAO DaoAlu = new AlumnoDAO();
            Alumno Alu = new Alumno();
            Alu=DaoAlu.obtenerAlumno(idA);
            txtNoControlR.Text = Alu.idAlumno;
            txtNombreResidente.Text = Alu.NombreCompleto;
            txtCarreraR.Text = Alu.Carrera;
        }

        private void tabDatosEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void tabProyecto_Click(object sender, EventArgs e)
        {

        }
        public bool Comprobar()
        {
            String tx = "";
            bool bien = true;
            if (txtNombreProyecto.Text == "" || cbxOpcionesDP.Text == "" || textPeriodoProyecto.Text == ""
               || txtNumResidencias.Text == "")
            {
                bien = false;
                tx = tx + "Datos del Proyecto\n";
            }
            if (txtNombreE.Text == "" || cbxGiroRamaSector.Text == "" || txtRFCE.Text == ""
                    || txtDomicilioE.Text == "" || txtColoniaE.Text == "" || txtTelefonoE.Text == ""
                    || txtMisionEmpresa.Text == "" || txtTitularEmpresa.Text == "" || txtPuestoTE.Text == ""
                    || txtAsesorExterno.Text == "" || txtNombreFirma.Text == "" || txtPersonaFirma.Text == "")
            {
                bien = false;
                tx = tx + "Datos de la Empresa\n";
            }
            if (txtNombreResidente.Text == "" || txtCarreraR.Text == "" || txtNoControlR.Text == ""
                        || txtDomicilioR.Text == "" || txtEmailR.Text == "" || cbxSeguridadSocial.Text == ""
                        || txtNoSS.Text == "" || txtCiudadE.Text == "" || txtTelefonoE.Text == "")
            {
                bien = false;
                tx = tx + "Datos del Residente\n";
            }
            if (bien)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Hay un campo vacío en la pestaña: \n"+tx, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
        private void btnEntregar_Click(object sender, EventArgs e)
        {
           
            if(Comprobar())
            {
                MessageBox.Show("Datos guardados satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                x.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void FrmSRP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
            {
                x.Visible = true;
                this.Dispose();                
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}

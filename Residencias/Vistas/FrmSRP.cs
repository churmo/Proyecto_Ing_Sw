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
            TxtOtro.Visible = false;
            LblOtro.Visible = false;
            Carga();
        }
        public FrmSRP()
        {
            InitializeComponent();
        }
        String nombre="",apellidoP="",apellidoM="";
        private void Carga()
        {
            AlumnoDAO DaoAlu = new AlumnoDAO();
            Alumno Alu = new Alumno();
            Alu=DaoAlu.obtenerAlumno(idA);
            txtNoControlR.Text = Alu.idAlumno;
            txtNombreResidente.Text = Alu.NombreCompleto;
            nombre = Alu.nombre;
            apellidoP = Alu.apellido1;
            apellidoM = Alu.apellido2;
            txtCarreraR.Text = Alu.Carrera;
        }
        public Empresa empresa()
        {
            try
            {
                if (otro)
                {
                    return new Empresa(
                                   txtNombreE.Text,
                                   cbxGiroRamaSector.Text,
                                   TxtOtro.Text,
                                   txtRFCE.Text,
                                   txtCPE.Text,
                                   txtDomicilioE.Text,
                                   txtFaxE.Text,
                                   txtColoniaE.Text,
                                   txtTelefonoE.Text,
                                   txtMisionEmpresa.Text,
                                   txtTitularEmpresa.Text,
                                   txtPuestoTE.Text,
                                   txtAsesorExterno.Text,
                                   txtPuestoAE.Text,
                                   txtPersonaFirma.Text,
                                   txtPersonaFirma.Text
                                   );
                }
                else
                {
                    return new Empresa(
                   txtNombreE.Text,
                   cbxGiroRamaSector.Text,
                   "",
                   txtRFCE.Text,
                   txtCPE.Text,
                   txtDomicilioE.Text,
                   txtFaxE.Text,
                   txtColoniaE.Text,
                   txtTelefonoE.Text,
                   txtMisionEmpresa.Text,
                   txtTitularEmpresa.Text,
                   txtPuestoTE.Text,
                   txtAsesorExterno.Text,
                   txtPuestoAE.Text,
                   txtPersonaFirma.Text,
                   txtPersonaFirma.Text
                   );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar los datos de la empresa");
                return null;
            }
            
           
        }

        public Residente Residente()
            
        {
            try
            {
                return new Residente(idA,
                ConA,
                nombre,
                apellidoP,
                apellidoM,
                txtCarreraR.Text,
                txtEmailR.Text,
                txtNoSS.Text,
                txtCiudadR.Text,
                txtTelefonoR.Text,
                txtNombreE.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear al residnete");
                return null;
            }
            
        }
        public Proyecto Proyecto()
        {
            try
            {
                return new Proyecto(
                               idA,
                               txtNombreProyecto.Text,
                               txtPeriodoProyecto.Text,
                               int.Parse(txtNumResidencias.Text),
                               cbxOpcionesDP.Text,
                               txtNombreE.Text
                               );
            }
            catch (Exception ex)
            {
                MessageBox.Show("El numero de residencias solo deben de ser numeros");
                return null;
            }
           
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
            if (txtNombreProyecto.Text == "" || cbxOpcionesDP.Text == "" || txtPeriodoProyecto.Text == ""
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
                        || txtNoSS.Text == "" || txtCiudadR.Text == "" || txtTelefonoE.Text == "")
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

            if (Comprobar())
            {
                Empresa E = new Empresa();
                Residente R = new Residente();
                Proyecto P = new Proyecto();
                E= empresa();
                R = Residente();
                P = Proyecto();
                if (E!=null&&R!=null&&P!=null)
                {
                    try
                    {
                        int EE=new EmpresaDAO().Agregar(E);
                        int RR=new ResidenteDAO().Agregar(R);
                        int PP=new ProyectoDAO().Agregar(P);
                        if (EE + RR + PP == 3)
                        {
                            MessageBox.Show("Datos guardados satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                            x.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Error al guardar los datos del residente,empresa y proyeto");
                        }
                        
                    }
                    catch(Exception ex)
                    {

                    }
                   
                }
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool otro=false;
        private void cbxGiroRamaSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxGiroRamaSector.Text.ToLower().Equals("otro"))
            {
                TxtOtro.Visible = true;
                LblOtro.Visible = true;
                otro = true;
            }else
            {
                TxtOtro.Visible = false;
                LblOtro.Visible = false;
                otro = false;
            }
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

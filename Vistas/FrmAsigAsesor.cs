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
        TutorDAO TD = new TutorDAO();
        Tutor T = new Tutor();
        ResidenteDAO RD = new ResidenteDAO();
        Residente R = new Residente();
        List<Tutor> LT = new List<Tutor>();
        List<Residente> LR = new List<Residente>();
        public FrmAsigAsesor(Form c)
        {
            InitializeComponent();
            x = c;
            cargar();
        }
        public void cargar()
        {         
            LT = TD.traerTodos();
            LR = RD.lista();
            for (int i = 0; i < LT.Count; i++)
            {
                CbxAsesores.Items.Add(LT[i].NombreCompleto);
            }
            for (int i = 0; i < LR.Count; i++)
            {
                CbxAlumno.Items.Add(LR[i].NombreCompleto);
            }
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            String Idtutor=TD.Referencia(CbxAsesores.Text);
            String IdResidente = RD.Referencia(CbxAlumno.Text);
            int t=RD.Asesor(IdResidente, Idtutor);
            if (t == 1)
            {
                MessageBox.Show("Se asigno asesor correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                x.Visible = true;
            }
            else
            {
                MessageBox.Show("El asesor no se asigno", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
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

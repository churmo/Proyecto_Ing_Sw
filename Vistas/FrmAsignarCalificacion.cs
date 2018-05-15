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
    public partial class FrmAsignarCalificacion : Form
    {
        Form x;
        ResidenteDAO RD = new ResidenteDAO();
        Residente R = new Residente();
        List<Residente> LR = new List<Residente>();
        RevisarDoc ObjD = new RevisarDoc();
        RevisarDocDAO ObjDD = new RevisarDocDAO();
        String idR;
        public FrmAsignarCalificacion(Form c,String id)
        {
            InitializeComponent();
            x = c;
            idR = id;
            LR = RD.lista();
            for (int i = 0; i < LR.Count; i++)
            {
                CbxAlumno.Items.Add(LR[i].NombreCompleto);
            }
        }
       
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String idRe = RD.Referencia(CbxAlumno.Text);
            ObjDD.Agregar(
                new RevisarDoc(
                    int.Parse(TxtIdDocumento.Text),
                    int.Parse(TxtCalificacion.Text),
                    TxtNotas.Text,
                    idR,
                    idRe
                    ) 
                );
        }
    }
}

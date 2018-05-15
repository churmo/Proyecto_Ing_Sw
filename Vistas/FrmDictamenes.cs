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
    public partial class FrmDictamenes : Form
    {
        Form x;
        ResidenteDAO RD = new ResidenteDAO();
        Residente R = new Residente();
        List<Residente> LR = new List<Residente>();
        public FrmDictamenes(Form c)
        {
            InitializeComponent();
            x = c;
            LR = RD.lista();
            for (int i = 0; i < LR.Count; i++)
            {
                CbxAlumno.Items.Add(LR[i].NombreCompleto);
            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            new FrmMensajeDeAprovacion().ShowDialog();
        }

        private void btnRevisionInforme_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void CbxAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            String idRe = RD.Referencia(CbxAlumno.Text);
            txtControl.Text = idRe;
        }
    }
}

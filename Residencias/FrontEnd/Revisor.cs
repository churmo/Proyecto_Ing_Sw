using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residencias.FrontEnd
{
    public class Revisor
    {
        int idClaveTutor { get; set; }
        String Nombre { get; set; }
        String ApellidoP { get; set; }
        String ApellidoM { get; set; }

        public String NombreCompleto
        {
            get
            {
                return String.Format("{0} {1} {2}", Nombre, ApellidoP, ApellidoM);
            }
        }
        Revisor()
        { }

        Revisor(int idClaveTutor, String Nombre, String ApellidoP, String ApellidoM)
        {
            this.idClaveTutor = idClaveTutor;
            this.Nombre = Nombre;
            this.ApellidoP = ApellidoP;
            this.ApellidoM = ApellidoM;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residencias.FrontEnd
{
    public class Tutor
    {
        int idClaveTutor { get; set; }
        String Nombre { get; set; }
        String ApellidoP { get; set; }
        String ApellidoM { get; set; }
        String Carrera { get; set; }
        String FechaIngreso { get; set; }
        public String NombreCompleto
        {
            get
            {
                return String.Format("{0} {1} {2}", Nombre, ApellidoP, ApellidoM);
            }
        }
        Tutor()
        { }

        Tutor(int idClaveTutor, String Nombre, String ApellidoP, String ApellidoM, String Carrera,
            String FechaIngreso)
        {
            this.idClaveTutor = idClaveTutor;
            this.Nombre = Nombre;
            this.ApellidoP = ApellidoP;
            this.ApellidoM = ApellidoM;
            this.Carrera = Carrera;
            this.FechaIngreso = FechaIngreso;
        }
    }
}

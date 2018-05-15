using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residencias.FrontEnd
{
    public class Tutor
    {
        public String idTutor { get; set; }
        public String nombre { get; set; }
        public String apellido1 { get; set; }
        public String apellido2 { get; set; }
        public String contrasenia { get; set; }
        public String NombreCompleto
        {
            get
            {
                return String.Format("{0} {1} {2}", nombre, apellido1, apellido2);
            }
        }
        public Tutor(String idAsesor, String contrasenia)
        {
            this.idTutor = idAsesor;
            this.contrasenia = contrasenia;

        }
        public Tutor(String idTutor,String nombre,String apellido1,String apellido2)
        {
            this.idTutor = idTutor;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
        }

        public Tutor()
        {

        }
    }
}

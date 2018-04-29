using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residencias.FrontEnd
{
    public class Alumno
    {
        public String idAlumno { get; set; }
        public String nombre { get; set; }
        public String apellido1 { get; set; }
        public String apellido2 { get; set; }
        public String Carrera { get; set; }
        public String NombreCompleto
        {
            get
            {
                return String.Format("{0} {1} {2}", nombre, apellido1, apellido2);
            }
        }
        public Alumno()
        {

        }

        public Alumno(String idAlumno, String nombre, String apellido1, String apellido2,String Carrera)
        {
            this.idAlumno = idAlumno;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.Carrera = Carrera;
        }
        public Alumno(String idAlumno)
        {
            this.idAlumno = idAlumno;
            
        }
    }
}

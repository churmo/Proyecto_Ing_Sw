using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residencias.FrontEnd
{
    public class Revisor
    {
        public String idRevisor { get; set; }
        public String nombre { get; set; }
        public String apellido1 { get; set; }
        public String apellido2 { get; set; }
        public String contrasenia { get; set; }

        public Revisor(String idRevisor,String nombre,String apellido1,String apellido2,String contrasenia)
        {
            this.idRevisor = idRevisor;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.contrasenia = contrasenia;
        }

        public Revisor()
        {

        }
    }
}

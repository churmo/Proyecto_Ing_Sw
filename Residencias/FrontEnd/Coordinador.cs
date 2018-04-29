using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residencias.FrontEnd
{
    public class Coordinador
    {
        public String idCoordi { get; set; }
        public String Nombre { get; set; }
        public String apellidoP { get; set; }
        public String apellidoM { get; set; }
        public String Carrera { get; set; }
        public String correo { get; set; }
        public String Telefono { get; set; }
        public String contrasenia { get; set; }
        public String NombreCompleto
        {
            get
            {
                return String.Format("{0} {1} {2}", Nombre, apellidoP, apellidoM);
            }
        }
        public Coordinador(String idCoordi,String Nombre,String apellidoP,String apellidoM,String Carrera,String correo,String Telefono,String contrasenia)
        {
            this.idCoordi = idCoordi;
            this.Nombre = Nombre;
            this.apellidoP = apellidoP;
            this.apellidoM = apellidoM;
            this.Carrera = Carrera;
            this.correo = correo;
            this.Telefono = Telefono;
            this.contrasenia = contrasenia;
        }
        public Coordinador(String idCoordi, String contrasenia)
        {
            this.idCoordi = idCoordi;
            this.contrasenia = contrasenia;
        }

        public Coordinador()
        {

        }
    }
}

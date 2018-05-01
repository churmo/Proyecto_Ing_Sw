using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residencias.FrontEnd
{
    public class Residente
    {
        public String noControl { get; set; }
        public String contrasenia { get; set; }
        public String Nombre { get; set; }
        public String apellidoP { get; set; }
        public String apellidoM { get; set; }
        public String Carrera { get; set; }
        public String Aceptado { get; set; }
        public String correo { get; set; }
        public String NoSS { get; set; }
        public String Ciudad { get; set; }
        public String Telefono { get; set; }
        public String idCoordi { get; set; }
        public String idTutor{ get; set; }
        public String idEmpresa { get; set; }
        public String NombreCompleto
        {
            get
            {
                return String.Format("{0} {1} {2}", Nombre, apellidoP, apellidoM);
            }
        }
        public Residente()
        {

        }
        public Residente(String noControl, String contrasenia, String Nombre, String apellidoP, String apellidoM, String Carrera, String correo, String NoSS, String Ciudad, String Telefono,String idEmpresa)
        {
            this.noControl = noControl;
            this.contrasenia = contrasenia;
            this.Nombre = Nombre;
            this.apellidoP = apellidoP;
            this.apellidoM = apellidoM;
            this.Carrera = Carrera;
            this.correo = correo;
            this.NoSS = NoSS;
            this.Ciudad = Ciudad;
            this.Telefono = Telefono;
            this.idEmpresa = idEmpresa;
        }
        public Residente(String noControl, String contrasenia)
        {
            this.noControl = noControl;
            this.contrasenia = contrasenia;
           
        }
        public Residente(String noControl, String Nombre, String apellidoP, String apellidoM, String Carrera,String Aceptado)
        {
            this.noControl = noControl;            
            this.Nombre = Nombre;
            this.apellidoP = apellidoP;
            this.apellidoM = apellidoM;
            this.Carrera = Carrera;
            this.Aceptado = Aceptado;            
        }
        public Residente(String noControl, String Nombre, String apellidoP, String apellidoM)
        {
            this.noControl = noControl;
            this.Nombre = Nombre;
            this.apellidoP = apellidoP;
            this.apellidoM = apellidoM;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residencias.FrontEnd
{
    public class Coordinador
    {
        int idClaveCoordi { get; set; }
        String Nombre { get; set; }
        String ApellidoP { get; set; }
        String ApellidoM { get; set; }
        String Carrera { get; set; }
        String Correo { get; set; }
        String Telefono { get; set; }
        public String NombreCompleto
        {
            get
            {
                return String.Format("{0} {1} {2}", Nombre, ApellidoP, ApellidoM);
            }
        }
        Coordinador()
        { }

        Coordinador(int idClaveCoordi, String Nombre, String ApellidoP, String ApellidoM, String Carrera, String Correo,
            String Telefono)
        {
            this.idClaveCoordi = idClaveCoordi;
            this.Nombre = Nombre;
            this.ApellidoP = ApellidoP;
            this.ApellidoM = ApellidoM;
            this.Carrera = Carrera;
            this.Telefono = Telefono;
            this.Correo = Correo;
        }
    }
}

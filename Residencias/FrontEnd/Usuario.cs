using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residencias.FrontEnd
{
    public class Usuario
    {
        public String nombreUsuario{ get; set; }
        public String contrasenia { get; set; }

        public Usuario(String nombreUsuario,String contrasenia)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasenia = contrasenia;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Residencias.FrontEnd;
namespace Residencias.BackEnd
{
    class UsuarioDAO
    {
        //
        //Conexión
        //
        Conexion con = new Conexion();

        //
        //agrega un solo usuario
        // 

        public int Agregar(Usuario obj)
        {

            //si el usuario se agrega regresa 1 de lo contrario regresa 0
            try
            {
                return con.ejecutarSentencia(("INSERT INTO usuarios VALUES("
                    + ",'" + obj.nombreUsuario + "'"
                    + ",'" + obj.contrasenia + "');"), true);

            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}

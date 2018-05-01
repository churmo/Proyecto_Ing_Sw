using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Residencias.FrontEnd;

namespace Residencias.BackEnd
{
    class RevisarDocDAO
    {
        //
        //Conexión
        //
        Conexion con = new Conexion();

        //
        //agrega un Revisar documentos
        // 

        public int Agregar(RevisarDoc obj)
        {

            //si se agrega regresa 1 de lo contrario regresa 0
            try
            {
                return con.ejecutarSentencia(("INSERT INTO RevisarDoc VALUES("
                    + obj.idDocumento
                    + "," + obj.idDocumento
                    + ",'" + obj.Notas + "'"
                    + "," + obj.idRevisor
                    + ",'" + obj.idResidente + "');"), true);

            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Residencias.FrontEnd;

namespace Residencias.BackEnd
{
    public class ProyectoDAO
    {
        //
        //Conexión
        //
        Conexion con = new Conexion();

        //
        //agrega un solo proyecto
        // 

        public int Agregar(Proyecto obj)
        {

            //si el proyecto se agrega regresa 1 de lo contrario regresa 0
            try
            {
                return con.ejecutarSentencia(("INSERT INTO Proyecto VALUES("
                    + "'" + obj.idNombre + "'"
                    + ",'" + obj.PeriodoProyecto + "'"
                    + "," + obj.NumeroResidencias
                     + ",'" + obj.opcionElegida + "');"), true);

            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}

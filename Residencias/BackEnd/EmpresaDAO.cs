using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Residencias.FrontEnd;

namespace Residencias.BackEnd
{
    public class EmpresaDAO
    {
        //
        //Conexión
        //
        Conexion con = new Conexion();

        //
        //agrega una empresa
        // 

        public int Agregar(Empresa obj)
        {

            //si la empresa se agrega regresa 1 de lo contrario regresa 0
            try
            {
                return con.ejecutarSentencia(("INSERT INTO Empresa VALUES("
                    + ",'" + obj.otrogrs + "'"
                    + ",'"+ obj.giraRamaSector
                    + "','" + obj.otrogrs + "'"
                    + ",'" + obj.rfc + "'"
                    + ",'" + obj.cp + "'"
                    + ",'" + obj.domicilio + "'"
                    + ",'" + obj.fax + "'"
                    + ",'" + obj.colonia + "'"
                    + ",'" + obj.telefono + "'"
                    + ",'" + obj.MisionEmpresa + "'"
                    + ",'" + obj.NombreTitularEmpresa + "'"
                    + ",'" + obj.PuestoTitularEmpresa + "'"
                    + ",'" + obj.NombreAsesorExterno + "'"
                    + ",'" + obj.PuestoAsesorExterno + "'"
                    + ",'" + obj.NombrePersonaFirma + "'"
                    + ",'" + obj.PuestoPersonaFirma + "');"), true);

            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}

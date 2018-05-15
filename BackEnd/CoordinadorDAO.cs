using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Residencias.FrontEnd;
using System.Windows.Forms;
using System.Data;
using Residencias.FrontEnd;

namespace Residencias.BackEnd
{
    
    public class CoordinadorDAO
    {
        //
        //Conexión
        //
        Conexion con = new Conexion();

        //public int Agregar (Coordinador obj)
        //{
        //    try
        //    {
        //        return con.ejecutarSentencia(("INSERT INTO coordi VALUES("
        //        + obj.idCoordi
        //        + ",'" + obj.Nombre + "'"
        //        + ",'" + obj.apellidoP + "'"
        //        + ",'" + obj.apellidoM + "'"
        //        + ",'" + obj.Carrera + "'"
        //        + ",'" + obj.correo + "'"
        //        + ",'" + obj.Telefono + "');"), true);
        //    }
        //    catch (Exception)
        //    {
        //        return 0;
        //    }
            
        //}

        //
        //Busca el coordinador en la base de datos
        //

        public Coordinador Buscar(String idCoordi)
        {
            Coordinador objC=null;
            try
            {

                DataTable objTable = new DataTable();
                
                //Da como resultado una tabla apartir de la consulta
                objTable = con.ejecutarConsulta("SELECT idcoordi,contrasenia FROM coordi where idCoordi='" + idCoordi + "';");

                //Asigna las columnas de la tabla a los valores correspondientes del alumno
                foreach (DataRow t in objTable.Rows)
                {
                    objC = new Coordinador(
                        t["idCoordi"].ToString(),
                        t["contrasenia"].ToString());
                }
                return objC;
            }
            catch (Exception e)
            {
                return null;
            }
            

        }
        public Coordinador Nombre(String idCoordi)
        {
            Coordinador objC = null;
            try
            {

                DataTable objTable = new DataTable();

                //Da como resultado una tabla apartir de la consulta
                objTable = con.ejecutarConsulta("SELECT Nombre,apellidoP,ApellidoM FROM coordi where idCoordi='" + idCoordi + "';");

                //Asigna las columnas de la tabla a los valores correspondientes del alumno
                foreach (DataRow t in objTable.Rows)
                {
                    objC = new Coordinador(
                        t["Nombre"].ToString(),
                        t["apellidoP"].ToString(),
                        t["ApellidoM"].ToString());
                }
                return objC;
            }
            catch (Exception e)
            {
                return null;
            }


        }

    }
}

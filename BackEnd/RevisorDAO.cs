using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Residencias.FrontEnd;

namespace Residencias.BackEnd
{
    public class RevisorDAO
    {
        //
        //Conexión
        //
        Conexion con = new Conexion();

        //
        //agrega un solo Revisor
        // 

        //public int Agregar(Revisor obj)
        //{

        //    //si el Revisor se agrega regresa 1 de lo contrario regresa 0
        //    try
        //    {
        //        return con.ejecutarSentencia(("INSERT INTO Revisor VALUES("
        //            + obj.idRevisor
        //            + ",'" + obj.nombre + "'"
        //            + ",'" + obj.apellido1 + "'"
        //            + ",'" + obj.apellido2 + "'"
        //            + ",'" + obj.contrasenia + "');"), true);

        //    }
        //    catch (Exception)
        //    {
        //        return 0;
        //    }
        //}

        public String Buscar(String idRevisor)
        {
            try
            {

                DataTable objTable = new DataTable();

                //Da como resultado una tabla apartir de la consulta
                objTable = con.ejecutarConsulta("SELECT idRevisor,contrasenia FROM Revisor where idRevisor='" + idRevisor + "';");

                //Asigna las columnas de la tabla a los valores correspondientes del coordinador
                foreach (DataRow t in objTable.Rows)
                {
                    return t["idRevisor"].ToString() + "," + t["contrasenia"].ToString();
                }
            }
            catch (Exception e)
            {

            }
            return null;

        }
        public String Referencia(String Nombre)
        {
            try
            {

                DataTable objTable = new DataTable();

                //Da como resultado una tabla apartir de la consulta
                objTable = con.ejecutarConsulta("select idRevisor from Revisor where concat(Nombre, ' ', apellido1, ' ', apellido2) like '" + Nombre + "';");

                //Asigna las columnas de la tabla a los valores correspondientes del Residente
                foreach (DataRow t in objTable.Rows)
                {
                    return t["idRevisor"].ToString();
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return null;
        }
        public List<String> traerTodos()
        {
            try
            {
                List<String> l = new List<string>();
                DataTable objTable = new DataTable();

                //Da como resultado una tabla apartir de la consulta
                objTable = con.ejecutarConsulta("SELECT nombre FROM Revisor;");

                //Asigna las columnas de la tabla a los valores correspondientes del coordinador
                foreach (DataRow t in objTable.Rows)
                {
                    l.Add (t["nombre"].ToString());
                }
                return l;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        
    }
}

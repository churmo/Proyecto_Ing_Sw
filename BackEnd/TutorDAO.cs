using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Residencias.FrontEnd;

namespace Residencias.BackEnd
{
    public class TutorDAO
    {
        //
        //Conexión
        //
        Conexion con = new Conexion();

        //
        //agrega un solo tutor
        // 

        //public int Agregar(Tutor obj)
        //{

        //    //si el tutor se agrega regresa 1 de lo contrario regresa 0
        //    try
        //    {
        //        return con.ejecutarSentencia(("INSERT INTO Tutor VALUES("
        //            + obj.idTutor
        //            + ",'" + obj.nombre + "'"
        //            + ",'" + obj.apellido1 + "'"
        //            + ",'" + obj.apellido2 + "');"), true);

        //    }
        //    catch (Exception)
        //    {
        //        return 0;
        //    }
        //}

        public Tutor Buscar(String idTutor)
        {
            try
            {

                DataTable objTable = new DataTable();
                Tutor Objt;
                //Da como resultado una tabla apartir de la consulta
                objTable = con.ejecutarConsulta("SELECT idTutor,contrasenia FROM Tutor where idTutor='" + idTutor + "';");

                //Asigna las columnas de la tabla a los valores correspondientes del coordinador
                foreach (DataRow t in objTable.Rows)
                {
                    return Objt = new Tutor(
                        t["idTutor"].ToString(),
                        t["contrasenia"].ToString());
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return null;

        }

        public String Referencia(String Nombre)
        {
            try
            {

                DataTable objTable = new DataTable();

                //Da como resultado una tabla apartir de la consulta
                objTable = con.ejecutarConsulta("select idTutor from Tutor where concat(Nombre, ' ', apellido1, ' ', apellido2) like '" + Nombre + "';");

                //Asigna las columnas de la tabla a los valores correspondientes del Residente
                foreach (DataRow t in objTable.Rows)
                {
                    return t["idTutor"].ToString();
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return null;
        }
        public List<Tutor> traerTodos()
        {
            try
            {
                List<Tutor> l = new List<Tutor>();
                DataTable objTable = new DataTable();

                //Da como resultado una tabla apartir de la consulta
                objTable = con.ejecutarConsulta("SELECT idtutor,nombre,apellido1,apellido2 FROM Tutor order by apellido1 asc");

                //Asigna las columnas de la tabla a los valores correspondientes del coordinador
                foreach (DataRow t in objTable.Rows)
                {
                    l.Add(
                        new Tutor(t["idtutor"].ToString(),
                        t["nombre"].ToString(),
                        t["apellido1"].ToString(),
                        t["apellido2"].ToString()));
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

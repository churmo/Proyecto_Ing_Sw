using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Residencias.FrontEnd;
using System.Data;

namespace Residencias.BackEnd
{
    public class AlumnoDAO
    {
        //
        //Conexión
        //
        Conexion con = new Conexion();

        //
        //agrega un solo alumno
        // 

        public String Agregar(Alumno obj)
        {

            try
            {
                if (con.ejecutarSentencia(("INSERT INTO alumno VALUES("
                    + obj.idAlumno
                    + ",'" + obj.nombre + "'"
                    + ",'" + obj.apellido1 + "'"
                    + ",'" + obj.apellido2 + "'"
                    + ",'" + obj.Carrera + "');"), true) == 0)
                {
                    return "El alumno a sido agregado con exito.";
                    //MessageBox.Show("El alumno a sido agregado con exito.", "Succhess", MessageBoxButtons.OK);
                }else
                {
                    return null;
                }



            }
            catch (Exception e)
            {
                return null;
                //MessageBox.Show(e + "", "Error", MessageBoxButtons.OK);
            }
        }

        //
        //Busca el alumno en la base de datos
        //

        public Alumno obtenerAlumno(String idAlumno)
        {
            Alumno objAlumno = new Alumno();
            try
            {

                DataTable objTable = new DataTable();

                //Da como resultado una tabla apartir de la consulta
                objTable = con.ejecutarConsulta("SELECT * FROM Alumno where idAlumno='" + idAlumno + "';");

                //Asigna las columnas de la tabla a los valores correspondientes del alumno
                foreach (DataRow t in objTable.Rows)
                {
                    objAlumno = new Alumno(
                        t["idAlumno"].ToString(),
                        t["nombre"].ToString(),
                        t["apellido1"].ToString(),
                        t["apellido2"].ToString(),
                        t["Carrera"].ToString());
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return objAlumno;

        }
    }
}


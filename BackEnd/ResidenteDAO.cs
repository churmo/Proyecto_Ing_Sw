using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Residencias.FrontEnd;

namespace Residencias.BackEnd
{
    public class ResidenteDAO
    {
        //
        //Conexión
        //
        Conexion con = new Conexion();

        //
        //agrega un solo residente
        // 

        public int Agregar(Residente obj)
        {

            //si el residente se agrega regresa 1 de lo contrario regresa 0
            try
            {
                return con.ejecutarSentencia(("INSERT INTO Residente"+ 
                    "(noControl, contrasenia, Nombre, apellidoP, apellidoM, Carrera, correo, NoSS, Ciudad, Telefono, IdEmpresa, IdProyecto)VALUES("
                    + "'" + obj.noControl + "'"
                    + ",'" + obj.contrasenia + "'"
                    + ",'" + obj.Nombre + "'"
                    + ",'" + obj.apellidoP + "'"
                    + ",'" + obj.apellidoM + "'"
                    + ",'" + obj.Carrera + "'"
                    + ",'" + obj.correo + "'"
                    + ",'" + obj.NoSS + "'"
                    + ",'" + obj.Ciudad + "'"
                    + ",'" + obj.Telefono + "'"
                    + ",'" + obj.idEmpresa + "'"
                     + ",'" + obj.idProyecto + "');"), true);

            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Actualizar(String noControl,String Aceptado)
        {
            try
            {
                //Si se actualiza regresa 1 de lo contrario regresa 0
                return con.ejecutarSentencia(("UPDATE Residente SET Aceptado=" + Aceptado + " where noControl='"+noControl+"' limit 1;"), true);                
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int Asesor(String noControl, String idtutor)
        {
            try
            {
                //Si se actualiza regresa 1 de lo contrario regresa 0
                return con.ejecutarSentencia(("UPDATE Residente SET IdTutor"+ idtutor +" where noControl='" + noControl + "' limit 1;"), true);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public Residente Buscar(String noControl)
        {
            try
            {

                DataTable objTable = new DataTable();
                Residente objR; 
                //Da como resultado una tabla apartir de la consulta
                objTable = con.ejecutarConsulta("SELECT * FROM Residente where noControl='" + noControl + "';");

                //Asigna las columnas de la tabla a los valores correspondientes del Residente
                foreach (DataRow t in objTable.Rows)
                {
                    return objR = new Residente(
                        t["nocontrol"].ToString(),
                        t["contrasenia"].ToString());
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return null;

        }
        public String Estatus(String noControl)
        {
            try
            {

                DataTable objTable = new DataTable();

                //Da como resultado una tabla apartir de la consulta
                objTable = con.ejecutarConsulta("SELECT Aceptado FROM Residente where noControl='" + noControl + "';");

                //Asigna las columnas de la tabla a los valores correspondientes del Residente
                foreach (DataRow t in objTable.Rows)
                {
                    return t["Aceptado"].ToString();
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
                objTable = con.ejecutarConsulta("select noControl from alumno where concat(Nombre, ' ', apellido1, ' ', apellido2) like '" + Nombre+"';");

                //Asigna las columnas de la tabla a los valores correspondientes del Residente
                foreach (DataRow t in objTable.Rows)
                {
                    return t["noControl"].ToString(); 
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return null;

        }
        public List<Residente> lista()
        {
            try
            {
                List<Residente> LR = new List<Residente>();
                DataTable objTable = new DataTable();

                //Da como resultado una tabla apartir de la consulta
                objTable = con.ejecutarConsulta("SELECT noControl,Nombre,apellidoP,apellidoM FROM Residente where Aceptado!= null order by apellidoP asc;");

                //Asigna las columnas de la tabla a los valores correspondientes del Residente
                foreach (DataRow t in objTable.Rows)
                {
                    LR.Add(
                        new Residente(
                            t["noControl"].ToString(),
                            t["Nombre"].ToString(),
                            t["apellidoP"].ToString(),
                            t["ApellidoM"].ToString()
                            )
                        );
                }
                return LR;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<Residente> Aceptados()
        {
            try
            {
                List<Residente> LR = new List<Residente>();
                DataTable objTable = new DataTable();

                //Da como resultado una tabla apartir de la consulta
                objTable = con.ejecutarConsulta("SELECT noControl,Nombre,apellidoP,apellidoM,Carrera,Aceptado FROM Residente where"
                    + " Aceptado = null;");

                //Asigna las columnas de la tabla a los valores correspondientes del Residente
                foreach (DataRow t in objTable.Rows)
                {
                    LR.Add(
                        new Residente(
                            t["noControl"].ToString(),
                            t["Nombre"].ToString(),
                            t["apellidoP"].ToString(),
                            t["ApellidoM"].ToString(),
                            t["Carrera"].ToString(),
                            t["Aceptado"].ToString()
                            )
                        );
                }
                return LR;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Residencias.BackEnd
{
    public class Conexion
    {
        public static MySqlConnection conexion = null;
        public bool Conectar()
        {
            String servidor = "localhost";
            String usuario = "root";
            String contrasenia = "root";
            String puerto = "3306";
            String basede = "BDIS";
            String parametrosConexion = "Server=" + servidor + ";Uid=" + usuario + ";Pwd=" + contrasenia + ";Database=" + basede + ";Port=" + puerto + ";";
            conexion = new MySqlConnection(parametrosConexion);
            try
            {
                conexion.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    
        public DataTable ejecutarConsulta(MySqlCommand consulta)
        {
            try
            {
                if (Conectar())
                {
                    consulta.Connection = conexion;
                    MySqlDataAdapter objAdapter =
                        new MySqlDataAdapter(consulta);
                    DataTable resultado = new DataTable();
                    objAdapter.Fill(resultado);
                    return resultado;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }

        }
        public DataTable ejecutarConsulta(String consulta)
        {
            try
            {
                if (Conectar())
                {
                    MySqlDataAdapter objAdapter =
                        new MySqlDataAdapter(consulta, conexion);
                    DataTable resultado = new DataTable();
                    objAdapter.Fill(resultado);
                    return resultado;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }

        }

        /// <summary>
        /// Ejecuta una sentencia en la base de datos
        /// </summary>
        /// <param name="sentencia"></param>
        /// <param name="esInsert"></param>
        /// <returns></returns>

        public String p = "";

        public int ejecutarSentencia(String sentencia, bool esInsert)
        {
            int resultado = 0;
            try
            {
                if (Conectar())
                {
                    MySqlCommand objComando =
                        new MySqlCommand(sentencia, conexion);


                    if (esInsert)
                    {
                        resultado = int.Parse(objComando.ExecuteScalar().ToString());
                        p = "Agr--";

                    }
                    else
                    {
                        objComando.ExecuteNonQuery();
                        resultado = 1;
                    }


                    return resultado;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                p = ex.ToString();
                return 0;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }
        public int ejecutarSentencia(MySqlCommand sentencia, bool esInsert)
        {
            int resultado = 0;
            try
            {
                if (Conectar())
                {
                    sentencia.Connection = conexion;
                    MySqlDataAdapter objAdapter = new MySqlDataAdapter(sentencia);
                    if (esInsert)
                    {
                        sentencia.ExecuteScalar();
                        p = "Agr--";
                    }
                    else
                    {
                        sentencia.ExecuteNonQuery();
                        resultado = 1;
                    }
                    return resultado;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                p = ex.ToString();
                return 0;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }
    }
}
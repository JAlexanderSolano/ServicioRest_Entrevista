using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Conexion
    {
        internal static int Ejecutar(string query)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(Data.Conexion.MiCadenaDeConexion);
                //Abrir la conexion
                sqlconnection.Open();
                //Crear el objeto sqlCommand
                SqlCommand cmd = new SqlCommand(query, sqlconnection);
                cmd.CommandTimeout = 600;
                //Ejecutar la consulta y tomar el resultado
                int resultado = cmd.ExecuteNonQuery();
                //Cerrar la conexion
                sqlconnection.Close();
                //Liberar recursos
                cmd.Dispose();
                cmd = null;
                sqlconnection.Dispose();
                sqlconnection = null;
                //Retornar el resultado
                return resultado;
            }
            catch (Exception ex)
            {
                //Entities.Log.WriteError(ex);
                return -1;
            }
        }

        internal static string EjecutarFuncion(String Query)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(Data.Conexion.MiCadenaDeConexion);
                //Abrir la conexion
                sqlconnection.Open();
                //Crear el objeto sqlCommand
                SqlCommand cmd = new SqlCommand(Query, sqlconnection);
                cmd.CommandTimeout = 600;
                //Ejecutar la consulta y tomar el resultado
                var resultado = cmd.ExecuteScalar();
                //Cerrar la conexion
                sqlconnection.Close();
                //Liberar recursos
                cmd.Dispose();
                cmd = null;
                sqlconnection.Dispose();
                sqlconnection = null;
                //Retornar el resultado
                return resultado.ToString();
            }
            catch (Exception e)
            {
                string mensaje = e.Message;
                return "-1";
            }

        }

        internal static DataTable Consultar(String Query)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(Data.Conexion.MiCadenaDeConexion);
                sqlconnection.Open();
                DataTable data = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(Query, sqlconnection);
                da.SelectCommand.CommandTimeout = 300;
                da.Fill(data);
                sqlconnection.Close();
                da.Dispose();
                da = null;
                sqlconnection.Dispose();
                sqlconnection = null;
                return data;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public static String MiCadenaDeConexion
        {
            get
            {
                try
                {
                    String cad = "";

                    // Conexion Por Archivo plano 
                    //StreamReader cadenilla = new StreamReader("C:\\ConexionTaxiWeb.txt");
                    //cad = cadenilla.ReadToEnd();
                    //cadenilla.Close();
                    //cadenilla.Dispose();
                    //cadenilla = null;

                    // Conexión desde el sistema
                    var CaracterInstancia = @"\";

               
                    // Cadena de conexion sin autentición por usuario
                    
                    cad = "Data Source=JOHN" + CaracterInstancia + "SQLEXPRESS; Initial Catalog=ENTREVISTA_AlexanderSolano;Integrated Security=true";
                    // Cadena de conexión con autenticación de usuario

                    //cad = "Data Source=JOHN" + CaracterInstancia + "SQLEXPRESS; Initial Catalog=ENTREVISTA_AlexanderSolano;User ID=XYZ; Password = XYZ";


                    return cad;

                }
                catch (Exception)
                {
                    return null;
                }
            }


        }
    }
}

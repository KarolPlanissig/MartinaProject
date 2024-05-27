using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Conexion
{
    public class AccesoDatos // Clase para centralizar la conexión a la base de datos.
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector; 
        
        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public AccesoDatos() //Constructor que cuando la clase nace, nace con una conexion a SQL.
        {
             conexion = new SqlConnection("server=.\\SQLEXPRESS; database=NuevaBase; integrated security=true;");
             comando = new SqlCommand();
        }
        public void setearConsulta(string consulta) //Recibe la consulta que quiero realizar contra la Base de datos.
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta; 
        }
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void cerrarConexion()
        {
            if(lector != null)
            {
                lector.Close(); 
                conexion.Close(); 
            }
        }
        public void ejecutarAccion()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
    }
}

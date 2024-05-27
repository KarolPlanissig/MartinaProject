using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Conexion
{
    public class AccesoVerPedidos
    {

        public List<DatosProveedor> listarPedidos()
        {
            List<DatosProveedor> listarP = new List<DatosProveedor>();
            ArticuloConexion conexionNueva = new ArticuloConexion();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=NuevaBase; integrated security=true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Proveedor, Producto, PrecioUnidad, Cantidad, PrecioTotal, PrecioEnvio, GastoTotal, Fecha from Pedidos";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    DatosProveedor prov = new DatosProveedor();
                    prov.Proveedor = (string)lector["Proveedor"];
                    prov.Producto = (string)lector["Producto"];
                    prov.PrecioUnidad = (double)lector["PrecioUnidad"];
                    prov.Cantidad = (int)lector["Cantidad"];
                    prov.PrecioTotal = (double)lector["PrecioTotal"];
                    prov.PrecioEnvio = (double)lector["PrecioEnvio"];
                    prov.GastoTotal = (double)lector["GastoTotal"];
                    prov.Fecha = (DateTime)lector["Fecha"];

                    listarP.Add(prov);
                }
                conexion.Close();
                return listarP;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

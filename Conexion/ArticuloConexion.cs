using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;
using System.Data.SqlClient;

namespace Conexion
{
    public class ArticuloConexion //Clase para establecer la conexión a la base de datos. 
    {
        public List<Producto> listar() // Para mostrar los datos de la SQL en un DataGridView.
        {
            List<Producto> Lista = new List<Producto>(); // Guardamos los datos traidos del SQL en una lista.
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand(); //Sirve para realizar una accion. Para realizar acciones. 
            SqlDataReader lector; //alojar los sets de datos en un lector.
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=NuevaBase; integrated security=true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Nombre, PrecioCompra, PrecioVenta, Stock, Talle, Imagen, Id from Producto1";
                comando.Connection = conexion; //Comando configurado lo ejecuta en esta conexión.

                conexion.Open();
                lector = comando.ExecuteReader(); //ExecuteReader devuelve un SqlDataReader y se lo asigno a Lector

                while (lector.Read())
                {
                    Producto aux = new Producto();
                    //aux.Id = (int)lector["Id"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.PrecioCompra = (double)lector["PrecioCompra"];
                    aux.PrecioVenta = (double)lector["PrecioVenta"];
                    aux.Stock = (int)lector["Stock"];
                    aux.Talle = (string)lector["Talle"];
                    aux.ImagenProducto = (string)lector["Imagen"];

                    Lista.Add(aux);
                }


                conexion.Close(); 
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        } 
        
        public void agregarProducto(Producto nuevo) // Funcion que agrega nuevo productos a la Base de datos.
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into Producto1 (Nombre, PrecioCompra, PrecioVenta, Stock, Talle, Imagen ) values (@Nombre,@PrecioCompra,@PrecioVenta,@Stock,@Talle,@Imagen)");
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@PrecioCompra", nuevo.PrecioCompra);
                datos.setearParametro("@PrecioVenta", nuevo.PrecioVenta);
                datos.setearParametro("@Stock", nuevo.Stock);
                datos.setearParametro("@Talle", nuevo.Talle);
                datos.setearParametro("Imagen", nuevo.ImagenProducto); 
                datos.ejecutarAccion(); //No es una lectura, es una acción, por eso ejecutar accion. (INSERT).
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void agregarProveedor(DatosProveedor nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Pedidos (Proveedor, Producto, PrecioUnidad, Cantidad, PrecioTotal, PrecioEnvio, GastoTotal, Fecha) values (@Proveedor, @Producto, @PrecioUnidad, @Cantidad, @PrecioTotal, @PrecioEnvio, @GastoTotal, @Fecha)");
                datos.setearParametro("@Proveedor", nuevo.Proveedor);
                datos.setearParametro("@Producto", nuevo.Producto);
                datos.setearParametro("@PrecioUnidad", nuevo.PrecioUnidad);
                datos.setearParametro("@Cantidad", nuevo.Cantidad);
                datos.setearParametro("@PrecioTotal", nuevo.PrecioTotal);
                datos.setearParametro("@PrecioEnvio", nuevo.PrecioEnvio);
                datos.setearParametro("@GastoTotal", nuevo.GastoTotal);
                datos.setearParametro("@Fecha", nuevo.Fecha);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
        }
        public void modificarProducto(Producto prod)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Producto1 set Nombre = @Nombre, PrecioCompra = @PrecioCompra, PrecioVenta = @PrecioVenta, Stock = @Stock, Talle = @Talle, Imagen = @Imagen  where id = @Id");
                datos.setearParametro("@Nombre", prod.Nombre);
                datos.setearParametro("@PrecioCompra", prod.PrecioCompra);
                datos.setearParametro("@PrecioVenta", prod.PrecioVenta);
                datos.setearParametro("@Stock", prod.Stock);
                datos.setearParametro("@Talle", prod.Talle);
                datos.setearParametro("@Imagen", prod.ImagenProducto);
                datos.setearParametro("@Id", prod.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }finally
            {
                datos.cerrarConexion();
            }
        }
        public void notagregarProveedor(DatosProveedor prov)
        {
            AccesoDatos datitos = new AccesoDatos();
            datitos.setearConsulta("");
        }
    }
}

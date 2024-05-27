using Clases;
using Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MartinaProject2024;

namespace MartinaProject2024
{
    public partial class frmAltaProducto : Form
    {
        //private Producto product = null; 
        public frmAltaProducto()
        {
            InitializeComponent();
        }
        public frmAltaProducto(Producto product)
        {
            InitializeComponent();
            //this.product = product;
            //Text = "Modificar Producto";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnAceptar_Click(object sender, EventArgs e) //Insert datos a la BDD.
        {
            Producto nuevoProducto = new Producto();
            ArticuloConexion negocio = new ArticuloConexion();
            try
            {
                //if(nuevoProducto == null)
                //product = new Producto();
                
                nuevoProducto.Nombre = txtNombre.Text;
                nuevoProducto.PrecioCompra = double.Parse(txtPrecioCompra.Text);
                nuevoProducto.PrecioVenta = double.Parse(txtPrecioVenta.Text);
                nuevoProducto.Stock = int.Parse(txtStock.Text);
                nuevoProducto.Talle = txtTalles.Text;
                nuevoProducto.ImagenProducto = txtImagen.Text;
                
                //if(product.Id != 3)
                //{
                //negocio.modificarProducto(product);
                //MessageBox.Show("Modificado exitosamente");
                //}
                //else
                //{
                negocio.agregarProducto(nuevoProducto);
                MessageBox.Show("Agregado exitosamente!");
                Close();
                //}
                //this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }

        }

        private void txtImagen_Leave(object sender, EventArgs e) //Cuando tabulo, llamo la funcion y le paso el string puesto en el Txt.
        {
            cargarImagen(txtImagen.Text); 

                 
        }

        private void cargarImagen(string imagen) //Recibe lo del txt, lo carga si se puede, si no carga imagen por defecto.
        {
            try
            {
                picBoxNuevoProducto.Load(imagen);

            }
            catch (Exception)
            {

                picBoxNuevoProducto.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/991px-Placeholder_view_vector.svg.png");
            }
        }

        private void frmAltaProducto_Load(object sender, EventArgs e)
        {
            //if(product != null)
            //{
            //    txtNombre.Text = product.Nombre;
            //    txtPrecioCompra.Text = product.PrecioCompra.ToString();
            //    txtPrecioVenta.Text = product.PrecioVenta.ToString();
            //    txtStock.Text = product.Stock.ToString();
            //    txtTalles.Text = product.Talle;
            //    txtImagen.Text = product.ImagenProducto;
            //    cargarImagen(product.ImagenProducto); // Le pasamos la imagen cargada en el DGV seleccionada en la grilla.
            //
            //}
        }
    }
}

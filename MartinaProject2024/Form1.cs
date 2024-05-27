using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using Conexion;

namespace MartinaProject2024
{
    public partial class Form1 : Form
    {
        private Producto product;
        private List<Producto> listaProductos;
        public Form1()
        {
            InitializeComponent();
        }
        private void cargar() //Funcion que carga los datos de la BDD a la grilla DGV.
        {
            ArticuloConexion articuloAgregados = new ArticuloConexion();
            try
            {
                listaProductos = articuloAgregados.listar(); //Listar es la lista que devuelve todo lo traido desde SQL.
                dgbProductos.DataSource = listaProductos; 
                cargarImagen(listaProductos[0].ImagenProducto); //PictureOpen = Picture Box.
                dgbProductos.Columns["ImagenProducto"].Visible = false;
                dgbProductos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            //if (product) { }
        }

        private void dgbProductos_SelectionChanged(object sender, EventArgs e)
        {
            Producto seleccionado = (Producto)dgbProductos.CurrentRow.DataBoundItem; //Current row:Fila Actual.
            cargarImagen(seleccionado.ImagenProducto);                           //DBI: Objeto enlazado

        }
        private void cargarImagen(string imagen) //Función que se encarga de cargar imagen con excepecion de imagen PlaceHolder
        {
            try
            {
                pictureOpen.Load(imagen);

            }
            catch (Exception)
            {

                pictureOpen.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/991px-Placeholder_view_vector.svg.png");
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmAltaProducto nuevo = new frmAltaProducto();
            nuevo.ShowDialog();
            cargar();
        }

        private void button2_Click(object sender, EventArgs e) //INSERT A VER PEDIDOS.
        {
                frmVerPedidos pedidosHechos = new frmVerPedidos();
                pedidosHechos.ShowDialog();
        }

        private void btnRegistrarPedidos_Click(object sender, EventArgs e)
        {
            frmRegistrarPedido registrar = new frmRegistrarPedido();
            registrar.ShowDialog();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            Producto seleccionado = new Producto();
            seleccionado = (Producto)dgbProductos.CurrentRow.DataBoundItem;
            frmAltaProducto modificar = new frmAltaProducto(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
    }
}

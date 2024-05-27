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
    public partial class frmRegistrarPedido : Form
    {
        public frmRegistrarPedido()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarPedido_Click(object sender, EventArgs e)
        {
            DatosProveedor provNew = new DatosProveedor();
            ArticuloConexion cone = new ArticuloConexion();
            try
            {
               provNew.Proveedor = txtProveedor.Text;
               provNew.Producto = txtProducto.Text;
               provNew.PrecioUnidad = double.Parse(txtPrecioUnidad.Text);
               provNew.Cantidad = int.Parse(txtCantidad.Text);
               provNew.PrecioTotal = double.Parse(txtPrecioTotal.Text);
               provNew.PrecioEnvio = double.Parse(txtPrecioEnvio.Text);
               provNew.GastoTotal = double.Parse(txtGastoTotal.Text);
               provNew.Fecha = DateTime.Parse(txtFecha.Text);
               
               cone.agregarProveedor(provNew);
               MessageBox.Show("Agregado exitosamente");
               this.Close(); 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}

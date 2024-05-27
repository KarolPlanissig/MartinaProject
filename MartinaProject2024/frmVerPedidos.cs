using Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases; 

namespace MartinaProject2024
{
    public partial class frmVerPedidos : Form
    {
        
        private List<DatosProveedor> listaProveedor;
        public frmVerPedidos()
        {
            InitializeComponent();
        }
        //public frmVerPedidos()
        //{
            //InitializeComponent();
            //this.product = product;
        //}
        private void btnSalirP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVerPedidos_Load(object sender, EventArgs e) //Configuramos la ventana.
        {
            
               AccesoVerPedidos pedidos = new AccesoVerPedidos();
               listaProveedor = pedidos.listarPedidos();
               dgvVerPedido.DataSource = listaProveedor;
            
        } 
    }
}

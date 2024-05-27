using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel; 

namespace Clases
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [DisplayName ("Precio de compra")]
        public double PrecioCompra { get; set; }
        [DisplayName ("Precio de venta")]
        public double PrecioVenta { get; set; }
        public int Stock { get; set; } 
        public string Talle { get; set; }
        [DisplayName("Imagen del producto")]
        public string ImagenProducto { get; set; }  
    }
}

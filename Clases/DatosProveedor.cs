using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Clases
{
    public class DatosProveedor
    {

        public string Proveedor { get; set; }
        public string Producto { get; set; }
        [DisplayName ("Precio por unidad")]
        public double PrecioUnidad { get; set; }
        public int Cantidad { get; set; }
        [DisplayName("Precio total")]
        public double PrecioTotal { get; set; }
        [DisplayName("Precio de envío")]
        public double PrecioEnvio { get; set; }
        [DisplayName("Gasto total")]
        public double GastoTotal { get; set; }
        public DateTime Fecha { get; set; }
    }
}

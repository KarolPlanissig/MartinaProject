using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Venta
    {
        public string ProductoVendido { get; set; }
        public float Monto { get; set; }
        public DateTime Fecha { get; set; }
        public int UnidadadesVendidas { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.clases
{
    public class VentaProductos
    {
        public Producto producto { get; set; }
        public float cantidad { get; set; }
        public decimal total { get; set; }
    }
}

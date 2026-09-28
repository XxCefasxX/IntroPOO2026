using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO2026.clases
{
    internal class Venta
    {
        public string codigoVenta { get; set; }//el numero/codigo de la venta
        public List<VentaProductos> productos { get; set; }//lista de productos
        public DateTime fecha { get; set; }//fecha de venta
        public Empleado empleado { get; set; }//empelado que antendio/realizo la venta
        public decimal total { get; set; }//total de la venta


    }
}

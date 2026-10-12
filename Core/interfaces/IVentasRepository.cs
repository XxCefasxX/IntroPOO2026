using Core.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.interfaces
{
    public interface IVentasRepository
    {
        public void RegistraVenta(Venta venta);
        public void RegistraProductos(List<VentaProductos> productos, string codigoventa);
        public int NextSale();
    }
}

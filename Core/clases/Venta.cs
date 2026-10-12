using Core.repositorios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core.clases
{
    public class Venta
    {
        public string codigoVenta { get;  }//el numero/codigo de la venta
        public List<VentaProductos> productos { get; set; }//lista de productos
        public DateTime fecha { get;  }//fecha de venta
        public Empleado empleado { get;  }//empelado que antendio/realizo la venta
        public decimal total { get; set; }//total de la venta
        public Venta(Empleado usuario)
        {
            codigoVenta = GeneraCodigoVenta();
            fecha = DateTime.Now;
            empleado = usuario;
            productos = new List<VentaProductos>();
        }
        private string GeneraCodigoVenta()
        {

            ResitorioVentas repoVentas = new ResitorioVentas();
            return DateTime.Now.ToString("yyyyMMdd") + repoVentas.NextSale().ToString("000");//20261005 + conseutivo de hoy

        }
 

        public void AgregarProducto(Producto producto, int cantidad)
        {
            //calculamos el total del producto
            decimal totalProducto = producto.Precio * cantidad;

            //creamos instancia del producto a añadir a la lista
            VentaProductos productoVendido = new VentaProductos();

            //asignamos sus valores
            productoVendido.producto = producto;
            productoVendido.cantidad = cantidad;
            productoVendido.total = totalProducto;

            //agregamos el producto vendido a la lista
            productos.Add(productoVendido);

            //calculamos el total de la venta
            total += totalProducto;
        }
    }
}

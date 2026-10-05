using IntroPOO2026.repositorios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IntroPOO2026.clases
{
    internal class Venta
    {
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
        public string codigoVenta { get; set; }//el numero/codigo de la venta
        public List<VentaProductos> productos { get; set; }//lista de productos
        public DateTime fecha { get; set; }//fecha de venta
        public Empleado empleado { get; set; }//empelado que antendio/realizo la venta
        public decimal total { get; set; }//total de la venta

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

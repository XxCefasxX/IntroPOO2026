using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
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
            string codigo = DateTime.Now.ToString("yyyyMMdd");//20261001
            string consulta = "select count(*)+1 from ventas where fecha=curdate()";

            MySqlConnection conn = new MySqlConnection(Utils.connStr);
            MySqlCommand comm = new MySqlCommand(consulta, conn);
            int consecutivo = 0;
            try
            {
                conn.Open();
                MySqlDataReader dr= comm.ExecuteReader();
                if (dr.Read()) 
                {

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            codigo += consecutivo;
            return codigo;
        }
        public string codigoVenta { get; set; }//el numero/codigo de la venta
        public List<VentaProductos> productos { get; set; }//lista de productos
        public DateTime fecha { get; set; }//fecha de venta
        public Empleado empleado { get; set; }//empelado que antendio/realizo la venta
        public decimal total { get; set; }//total de la venta

        public void AgregarProducto(Producto producto,int cantidad)
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
            total += totalProducto ;
        }
    }
}

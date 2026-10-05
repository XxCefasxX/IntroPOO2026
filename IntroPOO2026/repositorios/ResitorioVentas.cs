using IntroPOO2026.clases;
using IntroPOO2026.interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace IntroPOO2026.repositorios
{
    internal class ResitorioVentas : IVentasRepository
    {
        //string connStr = "server=127.0.0.1;uid=root;pwd=123456;database=poo;;AllowLoadLocalInfile=true;";
        public void RegistraProductos(List<VentaProductos> productos, string codigoventa)
        {
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(Utils.connStr);

            string values = "";
            foreach (VentaProductos producto in productos)
            {
                values += $"('{codigoventa}','{producto.producto.ID}','{producto.producto.Precio}','{producto.cantidad}','{producto.total}')";
                if (producto != productos.Last())
                {
                    values += ",";
                }
            }
            MySql.Data.MySqlClient.MySqlCommand comm = new MySql.Data.MySqlClient.MySqlCommand("insert into venta_productos (codigoventa,idproducto,precio,cantidad,total)" +
               $"values{values}", conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public async void metodo2(List<VentaProductos> productos, string codigoventa)
        {
            MySqlConnector.MySqlConnection conn = new MySqlConnector.MySqlConnection(Utils.connStr);
            var bulkCopy = new MySqlBulkCopy(conn);

            bulkCopy.DestinationTableName = "venta_productos";
            DataTable tabla = new DataTable();

            tabla.Columns.Add("codigoventa", typeof(string));
            tabla.Columns.Add("idproducto", typeof(int));
            tabla.Columns.Add("cantidad", typeof(float));
            tabla.Columns.Add("precio", typeof(decimal));
            tabla.Columns.Add("total", typeof(decimal));
            bulkCopy.ColumnMappings.Add(
    new MySqlBulkCopyColumnMapping(0, "codigoventa"));

            bulkCopy.ColumnMappings.Add(
                new MySqlBulkCopyColumnMapping(1, "idproducto"));

            bulkCopy.ColumnMappings.Add(
                new MySqlBulkCopyColumnMapping(2, "cantidad"));

            bulkCopy.ColumnMappings.Add(
                new MySqlBulkCopyColumnMapping(3, "precio"));

            bulkCopy.ColumnMappings.Add(
                new MySqlBulkCopyColumnMapping(4, "total"));



            foreach (VentaProductos producto in productos)
            {
                tabla.Rows.Add(
                    codigoventa,
                    producto.producto.ID,
                    producto.cantidad,
                    producto.producto.Precio,
                    producto.total
                );
            }
            await bulkCopy.WriteToServerAsync(tabla);
        }
        public async void RegistraVenta(Venta venta)
        {


            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(Utils.connStr);
            MySql.Data.MySqlClient.MySqlCommand comm = new MySql.Data.MySqlClient.MySqlCommand("Insert into ventas(codigoventa,idempleado,fecha,total) values(@codigo,@empleado,@fecha,@total);", conn);
            comm.Parameters.AddWithValue("@codigo", venta.codigoVenta);
            comm.Parameters.AddWithValue("@empleado", venta.empleado.ID);
            comm.Parameters.AddWithValue("@fecha", venta.fecha);
            comm.Parameters.AddWithValue("@total", venta.total);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                //Console.WriteLine("Procuto actualizado");
                RegistraProductos(venta.productos, venta.codigoVenta);
                //metodo2(venta.productos, venta.codigoVenta);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

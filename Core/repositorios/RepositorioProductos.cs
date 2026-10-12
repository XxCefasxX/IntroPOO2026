using Core.clases;
using Core.interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.repositorios
{
    public class RepositorioProductos : IRepository<Producto>
    {


        
        public void Actualizar(Producto producto)
        {
            MySqlConnection conn = new MySqlConnection(Utils.connStr);
            MySqlCommand comm = new MySqlCommand("update productos set nombre=@nombre, precio=@precio where id=@id);", conn);
            comm.Parameters.AddWithValue("@nombre", producto.Nombre);
            comm.Parameters.AddWithValue("@salario", producto.Precio);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                Console.WriteLine("Procuto actualizado");
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

        public void Borrar(Producto producto)
        {
            MySqlConnection conn = new MySqlConnection(Utils.connStr);
            MySqlCommand comm = new MySqlCommand("delete from productos where id=@id", conn);
            comm.Parameters.AddWithValue("@ID", producto.ID);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                Console.WriteLine("Empleado borrado");
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

        public List<Producto> Buscar(string nombre)
        {
            List<Producto> lista = new List<Producto>();
            MySqlConnection conn = new MySqlConnection(Utils.connStr);
            MySqlCommand comm = new MySqlCommand("select * from productos", conn);
            try
            {

                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        Producto prod = new Producto();
                        prod.ID = Convert.ToInt32(dr["id"].ToString());
                        prod.Nombre = dr["nombre"].ToString();
                        prod.Precio = Convert.ToDecimal(dr["salario"].ToString());

                        lista.Add(prod);
                    }
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
            return lista;
        }

        public List<Producto> Lista()
        {
            List<Producto> lista = new List<Producto>();
            MySqlConnection conn = new MySqlConnection(Utils.connStr);
            MySqlCommand comm = new MySqlCommand("select * from productos", conn);
            try
            {

                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        Producto prod = new Producto();
                        prod.ID = Convert.ToInt32(dr["id"].ToString());
                        prod.Nombre = dr["nombre"].ToString();
                        prod.Precio = Convert.ToDecimal(dr["salario"].ToString());

                        lista.Add(prod);
                    }
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
            return lista;
        }

        public void Registro(Producto producto)
        {
            MySqlConnection conn = new MySqlConnection(Utils.connStr);
            MySqlCommand comm = new MySqlCommand("insert into productos(nombre,precio) values(@nombre,@precio);", conn);
            comm.Parameters.AddWithValue("@nombre", producto.Nombre);
            comm.Parameters.AddWithValue("@precio", producto.Precio);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                Console.WriteLine("Producto registrado");
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

        public Response<Producto> GetById(int id)
        {
            Producto producto = new Producto();
            Response<Producto> response = new Response<Producto>();
           
            MySqlConnection conn = new MySqlConnection(Utils.connStr);
            MySqlCommand comm = new MySqlCommand("select * from productos where id=@ID", conn);
            comm.Parameters.AddWithValue("@id", id);
            try
            {

                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                       
                        producto.ID = Convert.ToInt32(dr["id"].ToString());
                        producto.Nombre = dr["nombre"].ToString();
                        producto.Precio = Convert.ToDecimal(dr["precio"].ToString());

                        response.Code = 1;
                        response.Message = "Producto encontrado";
                        response.Data = producto;
                    }
                }
                else
                {
                    response.Code = 2;
                    response.Message = "Producto no encontrado";
                    response.Data = null;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                response.Code = 0;
                response.Message = $"Ocurrio un error, {ex.Message}";
                response.Data = null;
            }
            finally
            {
                conn.Close();
            }

            return response;
        }

        
    }
}

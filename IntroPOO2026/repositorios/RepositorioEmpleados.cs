using IntroPOO2026.clases;
using IntroPOO2026.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace IntroPOO2026.repositorios
{
    internal class RepositorioEmpleados : IRepository<Empleado>
    {
        string connStr = "server=127.0.0.1;uid=root;pwd=123456;database=poo";
        public void Actualizar(Empleado empleado)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand comm = new MySqlCommand("update empelados set nombre=@nombre, salario=@salario,edad=@edad where id=@id);", conn);
            comm.Parameters.AddWithValue("@nombre", empleado.Nombre);
            comm.Parameters.AddWithValue("@salario", empleado.Salario);
            comm.Parameters.AddWithValue("@edad", empleado.Edad);
            comm.Parameters.AddWithValue("@id", empleado.ID);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                Console.WriteLine("Empleado actualizado");
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

        public void Borrar(Empleado empleado)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand comm = new MySqlCommand("delete from empleados where id=@id", conn);
            comm.Parameters.AddWithValue("@ID", empleado.ID);
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

        public List<Empleado> Buscar(string nombre)
        {
            List<Empleado> lista = new List<Empleado>();
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand comm = new MySqlCommand("select * from empelados where nombre like '%'@nombre'%'", conn);
            comm.Parameters.AddWithValue("@nombre", nombre);
            try
            {

                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        Empleado empleado = new Empleado();
                        empleado.ID = Convert.ToInt32(dr["id"].ToString());
                        empleado.Nombre = dr["nombre"].ToString();
                        empleado.Edad = Convert.ToInt32(dr["Edad"].ToString());
                        empleado.Salario = Convert.ToInt32(dr["salario"].ToString());

                        lista.Add(empleado);
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

        public List<Empleado> Lista()
        {
            List<Empleado> lista = new List<Empleado>();
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand comm = new MySqlCommand("select * from empelados", conn);
            try
            {

                conn.Open();
                MySqlDataReader dr= comm.ExecuteReader();
                if (dr.HasRows)
                {
                   
                    while (dr.Read())
                    {
                        Empleado empleado = new Empleado();
                        empleado.ID = Convert.ToInt32(dr["id"].ToString());
                        empleado.Nombre = dr["nombre"].ToString();
                        empleado.Edad = Convert.ToInt32(dr["Edad"].ToString());
                        empleado.Salario = Convert.ToInt32(dr["salario"].ToString());
                        //Console.WriteLine($"{empleado.ID} - {empleado.Nombre} - {empleado.Edad} - {empleado.Salario}");
                       
                        lista.Add(empleado);
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

        public void Registro(Empleado empleado)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand comm = new MySqlCommand("insert into empleados(nombre,salario,edad) values(@nombre,@salario,@edad);", conn);
            comm.Parameters.AddWithValue("@nombre",empleado.Nombre);
            comm.Parameters.AddWithValue("@salario",empleado.Salario);
            comm.Parameters.AddWithValue("@edad",empleado.Edad);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                Console.WriteLine("Empleado registrado");
            }
            catch(Exception ex)
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

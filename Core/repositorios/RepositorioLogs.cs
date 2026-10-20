using Core.clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.repositorios
{
    public class RepositorioLogs
    {
        public void Registro(Log log)
        {
            if (log.tipo == 1)//tipo error
            {
                File.AppendAllText($"{log.fecha.ToString("yyyyMMdd")}.txt",
               $"{log.fecha.ToString("HH:mm:ss")} | " +
               $"{log.ex.Message} | " +
               $"{log.ex.StackTrace} | " +
               $"{log.empleado.ID.ToString()}{Environment.NewLine}");
            }
            else if (log.tipo == 2)//movimientos
            {
                File.AppendAllText($"{log.fecha.ToString("yyyyMMddMovs")}.txt",
               $"{log.fecha.ToString("HH:mm:ss")} | " +
               $"{log.ex.Message} | " +
               $"{log.ex.StackTrace} | " +
               $"{log.empleado.ID.ToString()}{Environment.NewLine}");
            }
           
        }

        public void RegistroDB(Log log)
        {
            MySqlConnection conn = new MySqlConnection(Utils.connStr);
            MySqlCommand comm = new MySqlCommand("Insert into logs (fecha,mensaje,stacktrace,empleado, tipo)" +
                "values(@fecha,@mensaje,@stack,@empleado,@tipo) ", conn);
            comm.Parameters.AddWithValue("@fecha", log.fecha);
            comm.Parameters.AddWithValue("@mensaje", log.ex.Message);
            comm.Parameters.AddWithValue("@stack", log.ex.StackTrace);
            comm.Parameters.AddWithValue("@empleado", log.empleado.ID);
            comm.Parameters.AddWithValue("@tipo", log.tipo);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}

using Core.clases;
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
            File.AppendAllText($"{log.fecha.ToString("yyyyMMdd")}.txt",
                $"{log.fecha.ToString("HH:mm:ss")} | " +
                $"{log.ex.Message} | " +
                $"{log.ex.StackTrace} | " +
                $"{log.empleado.ID.ToString()}{Environment.NewLine}");
        }
    }
}

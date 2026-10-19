using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.clases
{
    public class Log
    {
        public DateTime fecha { get; set; }
        public Exception ex { get; set; }
        public Empleado empleado { get; set; }
        public int tipo { get; set; }
    }
}

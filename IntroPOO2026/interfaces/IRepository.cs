using IntroPOO2026.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO2026.interfaces
{
    internal interface IRepository<T>
    {
        public void Registro(T empleado);
        public void Actualizar(T empleado);
        public void Borrar(T empleado);
    }
}

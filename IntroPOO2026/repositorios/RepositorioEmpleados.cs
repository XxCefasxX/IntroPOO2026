using IntroPOO2026.clases;
using IntroPOO2026.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO2026.repositorios
{
    internal class RepositorioEmpleados : IRepository<Empleado>
    {
        public void Actualizar(Empleado empleado)
        {
            Console.WriteLine("Empleado actualizado");
        }

        public void Borrar(Empleado empleado)
        {
            Console.WriteLine("Empleado borrado");

        }

        public void Registro(Empleado empleado)
        {
            Console.WriteLine("Empleado registrado");

        }
    }
}

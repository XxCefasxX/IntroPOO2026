using IntroPOO2026.clases;
using IntroPOO2026.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO2026.repositorios
{
    internal class RepositorioProductos : IRepository<Producto>
    {
        public void Actualizar(Producto producto)
        {
            Console.WriteLine("Producto actualizado");

        }

        public void Borrar(Producto producto)
        {
            Console.WriteLine("Producto borrado");
        }

        public void Registro(Producto producto)
        {
            Console.WriteLine("Producto registrado");
        }
    }
}

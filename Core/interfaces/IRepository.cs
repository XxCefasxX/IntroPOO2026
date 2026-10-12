using Core.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.interfaces
{
    public interface IRepository<T>
    {
        public void Registro(T empleado);
        public void Actualizar(T empleado);
        public void Borrar(T empleado);
        public List<T> Lista();
        public List<T> Buscar(string nombre);
        public Response<T> GetById(int id);
    }
}

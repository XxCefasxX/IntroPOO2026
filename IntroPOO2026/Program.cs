

using IntroPOO2026.clases;
using IntroPOO2026.repositorios;

Console.WriteLine("Menu:");
Console.WriteLine("1-Empleados");
Console.WriteLine("2-Productos");
string o = Console.ReadLine();
Console.WriteLine("Que movimiento realizara?");
Console.WriteLine("R- Registrar");
Console.WriteLine("B- Borrar");
Console.WriteLine("A- Actualizar");
string m=Console.ReadLine();


switch (o)
{
    case "1":
        RepositorioEmpleados repoempleados = new RepositorioEmpleados();

        Empleado empleado = new Empleado();

        switch (m)
        {
            case "R":
                Console.WriteLine("Nombre del empleado:");
                empleado.Nombre = Console.ReadLine();
                Console.WriteLine("Salario del empleado:");
                empleado.Salario = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Edad del empleado:");
                empleado.Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ID del empleado:");
                empleado.ID = 0;

                repoempleados.Registro(empleado);
                break;

            case "B":

                empleado.ID = 0;

                repoempleados.Borrar(empleado);
                break;

            case "A":
                empleado.Nombre = "";
                empleado.Salario = 0;
                empleado.ID = 0;
                empleado.Edad = 0;
                repoempleados.Actualizar(empleado);
                break;
        }
      

        break;
    case "2":
        RepositorioProductos repoProductos = new RepositorioProductos();

        break;
}


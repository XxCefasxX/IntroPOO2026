

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
Console.WriteLine("V- Ver lista");
string m=Console.ReadLine().ToUpper();


switch (o)
{
    case "1":
        RepositorioEmpleados repoempleados = new RepositorioEmpleados();

        Empleado empleado = new Empleado();
        List<Empleado> listaempelados = repoempleados.Lista();
        switch (m)
        {
             
            case "R":
                Console.WriteLine("Nombre del empleado:");
                empleado.Nombre = Console.ReadLine();
                Console.WriteLine("Salario del empleado:");
                empleado.Salario = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Edad del empleado:");
                empleado.Edad = Convert.ToInt32(Console.ReadLine());
                

                repoempleados.Registro(empleado);
                break;

            case "B":

                Console.WriteLine("ID  |  Nombre  |  Edad  |  Salario");
                foreach (Empleado empl in listaempelados)
                {
                    Console.WriteLine($"{empl.ID} | {empl.Nombre} | {empl.Edad} | ${empl.Salario}");

                }
                Console.WriteLine("ID del empleado:");
                empleado.ID = Convert.ToInt32(Console.ReadLine()); 

                repoempleados.Borrar(empleado);
                break;

            case "A":
                foreach (Empleado empl in listaempelados)
                {
                    Console.WriteLine($"{empl.ID}  {empl.Nombre} - {empl.Edad} - {empl.Salario}");

                }
                Console.WriteLine("Nombre del empleado:");
                empleado.Nombre = Console.ReadLine();
                Console.WriteLine("Salario del empleado:");
                empleado.Salario = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Edad del empleado:");
                empleado.Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ID del empleado:");
                empleado.ID = Convert.ToInt32(Console.ReadLine());
                repoempleados.Actualizar(empleado);
                break;
            case "V":
               
                for(int i = 0; i < listaempelados.Count; i++)
                {
                    Empleado empl = listaempelados[i];
                    Console.WriteLine($"{empl.ID} - {empl.Nombre} - {empl.Edad} - {empl.Salario}");

                }
                break;
        }
      

        break;
    case "2":
        RepositorioProductos repoProductos = new RepositorioProductos();
        Producto producto = new Producto();
        switch (m)
        {
            case "R":
                Console.WriteLine("Nombre del producto:");
                producto.Nombre = Console.ReadLine();
                Console.WriteLine("Precio del producto:");
                producto.Precio = Convert.ToInt32(Console.ReadLine());
               
                Console.WriteLine("ID del producto:");
                producto.ID = Convert.ToInt32(Console.ReadLine());

                repoProductos.Registro(producto);
                break;

            case "B":

            

                Console.WriteLine("ID del producto:");
                producto.ID = Convert.ToInt32(Console.ReadLine());

                repoProductos.Registro(producto);
                break;

            case "A":
                Console.WriteLine("Nombre del producto:");
                producto.Nombre = Console.ReadLine();
                Console.WriteLine("Precio del producto:");
                producto.Precio = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ID del producto:");
                producto.ID = Convert.ToInt32(Console.ReadLine());
                repoProductos.Registro(producto);
                break;
        }
        break;
}




using IntroPOO2026.clases;
using IntroPOO2026.repositorios;

Empleado usuario = new Empleado();

Console.WriteLine("Menu:");
Console.WriteLine("1-Empleados");
Console.WriteLine("2-Productos");
Console.WriteLine("3-Tienda");
string o = Console.ReadLine();



switch (o)
{
    case "1":
        Console.WriteLine("Que movimiento realizara?");
        Console.WriteLine("R- Registrar");
        Console.WriteLine("B- Borrar");
        Console.WriteLine("A- Actualizar");
        string me = Console.ReadLine();
        RepositorioEmpleados repoempleados = new RepositorioEmpleados();

        Empleado empleado = new Empleado();

        switch (me)
        {
            case "R":
                Console.WriteLine("Nombre del empleado:");
                empleado.Nombre = Console.ReadLine();
                Console.WriteLine("Salario del empleado:");
                empleado.Salario = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Edad del empleado:");
                empleado.Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ID del empleado:");
                empleado.ID = Convert.ToInt32(Console.ReadLine());

                repoempleados.Registro(empleado);
                break;

            case "B":

                Console.WriteLine("ID del empleado:");
                empleado.ID = Convert.ToInt32(Console.ReadLine()); 

                repoempleados.Borrar(empleado);
                break;

            case "A":
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
        }
      

        break;
    case "2":
        Console.WriteLine("Que movimiento realizara?");
        Console.WriteLine("R- Registrar");
        Console.WriteLine("B- Borrar");
        Console.WriteLine("A- Actualizar");
        string mp = Console.ReadLine();
        RepositorioProductos repoProductos = new RepositorioProductos();
        Producto producto = new Producto();
        switch (mp)
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
    case "3":
        Console.WriteLine("Que movimiento realizara?");
        Console.WriteLine("V- Vender");
        Console.WriteLine("H- Historial");
        string mt = Console.ReadLine().ToUpper();
        switch (mt)
        {
            case "V":
                Venta venta= new Venta();
                venta.codigoVenta = DateTime.Now.ToString("yyyyMMddss");
                venta.fecha = DateTime.Now;
                venta.empleado = usuario;
                //agregar productos a la venta
                Console.WriteLine("Ingreese codigo de producto:");
                int codigoProducto = Convert.ToInt32(Console.ReadLine());
                //preguntar si agrega otro o cobrar
                //si es agregar otro repetir pasos correspondientes
                //si es cobrar solo mostrar mensaje cobrado
                break;
        }
        break;
}


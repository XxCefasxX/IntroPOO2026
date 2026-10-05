

using IntroPOO2026;
using IntroPOO2026.clases;
using IntroPOO2026.repositorios;

Empleado usuario = new Empleado();
usuario.ID = 1;

Console.WriteLine("Menu:");
Console.WriteLine("1-Empleados");
Console.WriteLine("2-Productos");
Console.WriteLine("3-Tienda");
string o = Console.ReadLine();

RepositorioProductos repoProductos = new RepositorioProductos();
ResitorioVentas repoVentas = new ResitorioVentas();

switch (o)
{
    case "1":
        Console.WriteLine("Que movimiento realizara?");
        Console.WriteLine("R- Registrar");
        Console.WriteLine("B- Borrar");
        Console.WriteLine("A- Actualizar");
        Console.WriteLine("V- Ver lista");
        string me = Console.ReadLine();
        RepositorioEmpleados repoempleados = new RepositorioEmpleados();

        Empleado empleado = new Empleado();
        empleado.ID = 1;
        List<Empleado> listaempelados = repoempleados.Lista();
        switch (me)
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

                for (int i = 0; i < listaempelados.Count; i++)
                {
                    Empleado empl = listaempelados[i];
                    Console.WriteLine($"{empl.ID} - {empl.Nombre} - {empl.Edad} - {empl.Salario}");

                }
                break;
        }
      

        break;
    case "2":

        Producto producto = new Producto();

        Console.WriteLine("Que movimiento realizara?");
        Console.WriteLine("R- Registrar");
        Console.WriteLine("B- Borrar");
        Console.WriteLine("A- Actualizar");
        Console.WriteLine("V- Ver lista");
        string mp = Console.ReadLine();

       
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
            case "V":
                List<Producto> listaprod = repoProductos.Lista();

                foreach (Producto prod in listaprod)
                {
                    Console.WriteLine($"{prod.ID} - {prod.Nombre} - ${prod.Precio} ");
                }
                break;
        }
        break;
    case "3":
        Console.WriteLine("Que movimiento realizara?");
        Console.WriteLine("V- Vender");
        Console.WriteLine("H- Historial");
        string mt = Console.ReadLine().ToUpper();
        Console.Clear();
        switch (mt)
        {
            case "V":
                string p = "P";
                Venta venta = new Venta(usuario);
               
                
                
                while (p == "P")
                {
                    
                    //agregar productos a la venta
                    Console.WriteLine("Ingreese codigo de producto:");
                    int codigoProducto = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cantidad de producto:");
                    int cantidad=Convert.ToInt32(Console.ReadLine());

                    //obtenemos el producto por medio de su id
                    Producto infoProduct = repoProductos.GetById(codigoProducto);

                    venta.AgregarProducto(infoProduct, cantidad);

                    //preguntar si agrega otro o cobrar
                    Console.WriteLine("Desea agregar otro producto o Cobrar");
                    Console.WriteLine("P- agregar otro producto");
                    Console.WriteLine("C- Cobrar");
                    p= Console.ReadLine().ToUpper();
                    Console.Clear();
            
                }
                Console.WriteLine("Cobrando...");
                Console.WriteLine("producto---precio unitario-------cantidad--------------total");
                foreach(VentaProductos prod in venta.productos)
                {
                    Console.WriteLine($"{prod.producto.Nombre}    " +
                        $"${prod.producto.Precio}          " +
                        $"{prod.cantidad}             " +
                        $"${prod.total}");
                }
                Console.WriteLine($"Total: ${venta.total}");
                repoVentas.RegistraVenta(venta);
                //mostrar en pantalla detalles de la venta
                /* producto---precio unitario-------cantidad--------------total
                 * Manzanas       25                  2                    50.00
                 * Queso          100                 1                    100.00
                 * Total---------------------------------------------------150.00
                */
                //---------Guardar en base de datos las ventas---------
                //con todos los datos
                /*aqui es importante tomar en cuenta que son 2 tablas distintas,
                 * una para la informacion de la venta
                 * y otra para los detalles(lista de productos), estos deben de etar relacionados a la venta
                 -------En el menu de ventas dar opcion de ver ventas
                *ver la lista de ventas
                 */

                break;
        }
        break;
}


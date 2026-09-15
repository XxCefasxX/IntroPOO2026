


DateTime nacimiento = Convert.ToDateTime("1995/09/25");
//Instancia de la clase Persona
Persona persona = new Persona(name: "Juan", apellidoP: "Perez", apellidoM: "Hernandez", fechaNacimiento: nacimiento);


DateTime nacimiento2 = Convert.ToDateTime("1995/09/14");
Persona persona2 = new Persona(apellidoP: "Garcia", apellidoM: "Lopez", fechaNacimiento: nacimiento2, name: "Maria");


//Mostrar en pantalla los datos asignados
Console.WriteLine($"la persona 1 es {persona.Name} {persona.ApellidoP} " +
    $"{persona.ApellidoM} y tiene la edad de:{persona.Edad} años");

Console.WriteLine($"la persona 2 es {persona2.Name} {persona2.ApellidoP} " +
    $"{persona2.ApellidoM} y tiene la edad de:{persona2.Edad} años");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Persona
{

    public string Name { get; }
    public int Edad { get; }
    public string ApellidoP { get; }
    public string ApellidoM { get; }
    public DateTime FechaNacimiento { get; }

    public Persona(string name, string apellidoP, string apellidoM, DateTime fechaNacimiento)
    {
        Name = name;
        FechaNacimiento = fechaNacimiento;
        Edad = CalcularEdad(fechaNacimiento);
        ApellidoP = apellidoP;
        ApellidoM = apellidoM;
    }
    
    private int CalcularEdad(DateTime fechaNacimiento)
    { 
        DateTime hoy = DateTime.Today;

        int Edad = hoy.Year - fechaNacimiento.Year;

        DateTime aux = hoy.AddYears(-Edad);

        if (fechaNacimiento.Date > aux)
        {
            Edad--;
        }
        return Edad;
    }
}


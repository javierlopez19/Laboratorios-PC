using System;

class Persona
{
 
    public string nombre;
    public int edad;
    public double altura;
    public bool estudiante;
}

class Program
{
    static void Main(string[] args)
    {

        Persona persona1 = new Persona();

        persona1.nombre = "Javier";
        persona1.edad = 21;
        persona1.altura = 1.83;
        persona1.estudiante = true;

        Console.WriteLine("Nombre: " + persona1.nombre);
        Console.WriteLine("Edad: " + persona1.edad);
        Console.WriteLine("Altura: " + persona1.altura + " m");
        Console.WriteLine("¿Es estudiante?: " + persona1.estudiante);

        Console.ReadKey();
    }
}



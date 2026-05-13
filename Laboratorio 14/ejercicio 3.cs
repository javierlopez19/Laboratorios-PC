using System;
public class Estudiante
{
    private string nombre;
    private int edad;
    private string grado;
    private decimal[] notas;

    public Estudiante(string nombre, int edad, string grado, decimal[] notas)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.grado = grado;
        this.notas = notas;
    }
    public decimal CalcularPromedio()
    {
        decimal suma = 0;
        foreach (var nota in notas)
        {
            suma += nota;
        }
        return suma / notas.Length;

    }
    public void MostrarInformacion()
    {

        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad : " + edad);
        Console.WriteLine("Grado: " + grado);
        Console.WriteLine("Notas: " + string.Join(", ", notas));
        Console.WriteLine("Promedio: " + CalcularPromedio());
        Console.WriteLine("Aprueba: " + (CalcularPromedio() >= 60 ? "Sí" : "No"));
        Console.WriteLine("");
    }

    public bool Aprobo()
    {
        return CalcularPromedio() >= 61;
    }

    public void AgregarNota(decimal nuevaNota)
    {
        decimal[] nuevasNotas = new decimal[notas.Length + 1];
        for (int i = 0; i < notas.Length; i++)
        {
            nuevasNotas[i] = notas[i];
        }
        nuevasNotas[nuevasNotas.Length - 1] = nuevaNota;
        notas = nuevasNotas;

        Console.WriteLine("Se agregó la nota: " + nuevaNota + " a la/el estudiante" + nombre);
    }

    

}

class Program
{

    static void Main(string[] args)
    {

        Estudiante estudiante1 = new Estudiante("Javier", 21, "4to año", new decimal[] { 75, 80, 90 });
        Estudiante estudiante2 = new Estudiante("Silvia", 22, "5to año", new decimal[] { 50, 59, 45 });

        Console.WriteLine(" Información incial de lso Estudiantes es: ");
        estudiante1.MostrarInformacion();
        estudiante2.MostrarInformacion();
        Console.WriteLine("");

        Console.WriteLine("Agregando una nueva nota a Silvia...");
        estudiante2.AgregarNota(83);
        estudiante2.MostrarInformacion();



    }


}


using System;

class Program
{

    static string ElevarCuadrado(ref int numero)
    {
        numero = numero * numero;
        return "La operación fue realizada correctamente.";
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese un número entero: ");
        int n = int.Parse(Console.ReadLine());


        string mensaje = ElevarCuadrado(ref n);

        Console.WriteLine(mensaje);
        Console.WriteLine("El número elevado al cuadrado es: " + n);
    }
}

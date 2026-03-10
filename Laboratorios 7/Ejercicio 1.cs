using System;

class Program
{
    static void Main()
    {
        int N = 0;
      
        while (N <= 0)
        {
            Console.WriteLine("¿Cuántos números desea sumar?");
            N = int.Parse(Console.ReadLine());
        }

        int contador = 1;
        double numero;
        double suma = 0;

        while (contador <= N)
        {
            Console.WriteLine("Ingrese el número " + contador + ":");
            numero = double.Parse(Console.ReadLine());

            suma += numero;
            contador++;
        }

        double promedio = suma / N;

        Console.WriteLine("La suma total es: " + suma);
        Console.WriteLine("El promedio es: " + promedio);


    }
}

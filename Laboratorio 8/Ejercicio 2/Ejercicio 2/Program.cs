using System;

class Program
{
    static void Main()
    {
     
        Console.Write("Ingresa un número entero: ");
        int n = int.Parse(Console.ReadLine());

      
        int suma = 0;
        int pares = 0;
        int impares = 0;

        for (int i = 1; i <= n; i++)
        {
            suma = suma + i;       

            if (i % 2 == 0)
                pares++;           
            else
                impares++;         
        }

        Console.WriteLine("Suma del 1 al " + n + ": " + suma);
        Console.WriteLine("Cantidad de números pares: " + pares);
        Console.WriteLine("Cantidad de números impares: " + impares);
    }
}
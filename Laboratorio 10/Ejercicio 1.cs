using System;

class Program
{
    
    static int SumaDigitos(int numero)
    {
        int suma = 0;

        while (numero > 0)
        {
            int digito = numero % 10;   
            suma += digito;            
            numero = numero / 10;       
        }

        return suma;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese un número entero positivo: ");
        int n = int.Parse(Console.ReadLine());

        int resultado = SumaDigitos(n);

        Console.WriteLine("La suma de los dígitos es: " + resultado);
    }
}


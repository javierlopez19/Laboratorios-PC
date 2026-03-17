using System;

class Program
{
    static void Main()
    {
        int numero = 0;
        int cantidad = 0;
        int positivos = 0;
        int negativos = 0;
        int suma = 0;

        Console.Write("Ingresa un número (0 para terminar): ");
        numero = int.Parse(Console.ReadLine());

        while (numero != 0)
        {
            cantidad++;
            suma = suma + numero;

            if (numero > 0)
                positivos++;
            else if (numero < 0)
                negativos++;

            Console.Write("Ingresa un número (0 para terminar): ");
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Números ingresados: " + cantidad);
        Console.WriteLine("Números positivos: " + positivos);
        Console.WriteLine("Números negativos: " + negativos);
        Console.WriteLine("Suma total: " + suma);

    }
}

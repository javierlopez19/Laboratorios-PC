using System;

class Program
{
    static void Main()
    {

        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);

        int intento = 0;
        int numero = 0;

        while (numero != numeroSecreto)
        {
            Console.WriteLine("Adivina el número (entre 1 y 100): ");
            numero = int.Parse(Console.ReadLine());

            if (numero < 1 || numero > 100)
            {
                Console.WriteLine("Número fuera de rango. Intente nuevamente.");
                continue;
            }

            intento++;

            if (numero < numeroSecreto)
            {
                Console.WriteLine("Más alto");
            }
            else if (numero > numeroSecreto)
            {
                Console.WriteLine("Más bajo");
            }
        }

        Console.WriteLine("¡Correcto!");
        Console.WriteLine("Intentos: " + intento);


    }
}

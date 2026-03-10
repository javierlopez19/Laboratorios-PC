using System;

class Program
{
    static void Main()
    {

        int opcion;

        do
        {
            Console.WriteLine("MENU DE CONVERSION");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Kilómetros a Millas");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Seleccione una opción:");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese grados Celsius:");
                    double c = double.Parse(Console.ReadLine());
                    double f = (c * 9 / 5) + 32;
                    Console.WriteLine("Resultado: " + f.ToString("0.00"));
                    break;

                case 2:
                    Console.WriteLine("Ingrese grados Fahrenheit:");
                    double fa = double.Parse(Console.ReadLine());
                    double ce = (fa - 32) * 5 / 9;
                    Console.WriteLine("Resultado: " + ce.ToString("0.00"));
                    break;

                case 3:
                    Console.WriteLine("Ingrese kilómetros:");
                    double km = double.Parse(Console.ReadLine());
                    double millas = km * 0.621371;
                    Console.WriteLine("Resultado: " + millas.ToString("0.00"));
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            Console.WriteLine();

        } while (opcion != 4);
    }
}


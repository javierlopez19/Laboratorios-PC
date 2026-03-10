using System;

class Program
{
    static void Main()
    {
        int pinCorrecto = 1234;
        int pin;
        int intentos = 0;

        do
        {
            Console.WriteLine("Ingrese el PIN:");
            pin = int.Parse(Console.ReadLine());

            intentos++;

            if (pin == pinCorrecto)
            {
                Console.WriteLine("Acceso concedido");
                break;
            }
            else
            {
                Console.WriteLine("PIN incorrecto");
            }

        } while (intentos < 3);

        if (pin != pinCorrecto && intentos == 3)
        {
            Console.WriteLine("Cuenta bloqueada");
        }
    }
}

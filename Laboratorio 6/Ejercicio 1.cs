using System;
class Program
{
    static void Main()
    {

        Console.WriteLine("Escoja el vehículo que le interese (1. Bicicleta, 2. Motocicleta, 3. Auto, 4. Camión, 5. Autobús)");
        int opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1: Console.WriteLine("Bicicleta es un vehículo no motorizado"); break;
            case 2: Console.WriteLine("Motocicleta es un vehículo ligero"); break;
            case 3: Console.WriteLine("Auto es un vehículo mediano"); break;
            case 4: Console.WriteLine("Camión es un vehículo pesado"); break;
            case 5: Console.WriteLine("Autobus es un vehículo de transporte público"); break;
            default: Console.WriteLine("Error, opción no es válida en este programa"); break;

    }



    }
}

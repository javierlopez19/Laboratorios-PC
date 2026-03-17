using System;

class Program
{
    static void Main()
    {
        int opcion = 0;
        double totalVentas = 0;
        int cantidadClientes = 0;

        do
        { 
            Console.WriteLine("1) Registrar compra");
            Console.WriteLine("2) Mostrar total de ventas");
            Console.WriteLine("3) Mostrar cantidad de clientes atendidos");
            Console.WriteLine("4) Salir");
            Console.Write("Selecciona una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa el monto de la compra: ");
                    double monto = double.Parse(Console.ReadLine());
                    totalVentas = totalVentas + monto;
                    cantidadClientes++;
                    Console.WriteLine("Compra registrada correctamente.");
                    break;

                case 2:
                    Console.WriteLine("Total de ventas del día: " + totalVentas);
                    break;

                case 3:
                    Console.WriteLine("Clientes atendidos: " + cantidadClientes);
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida, intenta de nuevo.");
                    break;
            }

        } while (opcion != 4);
    }
}
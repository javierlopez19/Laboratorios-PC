using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("El Banco Industrial ha decidido aumentar el límite de crédito en sus tarjetas");
        Console.WriteLine("Ingrese su límite actual en Quetzales");
        double limite = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese que tipo de cliente es, 1, 2, 3 u otro 4: ");
        int cliente = int.Parse(Console.ReadLine());


        switch (cliente)
        {
            case 1:
                double aumento = limite * 0.25;
                double nuevolimite = limite + aumento;
                Console.WriteLine("su aumento es del 25% entonces su nuevo limite es: Q" + nuevolimite);
                     break;
            case 2:
                double aumento2 = limite * 0.35;
                double nuevolimite2 = limite + aumento2;
                Console.WriteLine("Su aumento es del 35% entonces su nuevo limite es: Q" + nuevolimite2);
                 break;
            case 3:
                double aumento3 = limite * 0.40;
                double nuevolimite3 = limite + aumento3;
                Console.WriteLine("Su aumento es del 40% entonces su nuevo limite es: Q" + nuevolimite3);
                 break;
            default:
                double aumento4 = limite * 0.50;
                double nuevolimite4 = limite + aumento4;
                Console.WriteLine("Su aumento es del 50% entonces su nuevo limite es: Q" + nuevolimite4);
                break;
        }


      



    }
}
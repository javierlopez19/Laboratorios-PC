using System.ComponentModel.Design;
using System.Drawing;

class Class
{
    static void Main()
    {

        Console.WriteLine("Ingrese el PIN: ");
        int PIN = int.Parse(Console.ReadLine());
        

        if (PIN >= 1000 && PIN <= 9999)
        {
            Console.WriteLine("PIN de 4 digitos: OK ");
           
        }
        else
        {
            Console.WriteLine("PIN invalido, debe tener 4 digitos");
           
        }

        if (PIN % 2 == 0)
        {
            Console.WriteLine("PIN es par");
            
        }
        else
        {
            Console.WriteLine("PIN es impar");
        }

        if (PIN % 5 == 0)
        {
            Console.WriteLine("PIN es multiplo de 5");
           
        }
        else
        {
            Console.WriteLine("PIN no es multiplo de 5");
        }

        if ((PIN >= 1000 && PIN <= 9999) && (PIN % 2 == 0) && (PIN % 5 == 0))
        {
            Console.WriteLine("PIN aceptado por politica");
        }
        else
        {
            Console.WriteLine("PIN rechazado por politica");
        }
        Console.ReadKey();




    }
}

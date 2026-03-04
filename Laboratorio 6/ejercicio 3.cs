using System;
using System.ComponentModel.Design;
class Program
{
    static void Main()
    {

        Console.WriteLine("Escriba la puntuación que obtuvo en la evaluación (0.0, 0.4, 0.6 o más");
        double puntuacion = double.Parse(Console.ReadLine());

        switch (puntuacion)
        {
            case 0.0:
                {
                    double dinero = 2400 * puntuacion;
                    double paga = 2400 + dinero;
                    Console.WriteLine("Su puntuación fue INACEPTABLE, por lo tanto se le pagará " + paga); break;
                 
                }
            case 0.4:
                {
                    double dinero = 2400 * puntuacion;
                    double paga = 2400 + dinero;
                    Console.WriteLine("Su puntuación fue ACEPTABLE, por lo tanto se le pagará " + paga); break;
                }
            case 0.6:
                {
                    double dinero = 2400 * puntuacion;
                    double paga = 2400 + dinero;
                    Console.WriteLine("Su puntuació fue MERITORIO, por lo tanto se le pagará " + paga); break;
                }
            default:
                {
                    if (puntuacion > 0.6) ;
                    {
                        double dinero = 2400 * puntuacion;
                        double paga = 2400 + dinero;
                        Console.WriteLine("Su puntuación fue MERITORIO, por lo tanto se le pagará " + paga); 
                       
                    }
                  
                    break;
                }
                

        }


    }
}

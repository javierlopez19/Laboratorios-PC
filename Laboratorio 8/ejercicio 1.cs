using System;

class Program
{
    static void Main()
    {
        int contador = 1;
        int aprobados = 0;
        int reprobados = 0;
        double nota;
        double suma = 0;
        double promedio;

        do
        {
            Console.WriteLine("Ingrese su nota (1-100): ");
            nota = Convert.ToDouble((Console.ReadLine()));

            suma += nota;
            if (nota >= 61)
            {
                Console.WriteLine("Aprobado");
                aprobados++;
            }
            else
            {
                Console.WriteLine("Reprueba");
                reprobados++;

            }
            contador++;
        }
        while
        
        (contador <= 10);
        promedio = suma / 10;

        Console.WriteLine("Promedio de la clase: " + promedio);
        Console.WriteLine("Cantidad de aprobados: " + aprobados);
        Console.WriteLine("Cantidad de reprobados: " + reprobados);
    
    








        }
}
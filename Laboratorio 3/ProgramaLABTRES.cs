using System;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            string curso;

            Console.Write("Ingrese el nombre del curso: ");
            curso = Console.ReadLine();

            Console.WriteLine("Lab de Pensamiento Computacional");
            Console.WriteLine(nombre + ", vas muy bien en el curso " + curso);
            Console.WriteLine("Nunca dejes de practicar");

            Console.WriteLine("Hoy es un buen día para no ser adminsitrador de empresas");

            Console.WriteLine("Presione cualquier tecla para continuar...");

            Console.ReadKey();
        }
    }
}

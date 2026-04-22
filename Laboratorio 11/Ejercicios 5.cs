using System;

class Program
{
    static void Main()
    {
        string[] nombres = new string[5];

        
        Console.WriteLine("Ingrese 5 nombres:");
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.Write("Nombre " + (i + 1) + ": ");
            nombres[i] = Console.ReadLine();
        }

        
        Console.WriteLine("\nNombres ingresados:");
        foreach (string nombre in nombres)
        {
            Console.WriteLine(nombre);
        }

        
        int contador = 0;
        foreach (string nombre in nombres)
        {
            if (nombre.Length > 5)
                contador++;
        }

        
        string masLargo = nombres[0];
        foreach (string nombre in nombres)
        {
            if (nombre.Length > masLargo.Length)
                masLargo = nombre;
        }

       
        Console.WriteLine("\nMás de 5 letras: " + contador);
        Console.WriteLine("Nombre más largo: " + masLargo);
    }
}

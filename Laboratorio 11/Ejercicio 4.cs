using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[8];

        
        Console.WriteLine("Ingrese 8 números enteros:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        
        Console.Write("Ingrese el número a buscar: ");
        int buscado = int.Parse(Console.ReadLine());

        
        int posicion = -1;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscado)
            {
                posicion = i; 
                break;
            }
        }

        
        if (posicion != -1)
        {
            Console.WriteLine("El número sí existe en la posición " + posicion);
        }
        else
        {
            Console.WriteLine("El número no existe en el arreglo");
        }
    }
}

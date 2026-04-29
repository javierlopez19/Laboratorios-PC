using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[5, 5];

       
        Llenar(matriz);

        
        int sumaPrincipal = SumaDiagonalPrincipal(matriz);
        int sumaSecundaria = SumaDiagonalSecundaria(matriz);

        
        Console.WriteLine("\nSuma de la diagonal principal: " + sumaPrincipal);
        Console.WriteLine("Suma de la diagonal secundaria: " + sumaSecundaria);
    }

   
    static void Llenar(int[,] m)
    {
        Console.WriteLine("Ingrese los valores de la matriz 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("Elemento [" + i + "][" + j + "]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    
    static int SumaDiagonalPrincipal(int[,] m)
    {
        int suma = 0;
        for (int i = 0; i < 5; i++)
        {
            suma += m[i, i]; 
        }
        return suma;
    }

    
    static int SumaDiagonalSecundaria(int[,] m)
    {
        int suma = 0;
        for (int i = 0; i < 5; i++)
        {
            suma += m[i, 4 - i]; 
        }
        return suma;
    }
}

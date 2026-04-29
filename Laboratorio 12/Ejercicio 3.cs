using System;

class Program
{
    static void Main()
    {
        int[,] A = new int[3, 2];
        int[,] B = new int[3, 2];
        int[,] R = new int[3, 2];

        Console.WriteLine("Llenar matriz A:");
        LlenarMatriz(A, 3, 2);

        Console.WriteLine("\nLlenar matriz B:");
        LlenarMatriz(B, 3, 2);

        
        Multiplicar(A, B, R);

        Console.WriteLine("\nMatrices Multiplicadas :");
        MostrarMatriz(R, 3, 2);
    }

    
    static void LlenarMatriz(int[,] m, int filas, int cols)
    {
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Elemento [" + i + "][" + j + "]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

   
    static void Multiplicar(int[,] A, int[,] B, int[,] R)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                R[i, j] = A[i, j] * B[i, j];
            }
        }
    }

    
    static void MostrarMatriz(int[,] m, int filas, int cols)
    {
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(m[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

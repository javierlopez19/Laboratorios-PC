using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[4, 4];

        
        LlenarMatriz(matriz);

     
        Console.Write("\nIngrese la fila a sumar (0-3): ");
        int fila = int.Parse(Console.ReadLine());
        Console.WriteLine("Suma de la fila " + fila + ": " + SumaFila(matriz, fila));

        
        Console.Write("\nIngrese la columna a sumar (0-3): ");
        int col = int.Parse(Console.ReadLine());
        Console.WriteLine("Suma de la columna " + col + ": " + SumaColumna(matriz, col));
    }

    
    static void LlenarMatriz(int[,] m)
    {
        Console.WriteLine("Ingrese los valores de la matriz 4x4:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("Elemento [" + i + "][" + j + "]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }


    static int SumaFila(int[,] m, int fila)
    {
        int suma = 0;
        for (int j = 0; j < 4; j++)
        {
            suma += m[fila, j];
        }
        return suma;
    }

    
    static int SumaColumna(int[,] m, int col)
    {
        int suma = 0;
        for (int i = 0; i < 4; i++)
        {
            suma += m[i, col];
        }
        return suma;
    }
}


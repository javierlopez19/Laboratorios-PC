using System;

class Program
{
    static void Main()
    {
        float[,] matriz = new float[3, 5];

       
        CargarMatriz(matriz);

        
        float mayor = MayorMatriz(matriz);
        Console.WriteLine("\nEl número mayor en la matriz es: " + mayor);
    }

    
    static void CargarMatriz(float[,] m)
    {
        Console.WriteLine("Ingrese los valores de la matriz 3x5:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("Elemento [" + i + "][" + j + "]: ");
                m[i, j] = float.Parse(Console.ReadLine());
            }
        }
    }

    
    static float MayorMatriz(float[,] m)
    {
        float mayor = m[0, 0]; 
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (m[i, j] > mayor)
                {
                    mayor = m[i, j];
                }
            }
        }
        return mayor;
    }
}

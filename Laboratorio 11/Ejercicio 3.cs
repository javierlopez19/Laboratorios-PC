using System;

class Program
{
    static void Main()
    {
        Console.Write("¿Cuántos números desea ingresar? ");
        int cantidad = int.Parse(Console.ReadLine());

        int[] numeros = new int[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        
        int suma = 0;
        int mayor = numeros[0];
        int menor = numeros[0];

        for (int i = 0; i < cantidad; i++)
        {
            suma += numeros[i];

            if (numeros[i] > mayor)
                mayor = numeros[i];

            if (numeros[i] < menor)
                menor = numeros[i];
        }

        double promedio = (double)suma / cantidad;

        
        Console.WriteLine("Suma = " + suma);
        Console.WriteLine("Promedio = " + promedio);
        Console.WriteLine("Mayor = " + mayor);
        Console.WriteLine("Menor = " + menor);
    }
}

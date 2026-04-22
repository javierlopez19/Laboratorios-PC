using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un texto: ");
        string texto = Console.ReadLine();

        string invertido = InvertirTexto(texto);

        Console.WriteLine("Texto invertido: " + invertido);
    }

    static string InvertirTexto(string original)
    {
        string resultado = "";

       
        for (int i = original.Length - 1; i >= 0; i--)
        {
            resultado += original[i];
        }

        return resultado;
    }
}

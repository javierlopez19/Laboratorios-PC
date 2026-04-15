using System;

class Program
{
    
    static decimal AplicarDescuento(decimal porcentaje, ref decimal precio)
    {

        decimal montoDescontado = precio * porcentaje;

        
        precio = precio - montoDescontado;

        
        return montoDescontado;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese el precio del producto: ");
        decimal precio = decimal.Parse(Console.ReadLine());

        Console.Write("Ingrese el porcentaje de descuento (ej. 0.20 para 20%): ");
        decimal porcentaje = decimal.Parse(Console.ReadLine());

      
        decimal descuento = AplicarDescuento(porcentaje, ref precio);

        Console.WriteLine("Monto descontado: " + descuento);
        Console.WriteLine("Precio final con descuento: " + precio);
    }
}
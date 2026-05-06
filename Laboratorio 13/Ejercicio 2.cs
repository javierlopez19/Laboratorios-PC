using System;
using System.Runtime.InteropServices.Java;
class Vehiculo
{
    public string marca;
    public string modelo;
    public int anio;
    public string color;
    public string placa;
}

class Program
{
    static void Main(string[] args)
    {
        Vehiculo carro = new Vehiculo();

        carro.marca = "Hyundai";
        carro.modelo = "Accent";
        carro.anio = 2001;
        carro.color = "Corinto";
        carro.placa = "P457JHL";

        Console.WriteLine("Marca:" + carro.marca);
        Console.WriteLine("Modelo:" + carro.modelo);
        Console.WriteLine("Año:" + carro.anio);
        Console.WriteLine("color:" + carro.color);
        Console.WriteLine("Placa:" + carro.placa);

    }


}
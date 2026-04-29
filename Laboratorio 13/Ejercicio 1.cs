using System;

class Calculadora
{
    public double numero1;
    public double numero2;

    public double Sumar()
    {
        return numero1 + numero2;
    }

    public double Restar()
    {
        return numero1 - numero2;
    }

    public double Multiplicar()
    {
        return numero1 * numero2;
    }

    public double Dividir()
    {
        return numero1 / numero2;
    }
}

class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora();
        calc.numero1 = 10;
        calc.numero2 = 5;

        Console.WriteLine("Suma: " + calc.Sumar());

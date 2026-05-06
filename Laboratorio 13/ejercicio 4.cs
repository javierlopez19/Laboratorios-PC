using System;

class Mascota
{
    public string nombre;
    public string especie;
    public int edad;
    public double peso;
    public bool vacunado;

}
class Program
{
    static void Main(string[] args)
    {
        Mascota chucho = new Mascota();
        chucho.nombre = "Coco";
        chucho.especie = "Perro mestizo";
        chucho.edad = 07;
        chucho.peso = 39.6;
        chucho.vacunado = true;
        Console.WriteLine("Nombre: " + chucho.nombre);
        Console.WriteLine("Especie: " + chucho.especie);
        Console.WriteLine("Edad: " + chucho.edad + " años");
        Console.WriteLine("Peso: " + chucho.peso + " kg");
        Console.WriteLine("Vacunado: " + chucho.vacunado);
    }

}
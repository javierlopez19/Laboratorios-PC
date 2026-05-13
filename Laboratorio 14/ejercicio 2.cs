using System;
public class Mascota
{
    private string nombre;
    private string especie;
    private int edad;
    private bool vacunado;

    public Mascota(string nombre, string especie, int edad, bool vacunado)
    {
        this.nombre = nombre;
        this.especie = especie;
        this.edad = edad;
        this.vacunado = vacunado;
    }
    public void MostrarInfo()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Especie: " + especie);
        Console.WriteLine("Edad: " + edad + "años");
        Console.WriteLine("Vacunado: " + (vacunado ? "Sí" : "No"));
        Console.WriteLine("");

    }
    public void Vacunar()
    {
        if (!vacunado)
        {
            vacunado = true;
            Console.WriteLine(nombre + " ha sido vacunado.");
        }
        else
        {
            Console.WriteLine(nombre + " ya está vacunado.");
        }
    }
    public void CumplirAnios()
    {

        edad++;
        Console.WriteLine("La mascota " + nombre + " ahora tiene " + edad + " años.");

    }




}

class Program
{
    static void Main(string[] args)
    {

        Mascota mascota1 = new Mascota("Coco", "Perro", 7, true);
        Mascota mascota2 = new Mascota("Perla", "Gato", 6, false);

        Console.WriteLine("Información Inicial de las Mascotas: ");
        mascota1.MostrarInfo();
        mascota2.MostrarInfo();
        Console.WriteLine("");

        Console.WriteLine("Vamos a vacunar a Perla...");
        mascota2.Vacunar();
        mascota2.MostrarInfo();
        Console.WriteLine("");

        Console.WriteLine("Coco cumplió años...");
        mascota1.CumplirAnios();
        mascota1.MostrarInfo();
        Console.WriteLine("");
    }

}

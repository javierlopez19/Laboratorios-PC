using System;

public class Libro
{
    
    private string titulo;
    private string autor;
    private int anioPublicacion;
    private bool disponible;

    
    public Libro(string titulo, string autor, int anioPublicacion, bool disponible)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.anioPublicacion = anioPublicacion;
        this.disponible = disponible;
    }

    
    public void MostrarInformacion()
    {
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Año de publicación: " + anioPublicacion);
        Console.WriteLine("Disponible: " + (disponible ? "Sí" : "No"));
        Console.WriteLine("");


    }

    
    public void PrestarLibro()
    {
        if (disponible)
        {
            disponible = false;
            Console.WriteLine("El libro '" + titulo + "' ha sido prestado.");
        }
        else
        {
            Console.WriteLine("El libro '" + titulo + "' no está disponible.");
        }
    }

    
    public void DevolverLibro()
    {
        if (!disponible)
        {
            disponible = true;
            Console.WriteLine("El libro '" + titulo + "' ha sido devuelto.");
        }
        else
        {
            Console.WriteLine("El libro '" + titulo + "' ya estaba disponible.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Libro libro1 = new Libro("Compedio de Criminalistica", "José Eduardo Martí Guilló", 2019, true);
        Libro libro2 = new Libro("Criminología", "Luis Rodriguez Manzanera", 1979, true);
        Console.WriteLine("");


        Console.WriteLine("Información Inicial de los Libros:");
        Console.WriteLine("");
        libro1.MostrarInformacion();
        libro2.MostrarInformacion();
        Console.WriteLine("");


        Console.WriteLine("Prueba de prestar y devolver libros:");
        Console.WriteLine("");
        libro1.PrestarLibro();
        libro1.MostrarInformacion();
        Console.WriteLine("");

        libro1.DevolverLibro();
        libro1.MostrarInformacion();
        Console.WriteLine("");

        libro2.PrestarLibro();
        libro2.MostrarInformacion();
        Console.WriteLine("");

        libro2.DevolverLibro();
        libro2.MostrarInformacion();
        Console.WriteLine("");



    }
}

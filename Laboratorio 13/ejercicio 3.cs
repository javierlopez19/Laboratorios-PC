using System;

class Producto
{
    public string codigo;
    public string nombre;
    public int precio;
    public int stock;
    public bool disponible;

}

class Program
{
    static void Main(string[] args)
    {
        Producto producto1 = new Producto();
        producto1.codigo = "ABC01";
        producto1.nombre = "Power Bank";
        producto1.precio = 275;
        producto1.stock = 10;
        producto1.disponible = true;

        Producto producto2 = new Producto();
        producto2.codigo = "ABC02";
        producto2.nombre = "Smart TV";
        producto2.precio = 12000;
        producto2.stock = 7;
        producto2.disponible = true;

        Console.WriteLine("Producto Número 1");
        Console.WriteLine("Código:" + producto1.codigo);
        Console.WriteLine("Nombre del producto:" + producto1.nombre);
        Console.WriteLine("Precio:" + producto1.precio);
        Console.WriteLine("Stock:" + producto1.stock);
        Console.WriteLine("Disponible:" + producto1.disponible);

        Console.WriteLine("\nProducto Número 2");
        Console.WriteLine("Código:" + producto2.codigo);
        Console.WriteLine("Nombre del producto:" + producto2.nombre);
        Console.WriteLine("Precio:" + producto2.precio);
        Console.WriteLine("Stock:" + producto2.stock);
        Console.WriteLine("Disponible:" + producto2.disponible);
    }
}



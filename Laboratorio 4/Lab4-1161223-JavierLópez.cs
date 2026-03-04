using System;
class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Seleccione el ejercicio (1-8): ");
        int opcion = int.Parse(Console.ReadLine());
        switch (opcion) 
        { 
            case 1: Ejercicio1(); break;
            case 2: Ejercicio2(); break; 
            case 3: Ejercicio3(); break;
            case 4: Ejercicio4(); break;
            case 5: Ejercicio5(); break;
            case 6: Ejercicio6(); break;
            case 7: Ejercicio7(); break;
            case 8: Ejercicio8(); break;
            default: Console.WriteLine("Opción invalida"); break;
        } 
    } 
    static void Ejercicio1() 
    { 
        Console.WriteLine("Este es el ejercicio 1");

        Console.Write("Ingrese el modelo de su nave:");
string modelo = Console.ReadLine();

Console.WriteLine("Ingrese la capacidad de carga de la nave:");
int capacidad = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el nivel de combustible de la nave:");
Decimal combustible = Convert.ToDecimal(Console.ReadLine());

Console.Write("El motor esta activo?");
bool motor = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("El modelo de su nave es: " + modelo + "  " + "tiene una capacidad de carga de " + capacidad + "  " + "Su nivel de combustible es: " + combustible + "  " + "¿El motor está activo?" + motor);
    }

    static void Ejercicio2()
    {
        Console.WriteLine("Este es el ejercicio 2");
       short SensoresActivos = 128;
       short RegistroProcesador;
        RegistroProcesador = SensoresActivos;
       short presicionTotal = RegistroProcesador;
        Console.WriteLine("La precisión total es: " + presicionTotal);

}
    static void Ejercicio3()
    {
        Console.WriteLine("Este es el ejercicio 3");
        double energiaGenerada = 987.65;
        int energiaLimitada;
            energiaLimitada = (int)energiaGenerada;
        Console.WriteLine ("La energía limitada es: " + energiaLimitada);
        Console.WriteLine ("La energía generada es: " + energiaGenerada);

        
    }
    static void Ejercicio4()
    {
        Console.WriteLine("Este es el ejercicio 4");
        Console.WriteLine("Ingresa la distancia del planeta mas cercano:");
        string entradaRadar = Console.ReadLine();
        int distancia = int.Parse(entradaRadar);
        int distanciaF = distancia + 100;
        Console.WriteLine("La distancia del planeta mas cercano es: ", distancia);

    }
    static void Ejercicio5()
    {
        Console.WriteLine("Este es el ejercicio 5");
        string señalOxigeno = "true";
        bool señal = Convert.ToBoolean(señalOxigeno);
        string temperaturaCabina = "22.8";
            double temperatura = Convert.ToDouble(temperaturaCabina);
        Console.WriteLine("Oxigeno Activo: " + señal);
        Console.WriteLine("La temperatura de la cabina es: " + temperatura);

    }
    static void Ejercicio6()
    {
        Console.WriteLine("Este es el ejercicio 6");
        double velocidadLuz = 299792.458;
        string velocidad = velocidadLuz.ToString("N3");
        Console.WriteLine("La velocidad de la luz es: " + velocidad);
    }
    static void Ejercicio7()
    {
        Console.WriteLine("Este es el ejercicio 7");
        Console.WriteLine("Ingrese el precio por galon de Litio: ");
        string precioEntrada = Console.ReadLine();
        double precio = Convert.ToDouble(precioEntrada);
        double impuesto = precio * 0.12;
        double precioTot = precio + impuesto;
        int final = (int)precioTot;
        Console.WriteLine("El precio final del galon de Litio con impuestos es: " + final);


    }
    static void Ejercicio8()
    {
        Console.WriteLine("Este es el ejercicio 8");
        Console.WriteLine("░▐█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█▄☆");
        Console.WriteLine("░███████████████████████");
        Console.WriteLine("░▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓◤");
        Console.WriteLine("╬▀░▐▓▓▓▓▓▓▌▀█░░░█▀░");
        Console.WriteLine("▒░░▓▓▓▓▓▓█▄▄▄▄▄█▀╬░");
        Console.WriteLine("░░█▓▓▓▓▓▌░▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("░▐█▓▓▓▓▓░░▒▒▒▒▒▒▒▒▒");
        Console.WriteLine("░▐██████▌╬░▒▒▒▒▒▒▒▒");

        Console.WriteLine("Qué te gustaría o que harás el 14 de febrero?");
        string febrero = Console.ReadLine();


        Console.WriteLine("\n Estába curioso este ASCII, y lo que harás el 14 será: " + febrero);

    }
}

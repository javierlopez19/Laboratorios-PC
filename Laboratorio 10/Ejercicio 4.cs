using System;

class Program
{
    
    static int ConsumirEnergia(ref int energiaJugador)
    {
        energiaJugador -= 4;
        if (energiaJugador < 0)
            energiaJugador = 0;
        return energiaJugador;
    }

   
    static int RecargarEnergia(ref int energiaJugador)
    {
        energiaJugador += 6;
        if (energiaJugador > 20)
            energiaJugador = 20;
        return energiaJugador; 
    }

   
    static string ObtenerEstado(int energiaJugador)
    {
        if (energiaJugador >= 15 && energiaJugador <= 20)
            return "Alta";
        else if (energiaJugador >= 8 && energiaJugador <= 14)
            return "Media";
        else // 0 - 7
            return "Baja";
    }

    
    static string CalcularRendimiento(int energiaJugador)
    {
        if (energiaJugador == 20)
            return "S";
        else if (energiaJugador >= 15 && energiaJugador <= 19)
            return "A";
        else if (energiaJugador >= 8 && energiaJugador <= 14)
            return "B";
        else if (energiaJugador >= 1 && energiaJugador <= 7)
            return "C";
        else
            return "Sin energía";
    }

    static void Main(string[] args)
    {
        int energiaJugador = 10; 

        Console.WriteLine("Energía inicial: " + energiaJugador);

        
        int restante = ConsumirEnergia(ref energiaJugador);
        Console.WriteLine("Después de consumir: " + restante);

        int actual = RecargarEnergia(ref energiaJugador);
        Console.WriteLine("Después de recargar: " + actual);

        string estado = ObtenerEstado(energiaJugador);
        Console.WriteLine("Estado: " + estado);

        string rendimiento = CalcularRendimiento(energiaJugador);
        Console.WriteLine("Rendimiento: " + rendimiento);
    }
}

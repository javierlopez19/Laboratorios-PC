class Class
{
    static void Main()
    {
        Console.WriteLine("Escriba su nota previa al examen (0-100): ");
        int nota = int.Parse(Console.ReadLine());
        Console.WriteLine("Escriba los minutos de su llegada tarde, (Puede ser 0)");
        int minutos = int.Parse(Console.ReadLine());
        Console.WriteLine("¿Tiene solvencias de pago? 1 = si , 0 = no");
        int pagos = int.Parse(Console.ReadLine());
        Console.WriteLine("¿Trae identificación física? 1 = si , 0 = no");
        int identificacion = int.Parse(Console.ReadLine());
        Console.WriteLine("¿Trae calculadora permitida? 1 = si , 0 = no");
        int calcu = int.Parse(Console.ReadLine());

        if (nota >= 61)
        {
            Console.WriteLine("Requisito academico aprobado");
        }
        else
        {
            Console.WriteLine("Requisito academico no aprobado");
        }
        if (minutos <= 10)
        {
            Console.WriteLine("Hora válida");
        }
        else
        {
            Console.WriteLine("Llegada tarde: fuera de tiempo");
        }
        if (pagos == 1)
        {
            Console.WriteLine("Solvencia Validada");
        }
        else
        {
            Console.WriteLine("Sin Solvencia")
        }
        if (identificacion == 1)
        {
            Console.WriteLine("Identificacion validada");
        }
        else
        {
            Console.WriteLine("Sin identificacion");
        }
        if (calcu == 1)
        {
            Console.WriteLine("Calculadora permitida: OK");
        }
        else
        {
            Console.WriteLine("Sin calculadora permitida");
        }
        if ((nota >= 61) && (minutos <= 10) && (pagos == 1) && (identificacion == 1) && (calcu == 1))
        {
            Console.WriteLine("Acceso a la sala de examen concedido");
        }
        else
        {
            Console.WriteLine("Acceso denegado");
        }
        if ( minutos > 0 )

            {
            Console.WriteLine("Advertencia: LLEGÓ TARDE, pero aún puede ingresar");
        }






    }
}


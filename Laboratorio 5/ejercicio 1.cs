class Class
{
    static void Main()
    {
        Console.WriteLine("Ingrese el ID de usuario:");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el PIN: ");
        int pin = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el Token: ");
        int token = int.Parse(Console.ReadLine());
        Console.WriteLine("¿Modo seguro activado? 1 = Si, 0 = No");
        int modoSeguro = int.Parse(Console.ReadLine());

        bool idCorrecto = false;
        bool pinCorrecto = false;
        bool tokenCorrecto = false;


        if ( id == 2026)
        { Console.WriteLine("Usuario reconocido");
            idCorrecto = true;
        }
        else { Console.WriteLine("usuario no reconocido"); 
        }
        if ( pin == 1234)
        { Console.WriteLine("PIN correcto");
            pinCorrecto = true;
        }
        else { Console.WriteLine("PIN incorrecto"); 
        }
        if (token == 777)
        { Console.WriteLine("Token válido");
            tokenCorrecto = true;
        }
        else { Console.WriteLine("Token inválido"); 
        }


        if (modoSeguro == 1)
        {
            Console.WriteLine("Modo seguro activado");
        }
        else
        {
            Console.WriteLine("Modo seguro desactivado");
        }

        if (idCorrecto && pinCorrecto && tokenCorrecto)
        {
            Console.WriteLine("Acceso Total concedido");
        }
        else
        {
            Console.WriteLine("Acceso total denegado");
        }

        if (modoSeguro == 1)
        {
            if (token >= 700)
            {
                Console.WriteLine("Regla extra aprobada");
            }
            else
            {
                Console.WriteLine("Regla extra denegada");
            }
        }


    }
}




class Class
{
    static void Main()
    {
        Console.WriteLine("Escriba el código de activación");
        int codigo = int.Parse(Console.ReadLine());
        Console.WriteLine("Escriba su edad");
        int edad = int.Parse(Console.ReadLine());
        Console.WriteLine("¿Acepto terminos y condiciones? 1 = si , 0 = no");
        int terminos = int.Parse(Console.ReadLine());
        Console.WriteLine("¿Activó verificación de dos pasos (2FA)? 1 = si , 0 = no");
        int verificacion = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su puntaje de verificación (0 al 100");
        int puntaje = int.Parse(Console.ReadLine());

        bool codigoCorrecto = false;
        bool edadCorrecto = false;
        bool terminosCorrecto = false;
        bool verificacionCorrecto = false;


        if (codigo == 2026)
        {
            Console.WriteLine("Código Correcto");
            codigoCorrecto = true;
        }
        else
        {
            Console.WriteLine("Código Incorrecto");
        }
        if (edad >= 18)
        {
            Console.WriteLine("Edad válida");
            edadCorrecto = true;
        }
        else
        {
            Console.WriteLine("Edad inválida");
        }
        if (terminos == 1)
        {
            Console.WriteLine("Términos aceptados");
            terminosCorrecto = true;
        }
        else
        {
            Console.WriteLine("Debe aceptar los términos y condiciones");
        }
        if (verificacion == 1)
        {
            Console.WriteLine("2FA activado");
            verificacionCorrecto = true;
        }
        else
        {
            Console.WriteLine("2FA no activado");
        }
        if (puntaje >= 70)
        {
            Console.WriteLine("Puntaje suficiente");
        }
        else
        {

            Console.WriteLine("Puntaje insuficiente");
        }
        if (codigoCorrecto && edadCorrecto && terminosCorrecto && verificacionCorrecto && puntaje >= 70)
        {
            Console.WriteLine("Cuenta activada exitosamente");
        }
        else
        {
            Console.WriteLine("Cuenta NO activada");
        }

    





  


    }
}

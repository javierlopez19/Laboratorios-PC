using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una contraseña: ");
        string contra = Console.ReadLine();

        string errores = ValidarContraseña(contra);

        if (string.IsNullOrEmpty(errores))
        {
            Console.WriteLine("Contraseña válida");
        }
        else
        {
            Console.WriteLine("Inválida: " + errores);
        }
    }

    static string ValidarContraseña(string pwd)
    {
        string errores = "";

        
        if (pwd.Length < 8)
            errores += "falta longitud mínima; ";

        
        bool tieneMayuscula = false;
        foreach (char c in pwd)
        {
            if (char.IsUpper(c))
            {
                tieneMayuscula = true;
                break;
            }
        }
        if (!tieneMayuscula)
            errores += "falta mayúscula; ";

        
        bool tieneNumero = false;
        foreach (char c in pwd)
        {
            if (char.IsDigit(c))
            {
                tieneNumero = true;
                break;
            }
        }
        if (!tieneNumero)
            errores += "falta número; ";

        
        string especiales = "@#$%!¡?¿";
        bool tieneEspecial = false;
        foreach (char c in pwd)
        {
            if (especiales.Contains(c))
            {
                tieneEspecial = true;
                break;
            }
        }
        if (!tieneEspecial)
            errores += "falta carácter especial; ";

        return errores.Trim();
    }
}

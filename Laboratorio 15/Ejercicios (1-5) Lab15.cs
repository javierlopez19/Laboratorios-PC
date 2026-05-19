using System; //punto y coma (ejercicio 1)

class Program
{
    static void Main()
    {
        int opcion = 0;
        bool valido = false;

        // Menú interactivo
        while (!valido)
        {
            Console.WriteLine("----- MENÚ DE EJERCICIOS -----");
            Console.WriteLine("1. Ejercicio 1 (Edad)");
            Console.WriteLine("2. Ejercicio 2 (Promedio notas)");
            Console.WriteLine("3. Ejercicio 3 (Arreglo y suma)");
            Console.WriteLine("4. Ejercicio 4 (Área rectángulo)");
            Console.WriteLine("5. Ejercicio 5 (Promedio edades)");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1: Ejercicio1(); break;
                    case 2: Ejercicio2(); break;
                    case 3: Ejercicio3(); break;
                    case 4: Ejercicio4(); break;
                    case 5: Ejercicio5(); break;
                    case 6:
                        valido = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Debe ingresar un número.");
            }

            Console.WriteLine();
        }
    }

    // Ejercicio 1
    static void Ejercicio1()
    {
        string nombre; // punto y coma (ejercicio 1)
        int edad;
        Console.WriteLine("-----Ejercicio 1-----");

        Console.WriteLine("Ingrese su nombre:");
        nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su edad:");
        edad = int.Parse(Console.ReadLine());  //punto y coma (ejercicio 1)

        Console.WriteLine("Hola " + nombre);
        Console.WriteLine("Tienes " + edad + " años");

        if (edad >= 18)
            Console.WriteLine("Eres mayor de edad");
        else
            Console.WriteLine("Eres menor de edad");
    } // llave final (ejercicio 1)

    // Ejercicio 2
    static void Ejercicio2()
    {
        double nota1, nota2, nota3, promedio;
        Console.WriteLine("-----Ejercicio 2-----");

        Console.WriteLine("Ingrese la primera nota:");
        nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota:");
        nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota:");
        nota3 = double.Parse(Console.ReadLine());

        promedio = (nota1 + nota2 + nota3) / 3;  // se coloca () para que se haga bien la operación

        Console.WriteLine("El promedio es: " + promedio);

        if (promedio >= 61) // se coloca "=" para incluir el caso exacto de 61
            Console.WriteLine("El estudiante aprobó");
        else
            Console.WriteLine("El estudiante reprobó");
    }

    // Ejercicio 3
    static void Ejercicio3()
    {
        Console.WriteLine("-----Ejercicio 3-----");
        int[] numeros = new int[5]; // arreglo de tamaño 5 porque son las posiciones de 0 a 4
        int suma = 0;

        for (int i = 0; i < 5; i++) // se usa < 5 para no salir del rango
        {
            bool valido = false;
            int numero;

            while (!valido)
            {
                Console.WriteLine("Ingrese un número:");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    numeros[i] = numero;
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Intente de nuevo.");
                }
            }
        }

        for (int i = 0; i < 5; i++)
        {
            suma += numeros[i];
        }

        Console.WriteLine("La suma total es: " + suma);
    }

    // Ejercicio 4
    static void Ejercicio4()
    {
        Console.WriteLine("-----Ejercicio 4-----");
        double baseRectangulo = PedirValorPositivo("Ingrese la base del rectángulo:");
        double alturaRectangulo = PedirValorPositivo("Ingrese la altura del rectángulo:");

        double area = CalcularArea(baseRectangulo, alturaRectangulo);

        Console.WriteLine("El área es: " + area);

        if (area >= 100) // condición corregida para incluir el caso exacto de 100
            Console.WriteLine("El área es grande");
        else
            Console.WriteLine("El área es pequeña");
    }

    static double CalcularArea(double baseRectangulo, double alturaRectangulo)
    {
        return baseRectangulo * alturaRectangulo; // corrección: multiplicar en lugar de sumar
    }

    static double PedirValorPositivo(string mensaje)
    {
        double valor = 0; 
        bool valido = false;

        while (!valido)
        {
            Console.WriteLine(mensaje);
            if (double.TryParse(Console.ReadLine(), out valor) && valor > 0)
            {
                valido = true;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Debe ser un número mayor que cero.");
            }
        }

        return valor;
    }

    // Ejercicio 5
    static void Ejercicio5()
    {
        Console.WriteLine("-----Ejercicio 5-----");
        int[] edades = new int[5];
        int suma = 0;
        int mayores = 0;

        for (int i = 0; i < 5; i++) // se van a usar los indices de 0 a 4
        {
            bool valido = false;
            int edad;

            while (!valido)
            {
                Console.WriteLine("Ingrese la edad de la persona " + (i + 1) + ":");
                if (int.TryParse(Console.ReadLine(), out edad) && edad >= 0)
                {
                    edades[i] = edad;
                    suma += edad;

                    if (edad >= 18) 
                        mayores++;

                    valido = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Debe ser un número entero no negativo.");
                }
            }
        }

        double promedio = (double)suma / 5; //acá se va a incluir el double para decimales

        Console.WriteLine("El promedio de edades es: " + promedio);
        Console.WriteLine("Cantidad de mayores de edad: " + mayores);

     
    }
}
//La validación humana siempre será escencial ya que el estar siempre utilizando una Inteligencia Artifical puede conllevar a patrones, errores continuos
// entonces esto provocará errores a futuro mientras que estando una persona validando, esto se podrá detectar ya que la ia no tiene "criterio"

// ¿Por qué una solución generada por Inteligencia Artificial debe ser revisada, probada y validada por una persona antes de considerarse correcta?
// Para que  se cumpla con los patrones o validaciones humanas que sean necesarias para un trabajo en especifico.

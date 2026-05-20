using System;

class Cultivo
{
    public string Nombre { get; set; }
    public int MesesCrecimiento { get; set; }
    public int Ingreso { get; set; }

    public Cultivo(string nombre, int meses, int ingreso)
    {
        Nombre = nombre;
        MesesCrecimiento = meses;
        Ingreso = ingreso;
    }
}

class Parcela
{
    public Cultivo Cultivo { get; set; }
    public int Progreso { get; set; }
    public bool Regada { get; set; }

    public Parcela()
    {
        Cultivo = null;
        Progreso = 0;
        Regada = false;
    }

    public bool EstaVacia()
    {
        return Cultivo == null;
    }
}

class Granja
{
    private int dinero;
    private int empleados;
    private int sueldo;
    private int mesesRestantes;
    private Parcela[,] parcelas;


    private int totalIngresos = 0;
    private int totalEgresos = 0;
    private int totalRiegos = 0;

    private int conteoPapa = 0;
    private int conteoTomate = 0;
    private int conteoFresa = 0;

    private int cosechasPapa = 0;
    private int cosechasTomate = 0;
    private int cosechasFresa = 0;

    public Granja(int dineroInicial, int empleados, int sueldo, int meses, int filas, int columnas)
    {
        this.dinero = dineroInicial;
        this.empleados = empleados;
        this.sueldo = sueldo;
        this.mesesRestantes = meses;
        this.parcelas = new Parcela[filas, columnas];

        for (int i = 0; i < filas; i++)
            for (int j = 0; j < columnas; j++)
                this.parcelas[i, j] = new Parcela();
    }

    public void MostrarMenu()
    {
        int opcion;
        do
        {
            Console.WriteLine("");
            Console.WriteLine(" -_-_- MENÚ DE OPCIONES -_-_- ");
            Console.WriteLine("");
            Console.WriteLine("1. Sembrar");
            Console.WriteLine("2. Regar parcela");
            Console.WriteLine("3. Consultar parcela");
            Console.WriteLine("4. Avanzar mes");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: Sembrar(); break;
                case 2: Regar(); break;
                case 3: Consultar(); break;
                case 4: AvanzarMes(); break;
            }
        } while (opcion != 5 && dinero > 0 && mesesRestantes > 0);

        ReporteFinal();
    }

    private void Sembrar()
    {
        Console.Write("Fila: "); int f = int.Parse(Console.ReadLine());
        Console.Write("Columna: "); int c = int.Parse(Console.ReadLine());

        if (!parcelas[f, c].EstaVacia())
        {
            Console.WriteLine("La parcela ya tiene cultivo.");
            return;
        }

        Console.WriteLine("Elige cultivo: 1.Papa 2.Tomate 3.Fresa");
        int tipo = int.Parse(Console.ReadLine());
        switch (tipo)
        {
            case 1: parcelas[f, c].Cultivo = new Cultivo("Papa", 2, 450); conteoPapa++; break;
            case 2: parcelas[f, c].Cultivo = new Cultivo("Tomate", 3, 650); conteoTomate++; break;
            case 3: parcelas[f, c].Cultivo = new Cultivo("Fresa", 4, 900); conteoFresa++; break;
        }
        Console.WriteLine("Sembrado correctamente.");
    }

    private void Regar()
    {
        Console.Write("Fila: "); int f = int.Parse(Console.ReadLine());
        Console.Write("Columna: "); int c = int.Parse(Console.ReadLine());

        if (parcelas[f, c].EstaVacia())
        {
            Console.WriteLine("No hay cultivo en esta parcela.");
            return;
        }
        if (parcelas[f, c].Regada)
        {
            Console.WriteLine("Ya fue regada este mes.");
            return;
        }
        if (dinero < 40)
        {
            Console.WriteLine("No tienes suficiente dinero.");
            return;
        }

        dinero -= 40;
        totalEgresos += 40;   
        totalRiegos++;        
        parcelas[f, c].Regada = true;
        Console.WriteLine("Parcela regada. Dinero restante: Q" + dinero);
    }

    private void Consultar()
    {
        Console.Write("Fila: "); int f = int.Parse(Console.ReadLine());
        Console.Write("Columna: "); int c = int.Parse(Console.ReadLine());

        if (parcelas[f, c].EstaVacia())
        {
            Console.WriteLine("Parcela vacía, disponible para siembra.");
            return;
        }

        Parcela p = this.parcelas[f, c];
        Console.WriteLine("Cultivo: " + p.Cultivo.Nombre);
        Console.WriteLine("Progreso: " + p.Progreso + "/" + p.Cultivo.MesesCrecimiento);
        Console.WriteLine("Regada este mes: " + (p.Regada ? "Sí" : "No"));
    }

    private void AvanzarMes()
    {
        mesesRestantes--;
        dinero -= empleados * sueldo;
        totalEgresos += empleados * sueldo; 
        Console.WriteLine("Pago de empleados: Q" + (empleados * sueldo) + ". Dinero restante: Q" + dinero);

        for (int i = 0; i < parcelas.GetLength(0); i++)
        {
            for (int j = 0; j < parcelas.GetLength(1); j++)
            {
                Parcela p = parcelas[i, j];
                if (!p.EstaVacia())
                {
                    p.Progreso += p.Regada ? 2 : 1;
                    p.Regada = false;

                    if (p.Progreso >= p.Cultivo.MesesCrecimiento)
                    {
                        dinero += p.Cultivo.Ingreso;
                        totalIngresos += p.Cultivo.Ingreso; 

                        if (p.Cultivo.Nombre == "Papa") cosechasPapa++;
                        else if (p.Cultivo.Nombre == "Tomate") cosechasTomate++;
                        else if (p.Cultivo.Nombre == "Fresa") cosechasFresa++;

                        Console.WriteLine("Cosecha de " + p.Cultivo.Nombre + " en (" + i + "," + j + "). Ingreso: Q" + p.Cultivo.Ingreso);
                        parcelas[i, j] = new Parcela();
                    }
                }
            }
        }
    }

    private void ReporteFinal()
    {
        Console.WriteLine("");
        Console.WriteLine("-_-_- REPORTE FINAL -_-_-");
        Console.WriteLine("");
        Console.WriteLine("Dinero final: Q" + dinero);
        Console.WriteLine("Total de ingresos: Q" + totalIngresos);
        Console.WriteLine("Total de egresos: Q" + totalEgresos);
        Console.WriteLine("Meses simulados: " + mesesRestantes);

        Console.WriteLine("Parcelas sembradas - Papa: " + conteoPapa + ", Tomate: " + conteoTomate + ", Fresa: " + conteoFresa);

        Console.WriteLine("Cosechas realizadas - Papa: " + cosechasPapa + ", Tomate: " + cosechasTomate + ", Fresa: " + cosechasFresa);

        Console.WriteLine("Total de riegos: " + totalRiegos);

        int parcelasVacias = 0;
        for (int i = 0; i < parcelas.GetLength(0); i++)
            for (int j = 0; j < parcelas.GetLength(1); j++)
                if (parcelas[i, j].EstaVacia()) parcelasVacias++;

        Console.WriteLine("Parcelas vacías al finalizar: " + parcelasVacias);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Dinero inicial: "); int dinero = int.Parse(Console.ReadLine());
        Console.Write("Número de empleados: "); int empleados = int.Parse(Console.ReadLine());
        Console.Write("Sueldo por empleado: "); int sueldo = int.Parse(Console.ReadLine());
        Console.Write("Meses a simular: "); int meses = int.Parse(Console.ReadLine());
        Console.Write("Filas: "); int filas = int.Parse(Console.ReadLine());
        Console.Write("Columnas: "); int columnas = int.Parse(Console.ReadLine());

        Granja granja = new Granja(dinero, empleados, sueldo, meses, filas, columnas);
        granja.MostrarMenu();
    }
}

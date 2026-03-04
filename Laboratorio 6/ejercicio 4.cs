using System;
using System.ComponentModel.Design;
class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la pizzería Bella Napoli, seleccione tipo de pizza va a desear:");
        Console.WriteLine("1. Vegetariana o 2. NO Vegetariana");
        int tipo = int.Parse(Console.ReadLine());
        string tipoPizza = "";
        string ingrediente = "";

        switch (tipo)
        {
            case 1:
                tipoPizza = "Vegetariana";
                Console.WriteLine("Escogiste la pizza Vegetariana y para esta tenemos estos ingredientes:");
                Console.WriteLine("1. Pimiento y 2. TOFU, escoge el que tu desees");
                int ingredienteveg = int.Parse(Console.ReadLine());
                switch (ingredienteveg)
                {
                    case 1:
                        ingrediente = "Pimiento";
                        break;
                    case 2:
                        ingrediente = "TOFU"; ;
                        break;
                    default:
                        Console.WriteLine("Ese ingrediente no está disponible para las Pizzas");
                        break;
                }
                break;



            case 2:
                tipoPizza = "NO Vegetariana";
                Console.WriteLine("Escogiste la pizza NO Vegetariana y para esta tenemos estos ingredientes: ");
                Console.WriteLine("1. Pepperoni , 2. Jamón y 3. Salmón, escoge el que tu desees");
                int ingredientenoveg = int.Parse(Console.ReadLine());

                switch (ingredientenoveg)
                {
                    case 1:
                        ingrediente = "Pepperoni";
                        break;
                    case 2:
                        ingrediente = "Jamón";
                        break;
                    case 3:
                        ingrediente = "Salmón";
                        break;
                    default:
                        Console.WriteLine("Ese ingrediente no está disponible para las Pizzas");
                        break;
                }
                break;
            default:
                Console.WriteLine("Este tipo de pizzas no está disponible");
                break;
        }
        if (tipoPizza != "" && ingrediente != "")
        {
            Console.WriteLine("Tu orden sería:");
            Console.WriteLine("Tipo de pizza: " + tipoPizza);
            Console.WriteLine("Su ingrediente es: " + ingrediente);
        }



                

        }
    }


        


    


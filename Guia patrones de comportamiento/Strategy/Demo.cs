using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_patrones_de_comportamiento.Strategy
{
    public class Demo
    {
        public static void RunMenu() 
        {
            string opcion = "";
            decimal subtotal = 75000m;
            var carrito = new Carrito(new Porcentaje());
            Console.WriteLine("Ingrese cual es el subtotal:");
            subtotal=decimal.Parse(Console.ReadLine());
            Console.Clear();

            do { 
            Console.WriteLine("------------------");
            Console.WriteLine("------MENU-----");
            Console.WriteLine("------------------");
            Console.WriteLine("1/Sin Descuento");
            Console.WriteLine("º");
            Console.WriteLine("2/Por Porcentaje");
            Console.WriteLine("º");
            Console.WriteLine("3/Tope Bancario");
            Console.WriteLine("º");
            Console.WriteLine("------------------");
           
           
            opcion=Console.ReadLine();
            switch (opcion) 
            {
                case "1":
                        Console.Clear();
                        carrito.SetDescuento(new SinDescuento());
                        Console.WriteLine($"Total con {nameof(SinDescuento)}: {carrito.Total(subtotal)}");

                        Console.WriteLine("Oprima enter para vovler al menu");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                case "2":
                        Console.Clear();
                        carrito.SetDescuento(new Porcentaje());
                        Console.WriteLine($"Total con {nameof(Porcentaje)}: {carrito.Total(subtotal)}");
                       
                    Console.WriteLine("Oprima enter para vovler al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                case "3":
                        Console.Clear();
                        carrito.SetDescuento(new TopeBanco());
                    Console.WriteLine($"Total con {nameof(TopeBanco)}: {carrito.Total(subtotal)}");
                    Console.WriteLine("Oprima enter para vovler al menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "0":
                        Console.WriteLine("SALIENDO...");
                        Console.ReadKey();
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("ERROR");
                        Console.ReadKey();
                        break;

            }
            } while (opcion != "0");






            //caso 1

            //caso 2

            //caso 3


        }
    }
}

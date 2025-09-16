using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_estructurales
{
    using Adapter;
    using Decorator;
    using Facade;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------");
            Console.WriteLine("Selecione un ejercicio");
            Console.WriteLine("---------");
            Console.WriteLine("1-Adapter");
            Console.WriteLine("2-Decorator");
            Console.WriteLine("3-");
            string option = Console.ReadLine();
            do
            {
                switch (option)
                {
                    case "1":
                        DemoImpresora.Run();
                        Console.ReadLine();
                        break;
                    case "2":
                        DemoMensaje.Run();
                        Console.ReadLine();
                        break;
                    case "3":
                        DemoFacade.Run();
                        Console.ReadLine();
                        break;
                    case "0":
                        Console.WriteLine("Oprima enter para salir");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Seleccione una opcion correcta");
                        break;

                }
            } while (option != "0");


        }
    }
}

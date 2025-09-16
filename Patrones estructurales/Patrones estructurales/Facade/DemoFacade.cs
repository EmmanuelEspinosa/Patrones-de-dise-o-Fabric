using Patrones_estructurales.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_estructurales.Facade
{
    

        public static class DemoFacade
        {
            public static void Run()
            {
              UserFacade fachada = new UserFacade();
           bool usuario = fachada.RegistrarUsuario("manu@gmail.com", "Emmanuel");
            if (usuario)
            {
                Console.WriteLine("________________");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Usuario registardo con exito");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El usuario no se pudo crear");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        }
    
    
}

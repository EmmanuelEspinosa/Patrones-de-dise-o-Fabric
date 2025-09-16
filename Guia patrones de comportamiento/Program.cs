using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_patrones_de_comportamiento
{
    using Guia_patrones_de_comportamiento.Observer;
    using Strategy;
   
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Demo.RunMenu();
            Console.ReadLine();*/
            DemoObserver.Run();
            Console.ReadLine();
            
        }
    }
}

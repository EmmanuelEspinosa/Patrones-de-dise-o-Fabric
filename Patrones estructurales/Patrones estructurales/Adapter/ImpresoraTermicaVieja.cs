using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_estructurales.Adapter
{
    public class ImpresoraTermicaVieja
    {
        public void PrintTicket(string data) 
        {
            Console.WriteLine($"Imprimiendo:{data}");
        }
    }
}

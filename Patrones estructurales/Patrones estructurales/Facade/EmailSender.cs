using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_estructurales.Facade
{
    public class EmailSender
    {
        public void EnviarBienvenida(string email) 
        {
            Console.WriteLine($"____________ \n Bienvenido al sistema \n Para:{email} \n ____________");
        }
    }
}

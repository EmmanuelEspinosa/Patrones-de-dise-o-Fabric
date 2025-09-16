using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_estructurales.Decorator
{
    public class MensajeSimple : IMensaje
    {
        public void Enviar(string mensaje) 
        {
            Console.WriteLine(mensaje);
        }

    }
}

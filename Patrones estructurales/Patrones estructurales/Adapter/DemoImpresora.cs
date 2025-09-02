using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_estructurales.Adapter
{
    public static class DemoImpresora
    {
        public static void Run() 
        {
            IImpresora impresora = new AdaptadorTermica(new ImpresoraTermicaVieja());
            impresora.Imprimir("Kako gai");
        
        }
    }
}

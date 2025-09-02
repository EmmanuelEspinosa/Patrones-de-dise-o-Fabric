using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_estructurales.Adapter
{
    public class AdaptadorTermica : IImpresora
    {
        private readonly ImpresoraTermicaVieja _vieja;

        public AdaptadorTermica(ImpresoraTermicaVieja vieja) 
        {
            _vieja = vieja;
        }
        public void Imprimir(string texto)
        {
            if (texto.Length < 100 && texto.Length > 0)
            {
                _vieja.PrintTicket(texto);
            }
            else if (texto.Length < 1) 
            {
                Console.WriteLine("Ingrese al menos 1 caracter");            
            }
            else if (texto.Length >=100)
            {
                Console.WriteLine("Ingrese menos de 100 caracter");
            }
        }
    }
}

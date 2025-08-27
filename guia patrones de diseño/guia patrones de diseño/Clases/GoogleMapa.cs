using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_patrones_de_diseño.Clases
{
    using Interface;
    public class GoogleMapa:IMapa
    {
        public void Render() => Console.WriteLine("Dibujando mapa en google maps");
    }
}

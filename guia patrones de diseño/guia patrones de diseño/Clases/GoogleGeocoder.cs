using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_patrones_de_diseño.Clases
{
    using Interface;
    public class GoogleGeocoder:IGeocoder
    {
        public void Buscar() => Console.WriteLine("Imprimiendo Cordenadas en Google Maps");
    }
}

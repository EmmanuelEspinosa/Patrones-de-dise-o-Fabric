using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_patrones_de_comportamiento.Strategy
{
    public class TopeBanco : IDescuentoStrategy
    {
        public string Nombre => "Descuento con Tope del Banco";

        public decimal Aplicar(decimal subtotal) => 5000m;
    }
}

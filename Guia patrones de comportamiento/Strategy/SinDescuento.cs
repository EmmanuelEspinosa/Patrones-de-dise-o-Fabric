using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_patrones_de_comportamiento.Strategy
{
    public class SinDescuento : IDescuentoStrategy
    {
        public string Nombre => "Sin Descuento";

        public decimal Aplicar(decimal subtotal) => 0m;
    }
}

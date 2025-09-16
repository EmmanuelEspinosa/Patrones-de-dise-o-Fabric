using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_patrones_de_comportamiento.Strategy
{
    public class Porcentaje:IDescuentoStrategy
    {
            public string Nombre => "15% de descuento";

            public decimal Aplicar(decimal subtotal) => ((subtotal*15)/100);
        
    }
}

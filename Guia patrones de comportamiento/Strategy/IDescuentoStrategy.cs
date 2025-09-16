using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_patrones_de_comportamiento.Strategy
{
    public interface IDescuentoStrategy
    {
        decimal Aplicar(decimal subtotal);
        string Nombre { get; }
    }
}

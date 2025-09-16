using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_patrones_de_comportamiento.Strategy
{
    public class Carrito
    {
        private IDescuentoStrategy _strategy;

        public Carrito(IDescuentoStrategy strategy)
            {
            _strategy = strategy;
            }
        public void SetDescuento(IDescuentoStrategy nuevoDescuento)
        {
            _strategy = nuevoDescuento;
            Console.WriteLine($"Descuento cambiado con exito!({_strategy.Nombre})");
        }
        public decimal Total(decimal subtotal) 
        {
            var descuento = _strategy.Aplicar(subtotal);
            return subtotal - descuento;
        }







    }
   





}

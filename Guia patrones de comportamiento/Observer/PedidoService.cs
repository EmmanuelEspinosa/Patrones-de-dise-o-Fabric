using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_patrones_de_comportamiento.Observer
{
  
    public class PedidoService
    {
    
        Dictionary<int,EstadoPedido> pedidos= new Dictionary<int,EstadoPedido>();

        public event EventHandler<PedidoChangedEventArgs>EstadoCambiado;

       public void CambiarEstado(int pedidoId, EstadoPedido nuevo) 
        {
            
            if(pedidos.ContainsKey(pedidoId)) 
            {
                pedidos[pedidoId] = nuevo;
            }
            Console.WriteLine("Cambiando estado de pedido!");

            EstadoCambiado?.Invoke(this, new PedidoChangedEventArgs(pedidoId, nuevo));
        }
    }
}

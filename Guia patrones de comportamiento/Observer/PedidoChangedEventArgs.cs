using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_patrones_de_comportamiento.Observer
{
    public enum EstadoPedido 
    {
    Recibido,
    Preparando,
    Enviado,
    Entregado

    }
    public class PedidoChangedEventArgs:EventArgs
    {
       

        public int PedidoId { get; }
        public EstadoPedido nuevoEstado { get; }
        public DateTime Cuando { get; }

        public PedidoChangedEventArgs(int pedidoId, EstadoPedido nuevo )
        {
            PedidoId = pedidoId;
            nuevoEstado = nuevo;
            Cuando =DateTime.Now; 
        }

       
    }
}

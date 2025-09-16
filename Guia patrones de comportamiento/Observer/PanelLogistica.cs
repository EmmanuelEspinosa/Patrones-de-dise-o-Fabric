using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_patrones_de_comportamiento.Observer
{
    public class PanelLogistica
    {
        public void Suscribir(PedidoService p) => p.EstadoCambiado += OnEstadoCambiado;
        public void Desuscribir(PedidoService p) => p.EstadoCambiado -= OnEstadoCambiado;
        private void OnEstadoCambiado(Object sender, PedidoChangedEventArgs p)
        {
            Console.WriteLine($"Pedido:{p.PedidoId}==> {p.nuevoEstado} [{p.Cuando}]");
            Console.ReadKey();

        }
    }
}

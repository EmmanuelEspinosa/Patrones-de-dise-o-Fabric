using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_patrones_de_comportamiento.Observer
{
    public class DemoObserver
    {
        public static void Run() 
        { 
        //sujeto
        var pedidos = new PedidoService();
        //observer
        var auditoria = new AuditoriaPedidos();
        var panel=new PanelLogistica();
        var cliente= new NotificadorCliente();

            auditoria.Suscribir(pedidos);
            panel.Suscribir(pedidos);
            cliente.Suscribir(pedidos);
            Console.WriteLine("Primera operacion todos suscriptos");
            pedidos.CambiarEstado(2, EstadoPedido.Recibido);
            pedidos.CambiarEstado(2,EstadoPedido.Preparando);
            pedidos.CambiarEstado(2,EstadoPedido.Enviado);
            Console.WriteLine("*************************");
            Console.WriteLine("SE DESUSCRIBIO EL PANEL");
            Console.WriteLine("*************************");
            Console.ReadKey();
            panel.Desuscribir(pedidos);
            pedidos.CambiarEstado(2,EstadoPedido.Entregado);

        }

    }
}

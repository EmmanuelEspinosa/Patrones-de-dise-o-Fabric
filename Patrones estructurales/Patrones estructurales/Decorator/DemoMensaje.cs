using Patrones_estructurales.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_estructurales.Decorator
{
   
    public static class DemoMensaje
    {
        public static void Run()
        {
            IMensaje msg = new MensajeSimple();

            msg = new MensajeEncriptado(msg);

            msg= new MensajeConEmoji(msg,":)");

            msg.Enviar("Sonria lo estamos filmando");
        }
    }
}

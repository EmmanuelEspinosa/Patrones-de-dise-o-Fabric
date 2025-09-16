using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_estructurales.Decorator
{
    public class MensajeEncriptado : MensajeDecorator
    {
        public MensajeEncriptado(IMensaje wrappe) : base(wrappe) 
        { }
        public override void Enviar(string mensaje)
        {
            var mensajeMayus=mensaje.ToUpper();
            Console.WriteLine("Encriptando...");
            base.Enviar(mensajeMayus);
        }
    }
}

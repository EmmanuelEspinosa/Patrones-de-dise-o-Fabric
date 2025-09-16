using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_estructurales.Decorator
{
    public class MensajeConEmoji: MensajeDecorator
    {
        private readonly string _emoji;
        public MensajeConEmoji(IMensaje wrappe,string emoji) : base(wrappe)
        {
            _emoji = emoji;
        }
        public override void Enviar(string mensaje)
        {
            Console.WriteLine("Agregando Emoji...");
            var mensajeConEmoji = $"{mensaje} {_emoji} ";
            base.Enviar(mensajeConEmoji);
        }
    }
}

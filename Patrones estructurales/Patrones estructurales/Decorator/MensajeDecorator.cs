using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_estructurales.Decorator
{
    public abstract class MensajeDecorator:IMensaje
    {
        protected IMensaje _wrappe;
        protected MensajeDecorator(IMensaje wrappe)
        {
         _wrappe = wrappe;
        }
        public virtual void Enviar(string mensaje)
        {
        _wrappe.Enviar(mensaje);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_estructurales.Facade
{
    public class UserFacade
    {
        private readonly DBService _dbService=new DBService();
        private readonly EmailSender _emailSender=new EmailSender();
        private readonly EmailValidator _emailValidator=new EmailValidator();

        public bool RegistrarUsuario(string email,string nombre) 
        {
            Console.WriteLine("Iniciando Registro");
           bool emailValido=_emailValidator.EsValido(email);
            if (emailValido)
            {
                _dbService.GuardarUsuario(nombre, email);
                _emailSender.EnviarBienvenida(email);
                return true;
            }
            else 
            {
                return false;
            }
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_estructurales.Facade
{
    public class EmailValidator
    {
        public bool EsValido(string email) 
        {
            if (email.Contains("@"))
            {
                if (email.Contains(".com"))
                {
                    Console.WriteLine("Email Valido");
                    return true;
                }
                else 
                {
                    Console.WriteLine("Email invalido");
                    return false;
                }
            }
            else 
            {
                Console.WriteLine("Email invalido, no tiene '@'");
                return false;
            }
        }
    }
}

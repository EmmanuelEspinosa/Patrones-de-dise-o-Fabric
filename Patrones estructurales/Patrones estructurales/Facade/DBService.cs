using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_estructurales.Facade
{
    public class DBService
    {
        public void GuardarUsuario(string nombre, string email) 
        {
            Console.WriteLine($"Usuario guardado:{nombre} || {email}");
        }
    }
}

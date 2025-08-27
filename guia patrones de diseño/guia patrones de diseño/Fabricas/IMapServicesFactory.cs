using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_patrones_de_diseño.Fabrica
{
    using Interface;
   public interface IMapServicesFactory
    {
        IMapa CreateMapa();
        IGeocoder CreateGeocoder();
    }
}

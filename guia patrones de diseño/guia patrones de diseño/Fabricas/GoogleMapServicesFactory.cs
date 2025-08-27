using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using guia_patrones_de_diseño.Clases;
using guia_patrones_de_diseño.Interface;
using guia_patrones_de_diseño.Fabrica;

namespace guia_patrones_de_diseño.Fabricas
{
    
    public class GoogleMapServicesFactory: IMapServicesFactory
    {
        public IMapa CreateMapa() => new GoogleMapa();
        public IGeocoder CreateGeocoder() => new GoogleGeocoder();
    }
}

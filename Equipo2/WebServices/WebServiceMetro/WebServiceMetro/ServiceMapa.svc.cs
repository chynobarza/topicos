using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceMetro
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceMapa" en el código, en svc y en el archivo de configuración a la vez.
    public class ServiceMapa : IServiceMapa
    {
        public void DoWork()
        {
        }

        public Ruta[] GetRutas()
        {
            Ruta[] ruta = null;

                equipo2Entities entity = new equipo2Entities();
                ruta = (from d in entity.Ruta
                        select new Ruta
                        {
                            Id = d.Id,
                            Numero = d.Numero,
                            Linea = d.Linea,
                            Nombre = d.Nombre,
                            Latitud = d.Latitud,
                            Longitud = d.Longitud
                        }).ToArray();

            return ruta;
        }
    }
}

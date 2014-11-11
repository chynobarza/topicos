using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace WebServiceMetro
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceMapa" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceMapa
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        [WebGet(
            UriTemplate = "GetRutas",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json
        )]
        Ruta[] GetRutas();

    }
}

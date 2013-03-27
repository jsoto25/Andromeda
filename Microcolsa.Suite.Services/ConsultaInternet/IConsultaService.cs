using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Microcolsa.Suite.Services.ConsultaInternet.POCO;

namespace Microcolsa.Suite.Services.ConsultaInternet
{
    [ServiceContract]
    public interface IConsultaService
    {
        [OperationContract]
        [WebGet(ResponseFormat=WebMessageFormat.Json)]
        SuiteResponse ConsultarArchivadores();

        [OperationContract]
        [WebGet(ResponseFormat=WebMessageFormat.Json)]
        SuiteResponse ConsultarArchivadorPorId(int Id);
    }
}

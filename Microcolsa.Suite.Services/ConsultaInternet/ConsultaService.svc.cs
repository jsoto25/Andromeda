using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Microcolsa.Suite.Core.ConsultaInternet;
using Microcolsa.Suite.Services.ConsultaInternet.POCO;

namespace Microcolsa.Suite.Services.ConsultaInternet
{
    public class ConsultaService : IConsultaService
    {
        SuiteResponse IConsultaService.ConsultarArchivadores()
        {
            try
            {
                List<Archivador> AllArch = Archivador.Consultar().ToList();
                List<ArchivadorPoco> AllPoco = new List<ArchivadorPoco>();
                foreach (Archivador Arch in AllArch)
                    AllPoco.Add(new ArchivadorPoco(Arch));

                SuiteResponse Result = new SuiteResponse(AllPoco);
                return Result;

            }
            catch (Exception Ex)
            {
                return new SuiteResponse("Ocurrio un error consultando los archivadores!", Ex);
            }
        }

        SuiteResponse IConsultaService.ConsultarArchivadorPorId(int Id)
        {
            try
            {
                return new SuiteResponse(new ArchivadorPoco(Archivador.Consultar(Id)));
            }
            catch (Exception Ex)
            {
                return new SuiteResponse("Ocurrio un error consultando el archivador!", Ex);
            }
        }
    }
}

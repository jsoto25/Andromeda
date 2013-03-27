using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microcolsa.Suite.Core.ConsultaInternet;

namespace Microcolsa.Suite.Services.ConsultaInternet.POCO
{
    public class ArchivadorPoco
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public int? IdTipoArchivador { get; set; }

        public ArchivadorPoco()
        { 
        }

        public ArchivadorPoco(Archivador Arch)
        {
            this.Id = Arch.Id;
            this.Nombre = Arch.Nombre;
            this.Titulo = Arch.TituloArchivador;
            this.IdTipoArchivador = Arch.IdTipoArchivador;
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microcolsa.Suite.Core.ConsultaInternet
{
    using System;
    using System.Collections.Generic;
    
    public partial class Archivador
    {
        public Archivador()
        {
            this.mci_ArchvdresGrpo = new HashSet<mci_ArchvdresGrpo>();
            this.UsuariosArchivador = new HashSet<ArchivadoresUsuario>();
            this.mci_PrmsoCmpo = new HashSet<mci_PrmsoCmpo>();
            this.mci_ArchvdorVncldo = new HashSet<mci_ArchvdorVncldo>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdTipoArchivador { get; set; }
        public string Nombre { get; set; }
        public string TituloArchivador { get; set; }
        public string FormatoFechaEntrada { get; set; }
        public string FormatoFechaSalida { get; set; }
        public byte MostrarFormularioConsulta { get; set; }
        public string CampoOrdenacion { get; set; }
        public string QueryAdicional { get; set; }
        public string ListaCamposSubconsulta { get; set; }
        public string QueryAdicionalSubconsulta { get; set; }
        public string CamposOcultar { get; set; }
        public string CamposOcultarFormulario { get; set; }
    
        public virtual TipoArchivador TipoArchivador { get; set; }
        public virtual ICollection<mci_ArchvdresGrpo> mci_ArchvdresGrpo { get; set; }
        public virtual ICollection<ArchivadoresUsuario> UsuariosArchivador { get; set; }
        public virtual ICollection<mci_PrmsoCmpo> mci_PrmsoCmpo { get; set; }
        public virtual ICollection<mci_ArchvdorVncldo> mci_ArchvdorVncldo { get; set; }
    }
}

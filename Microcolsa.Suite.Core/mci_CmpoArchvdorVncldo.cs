//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microcolsa.Suite.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class mci_CmpoArchvdorVncldo
    {
        public int intId { get; set; }
        public int intIdCnfgrcion { get; set; }
        public int intIdArchvdorVncldo { get; set; }
        public string strCmpoPdre { get; set; }
        public string strCmpoVncldo { get; set; }
    
        public virtual mci_ArchvdorVncldo mci_ArchvdorVncldo { get; set; }
    }
}

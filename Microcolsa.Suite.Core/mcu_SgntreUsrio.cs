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
    
    public partial class mcu_SgntreUsrio
    {
        public int intId { get; set; }
        public int intIdUsrio { get; set; }
        public byte[] blobSgntre { get; set; }
    
        public virtual Usuario mcu_Usrio { get; set; }
    }
}

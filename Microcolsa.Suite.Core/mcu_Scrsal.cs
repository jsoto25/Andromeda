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
    
    public partial class mcu_Scrsal
    {
        public mcu_Scrsal()
        {
            this.mcu_ScrslesUsrio = new HashSet<mcu_ScrslesUsrio>();
        }
    
        public int intId { get; set; }
        public int intIdCdad { get; set; }
        public string strNmbre { get; set; }
    
        public virtual mcu_Cdad mcu_Cdad { get; set; }
        public virtual ICollection<mcu_ScrslesUsrio> mcu_ScrslesUsrio { get; set; }
    }
}

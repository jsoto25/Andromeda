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
    
    public partial class mcu_Dpndncia
    {
        public mcu_Dpndncia()
        {
            this.mcu_SbDpndncia = new HashSet<mcu_SbDpndncia>();
        }
    
        public int intId { get; set; }
        public int intIdEmprsa { get; set; }
        public string strNmbre { get; set; }
    
        public virtual mcu_Emprsa mcu_Emprsa { get; set; }
        public virtual ICollection<mcu_SbDpndncia> mcu_SbDpndncia { get; set; }
    }
}
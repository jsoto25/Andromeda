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
    
    public partial class mcu_Dprtmnto
    {
        public mcu_Dprtmnto()
        {
            this.mcu_Cdad = new HashSet<mcu_Cdad>();
        }
    
        public int intId { get; set; }
        public int intIdPais { get; set; }
        public string strCdgo { get; set; }
        public string strNmbre { get; set; }
    
        public virtual ICollection<mcu_Cdad> mcu_Cdad { get; set; }
        public virtual mcu_Pais mcu_Pais { get; set; }
    }
}
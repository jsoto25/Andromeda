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
    
    public partial class mcu_TpoIdntfccion
    {
        public mcu_TpoIdntfccion()
        {
            this.mcu_Usrio = new HashSet<Usuario>();
        }
    
        public int intId { get; set; }
        public string strNmbre { get; set; }
        public string strDscrpcion { get; set; }
    
        public virtual ICollection<Usuario> mcu_Usrio { get; set; }
    }
}

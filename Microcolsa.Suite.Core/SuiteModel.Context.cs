﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Microcolsa.Suite.Core.ConsultaInternet;
    
    public partial class SuiteEntities : DbContext
    {
        public SuiteEntities()
            : base("name=SuiteEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Archivador> Archivadores { get; set; }
        public DbSet<mci_ArchvdorVncldo> mci_ArchvdorVncldo { get; set; }
        public DbSet<mci_ArchvdresGrpo> mci_ArchvdresGrpo { get; set; }
        public DbSet<ArchivadoresUsuario> mci_ArchvdresUsrio { get; set; }
        public DbSet<mci_CmpoArchvdorVncldo> mci_CmpoArchvdorVncldo { get; set; }
        public DbSet<mci_PrmsoCmpo> mci_PrmsoCmpo { get; set; }
        public DbSet<mci_SbCnfigDcwre> mci_SbCnfigDcwre { get; set; }
        public DbSet<mci_SbCnfigMcrclsaDcments> mci_SbCnfigMcrclsaDcments { get; set; }
        public DbSet<mci_SbCnfigShrePoint> mci_SbCnfigShrePoint { get; set; }
        public DbSet<TipoArchivador> mci_TpoArchvdor { get; set; }
        public DbSet<mcu_AplccionUsrio> mcu_AplccionUsrio { get; set; }
        public DbSet<mcu_CCsto> mcu_CCsto { get; set; }
        public DbSet<mcu_Cdad> mcu_Cdad { get; set; }
        public DbSet<mcu_Dpndncia> mcu_Dpndncia { get; set; }
        public DbSet<mcu_Dprtmnto> mcu_Dprtmnto { get; set; }
        public DbSet<mcu_Emprsa> mcu_Emprsa { get; set; }
        public DbSet<mcu_Grpo> mcu_Grpo { get; set; }
        public DbSet<mcu_GrpoUsrio> mcu_GrpoUsrio { get; set; }
        public DbSet<mcu_MdloAplccion> mcu_MdloAplccion { get; set; }
        public DbSet<mcu_MdloUsrio> mcu_MdloUsrio { get; set; }
        public DbSet<mcu_Pais> mcu_Pais { get; set; }
        public DbSet<mcu_SbDpndncia> mcu_SbDpndncia { get; set; }
        public DbSet<mcu_Scrsal> mcu_Scrsal { get; set; }
        public DbSet<mcu_ScrslesUsrio> mcu_ScrslesUsrio { get; set; }
        public DbSet<mcu_SgntreUsrio> mcu_SgntreUsrio { get; set; }
        public DbSet<mcu_TpoIdntfccion> mcu_TpoIdntfccion { get; set; }
        public DbSet<Usuario> mcu_Usrio { get; set; }
    }
}

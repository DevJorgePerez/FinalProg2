﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capa_Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class contabilidadEntities : DbContext
    {
        public contabilidadEntities()
            : base("name=contabilidadEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Catalogo_de_Cuentas> Catalogo_de_Cuentas { get; set; }
        public virtual DbSet<Movimiento_Contable> Movimiento_Contable { get; set; }
        public virtual DbSet<Tipo_de_Cuenta> Tipo_de_Cuenta { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LaYuleTravelsEntities2 : DbContext
    {
        public LaYuleTravelsEntities2()
            : base("name=LaYuleTravelsEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Excursione> Excursiones { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Reservacione> Reservaciones { get; set; }
        public virtual DbSet<Restaurante> Restaurantes { get; set; }
    }
}

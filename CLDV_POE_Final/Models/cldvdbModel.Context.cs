﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CLDV_POE_Final.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class st10081893cldvEntities : DbContext
    {
        public st10081893cldvEntities()
            : base("name=st10081893cldvEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_bodyType> tbl_bodyType { get; set; }
        public virtual DbSet<tbl_car> tbl_car { get; set; }
        public virtual DbSet<tbl_carInspectorDriver> tbl_carInspectorDriver { get; set; }
        public virtual DbSet<tbl_driver> tbl_driver { get; set; }
        public virtual DbSet<tbl_inspector> tbl_inspector { get; set; }
        public virtual DbSet<tbl_manufacturer> tbl_manufacturer { get; set; }
        public virtual DbSet<tbl_modelInfo> tbl_modelInfo { get; set; }
        public virtual DbSet<tbl_person> tbl_person { get; set; }
        public virtual DbSet<tbl_rental> tbl_rental { get; set; }
        public virtual DbSet<tbl_returns> tbl_returns { get; set; }
    }
}

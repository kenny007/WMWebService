﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wareman.Service
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WMDBDEMOEntities : DbContext
    {
        public WMDBDEMOEntities()
            : base("name=WMDBDEMOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PO_Detail> PO_Detail { get; set; }
        public virtual DbSet<PO_FollowupDetail> PO_FollowupDetail { get; set; }
        public virtual DbSet<PO_FollowupHeader> PO_FollowupHeader { get; set; }
        public virtual DbSet<PO_Header> PO_Header { get; set; }
        public virtual DbSet<PT_Parts> PT_Parts { get; set; }
        public virtual DbSet<PT_RequisitionDetail> PT_RequisitionDetail { get; set; }
        public virtual DbSet<PT_RequisitionHeader> PT_RequisitionHeader { get; set; }
        public virtual DbSet<PayEmployee> PayEmployees { get; set; }
    }
}

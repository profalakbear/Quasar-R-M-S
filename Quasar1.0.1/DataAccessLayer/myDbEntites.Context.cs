//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quasar1._0._1.DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class testWinFormDBEntities : DbContext
    {
        public testWinFormDBEntities()
            : base("name=testWinFormDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BILLS> BILLS { get; set; }
        public virtual DbSet<DISH_LIST> DISH_LIST { get; set; }
        public virtual DbSet<DISHES> DISHES { get; set; }
        public virtual DbSet<ROLES> ROLES { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }
    }
}

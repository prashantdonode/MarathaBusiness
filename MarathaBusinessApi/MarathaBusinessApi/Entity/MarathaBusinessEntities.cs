namespace MarathaBusinessApi.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using MarathaBusinessApi.Models;

    public partial class MarathaBusinessEntities : DbContext
    {
        public MarathaBusinessEntities()
            : base("name=MarathaBusinessEntities")
        {
        }

        public DbSet<tblBusinessManRegistration> tblBusinessManRegistrations { get; set; }
        public DbSet<tblOccupation> tblOccupations { get; set; }
        public DbSet<tblSkyAdmin> tblSkyAdmins { get; set; }
        public DbSet<tblProductImage> tblProductImages { get; set; }
        public object Files { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

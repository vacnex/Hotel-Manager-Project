namespace Model.Frameworks
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HotelManagerDBContext : DbContext
    {
        public HotelManagerDBContext()
            : base("name=HotelManagerDBContext")
        {
        }

        public virtual DbSet<tbl_account> tbl_account { get; set; }
        public virtual DbSet<tbl_customer> tbl_customer { get; set; }
        public virtual DbSet<tbl_room> tbl_room { get; set; }
        public virtual DbSet<tbl_roombook> tbl_roombook { get; set; }
        public virtual DbSet<tbl_services> tbl_services { get; set; }
        public virtual DbSet<tbl_servicesuse> tbl_servicesuse { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_customer>()
                .HasMany(e => e.tbl_roombook)
                .WithRequired(e => e.tbl_customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_customer>()
                .HasMany(e => e.tbl_servicesuse)
                .WithRequired(e => e.tbl_customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_room>()
                .HasMany(e => e.tbl_roombook)
                .WithRequired(e => e.tbl_room)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_services>()
                .HasMany(e => e.tbl_servicesuse)
                .WithRequired(e => e.tbl_services)
                .WillCascadeOnDelete(false);
        }
    }
}

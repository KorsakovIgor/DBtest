namespace DBtest
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()  : base("name=DboContext")
        {
        }

        public virtual DbSet<dep> deps { get; set; }
        public virtual DbSet<person> persons { get; set; }
        public virtual DbSet<post> posts { get; set; }
        public virtual DbSet<status> status { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dep>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<person>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<person>()
                .Property(e => e.second_name)
                .IsUnicode(false);

            modelBuilder.Entity<person>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<post>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<status>()
                .Property(e => e.name)
                .IsUnicode(false);
        }
    }
}

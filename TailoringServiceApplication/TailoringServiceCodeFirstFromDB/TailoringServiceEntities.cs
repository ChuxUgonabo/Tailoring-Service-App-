using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TailoringServiceCodeFirstFromDB
{
    public partial class TailoringServiceEntities : DbContext
    {
        public TailoringServiceEntities()
            : base("name=TailoringServiceEntities")
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Measurement> Measurements { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Measurement>()
                .Property(e => e.Gender)
                .IsFixedLength();
        }
    }
}

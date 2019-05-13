namespace Bertani
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LahanModel : DbContext
    {
        public LahanModel()
            : base("name=LahanModel")
        {
        }

        public virtual DbSet<Lahan> Lahans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lahan>()
                .Property(e => e.LuasLahan)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Lahan>()
                .Property(e => e.HargaBibit)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Lahan>()
                .Property(e => e.HargaPerawatan)
                .HasPrecision(20, 0);
        }
    }
}

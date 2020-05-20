namespace Helth
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class JadwalEntity : DbContext
    {
        public JadwalEntity()
            : base("name=JadwalEntity")
        {
        }

        public virtual DbSet<JadwalDB> JadwalDBs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

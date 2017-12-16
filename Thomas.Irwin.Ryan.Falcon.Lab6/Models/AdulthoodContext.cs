namespace Thomas.Irwin.Ryan.Falcon.Lab6.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AdulthoodContext : DbContext
    {
        public AdulthoodContext()
            : base("name=AdulthoodContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<post> posts { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<user>()
                .HasMany(e => e.posts)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.author_userId);
        }
    }
}

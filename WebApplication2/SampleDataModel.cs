namespace WebApplication2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SampleDataModel : DbContext
    {
        public SampleDataModel()
            : base("name=DB_Entities")
        {
        }

        public virtual DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProfile>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserProfile>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}

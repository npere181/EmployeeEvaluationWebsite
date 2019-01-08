namespace WebApplication2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB_Test : DbContext
    {
        public DB_Test()
            : base("name=DB_Test")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Choice> Choices { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.Auserid)
                .IsFixedLength();

            modelBuilder.Entity<Admin>()
                .Property(e => e.Aname)
                .IsFixedLength();

            modelBuilder.Entity<Admin>()
                .Property(e => e.Atrade)
                .IsFixedLength();

            modelBuilder.Entity<Answer>()
                .Property(e => e.AnswerId)
                .IsFixedLength();

            modelBuilder.Entity<Answer>()
                .Property(e => e.QuestionId)
                .IsFixedLength();

            modelBuilder.Entity<Answer>()
                .Property(e => e.AuserId)
                .IsFixedLength();

            modelBuilder.Entity<Answer>()
                .Property(e => e.Userid)
                .IsFixedLength();

            modelBuilder.Entity<Choice>()
                .Property(e => e.ChoiceId)
                .IsFixedLength();

            modelBuilder.Entity<Choice>()
                .Property(e => e.ChoiceText)
                .IsFixedLength();

            modelBuilder.Entity<Choice>()
                .Property(e => e.QuestionId)
                .IsFixedLength();

            modelBuilder.Entity<Profile>()
                .Property(e => e.UserId)
                .IsFixedLength();

            modelBuilder.Entity<Profile>()
                .Property(e => e.Trade)
                .IsFixedLength();

            modelBuilder.Entity<Question>()
                .Property(e => e.QuestionId)
                .IsFixedLength();

            modelBuilder.Entity<Question>()
                .Property(e => e.ChoiceId)
                .IsFixedLength();

            modelBuilder.Entity<UserProfile>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserProfile>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}

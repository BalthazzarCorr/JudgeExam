namespace Judge.App.Data
{
   using EntityModels;
   using Microsoft.EntityFrameworkCore;

   public class JudgeDbContext : DbContext
   {
      public DbSet<User> Users { get; set; }


      protected override void OnConfiguring(DbContextOptionsBuilder builder)
      {
         builder.UseSqlServer(@"Server=.\SQL;Database=JudgeDb;Integrated security=True");
      }

      protected override void OnModelCreating(ModelBuilder builder)
      {
         builder
            .Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();
      }

   }
}


using Library.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace addDb;


public class ApplicationDbContext : DbContext {
  public DbSet<Magazine> Magazines { get; set; }
  public DbSet<Book> Books { get; set; }
  public DbSet<Reader> Readers { get; set; }
  public DbSet<Author> Authors { get; set; }
  public DbSet<User> Users { get; set; }

  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
    //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test");
  }


}




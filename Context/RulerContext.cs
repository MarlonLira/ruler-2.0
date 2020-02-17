using Ruler.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Ruler.Context
{
  public partial class RulerContext : DbContext
  {
    public RulerContext() : base("name=ruler")
    {
      Database.SetInitializer(new MigrateDatabaseToLatestVersion<RulerContext, Migrations.Configuration>());
    }
    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      Database.SetInitializer(new CreateDatabaseIfNotExists<RulerContext>());
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
      //modelBuilder.HasDefaultSchema("user");
      modelBuilder.Entity<Client>().ToTable("Client");
      modelBuilder.Entity<Product>().ToTable("Product");

      base.OnModelCreating(modelBuilder);
    }

  }
}
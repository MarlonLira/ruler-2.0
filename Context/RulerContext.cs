using Ruler.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

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
      //modelBuilder.HasDefaultSchema("ruler");

      //modelBuilder.Entity<Client>().ToTable("Client");

      //modelBuilder.Entity<Product>().ToTable("Product");
    }

  }
}
namespace Ruler.Migrations
{
  using System;
  using System.Data.Entity;
  using System.Data.Entity.Migrations;
  using System.Linq;

  internal sealed class Configuration : DbMigrationsConfiguration<Context.RulerContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = true;
      ContextKey = "Context.RulerContext";
    }

    protected override void Seed(Context.RulerContext context)
    {
      //  This method will be called after migrating to the latest version.

      //  You can use the DbSet<T>.AddOrUpdate() helper extension method
      //  to avoid creating duplicate seed data.

      
    }
  }
}

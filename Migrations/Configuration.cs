namespace Ruler.Migrations
{
  using Ruler.Models;
  using System.Collections.Generic;
  using System.Data.Entity.Migrations;

  internal sealed class Configuration : DbMigrationsConfiguration<Context.RulerContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = true;
      ContextKey = "Context.RulerContext";
    }

    protected override void Seed(Context.RulerContext context)
    {
      IList<Client> Clients = new List<Client>();
      IList<Product> Products = new List<Product>();

      Clients.Add(new Client() { Name = "Marlon Lira", Phone = "81985445636", RegistryCode = "08565425875" });
      Clients.Add(new Client() { Name = "Arthur Bernardo", Phone = "81977545886", RegistryCode = "05265852875" });
      Clients.Add(new Client() { Name = "Gustavo Gusmão", Phone = "81966444436", RegistryCode = "08798425255" });
      Clients.Add(new Client() { Name = "Felipe Seabra", Phone = "81965445786", RegistryCode = "08896325857" });

      Products.Add(new Product() { Name = "Iphone 10", Category = "Smartphone", Price = 7000d, Brand="Apple", Lot="XL00001",RegistryCode="GTH88866LKH" });
      Products.Add(new Product() { Name = "Redmi Note 8", Category = "Smartphone", Price = 1500d, Brand="Xiaomi", Lot="PL05501",RegistryCode="GUI899666LBR" });
      Products.Add(new Product() { Name = "Galaxy S8", Category = "Smartphone", Price = 2200d, Brand="Samsung", Lot="AX08901",RegistryCode="LOP00366ERR" });
      Products.Add(new Product() { Name = "Zenfone 5", Category = "Smartphone", Price = 2200d, Brand="Asus", Lot="AS099023",RegistryCode="POI08796EUY" });

      context.Clients.AddRange(Clients);
      context.Products.AddRange(Products);

      base.Seed(context);
    }
  }
}

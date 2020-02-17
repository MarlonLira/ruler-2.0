using Ruler.Context;
using Ruler.Controllers;
using Ruler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;


namespace Ruler
{
  public partial class Default : Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      LoadEntities();
      //var cl = new ClientController();
      //var b = cl.Save(new Client() { Name = "Marlon", Phone = "81985665252", RegistryCode = "02536547752" });
      ////var r = cl.Search(1);

      //var p1 = new ProductController();
      //var a = p1.Save(new Product()
      //{
      //  Name = "Notebook",
      //  Brand = "Dell",
      //  ManufactDate = DateTime.UtcNow.AddHours(-3)
      //});

      //Response.Redirect("HomePge.aspx", false);

    }

    public Client client { get { return new ClientController().Search(1).FirstOrDefault(); } }
    public Product product { get { return new ProductController().Search(2).FirstOrDefault(); } }
    public string Teste { get { return "testando"; } }

    private void LoadEntities()
    {
      if (new ClientController().Search(1).FirstOrDefault() == null && new ClientController().Search(2).FirstOrDefault() == null)
      {
        IList<Client> Clients = new List<Client>();
        new ClientController().Save(new Client() { Name = "Marlon Lira", Phone = "81985445636", RegistryCode = "08565425875" });
        new ClientController().Save(new Client() { Name = "Arthur Bernardo", Phone = "81977545886", RegistryCode = "05265852875" });
        new ClientController().Save(new Client() { Name = "Gustavo Gusmão", Phone = "81966444436", RegistryCode = "08798425255" });
        new ClientController().Save(new Client() { Name = "Felipe Seabra", Phone = "81965445786", RegistryCode = "08896325857" });
      }
      if (new ProductController().Search(2).FirstOrDefault() == null && new ProductController().Search(1).FirstOrDefault() == null) { 
        IList<Product> Products = new List<Product>();

        new ProductController().Save(new Product() { Name = "Iphone 10", Category = "Smartphone", Price = 7000d, Brand = "Apple", Lot = "XL00001", RegistryCode = "GTH88866LKH" });
        new ProductController().Save(new Product() { Name = "Redmi Note 8", Category = "Smartphone", Price = 1500d, Brand = "Xiaomi", Lot = "PL05501", RegistryCode = "GUI899666LBR" });
        new ProductController().Save(new Product() { Name = "Galaxy S8", Category = "Smartphone", Price = 2200d, Brand = "Samsung", Lot = "AX08901", RegistryCode = "LOP00366ERR" });
        new ProductController().Save(new Product() { Name = "Zenfone 5", Category = "Smartphone", Price = 2200d, Brand = "Asus", Lot = "AS099023", RegistryCode = "POI08796EUY" });
      }
    }
  }
}
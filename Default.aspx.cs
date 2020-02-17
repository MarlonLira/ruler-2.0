using Ruler.Context;
using Ruler.Controllers;
using Ruler.Models;
using System;
using System.Linq;
using System.Web.UI;


namespace Ruler
{
  public partial class Default : Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      var cl = new ClientController();
      //var b = cl.Save(new Client() { Name = "Marlon", Phone = "81985665252", RegistryCode = "02536547752" });
      //var r = cl.Search(1);

      var p1 = new ProductController();
      var a = p1.Save(new Product() {
        Name = "Notebook",
        Brand = "Dell",
        ManufactDate = DateTime.UtcNow.AddHours(-3)
      });

    }

    public Client client { get { return new ClientController().Search(1).FirstOrDefault(); } }
    public Product product { get { return new ProductController().Search(2).FirstOrDefault(); } }
    public string Teste { get { return "testando"; } }
  }
}
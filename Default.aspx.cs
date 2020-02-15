using Ruler.Context;
using Ruler.Controllers;
using Ruler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ruler
{
  public partial class Default : Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      //var cl = new ClientController();
      //var a = cl.Search(3);
      //client = new Client();
      //client = a.FirstOrDefault<Client>();

      //client.Save(new Models.Client() { Name = "Wedson", Phone = "111111", RegistryCode = "66666" });
    }

    public Client client { get { return new ClientController().Search(3).FirstOrDefault<Client>(); } } 
    public string Teste { get { return "testando"; } }
  }
}
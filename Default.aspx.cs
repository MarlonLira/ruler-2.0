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
      var cl = new ClientController();
      var b = cl.Save(new Models.Client() { Name = "Marlon", Phone = "81985665252", RegistryCode = "02536547752" });
      //var r = cl.Search(1);

    }

    public Client client { get { return new ClientController().Search(1).FirstOrDefault(); } }
    public string Teste { get { return "testando"; } }
  }
}
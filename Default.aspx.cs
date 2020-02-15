using Ruler.Context;
using Ruler.Controllers;
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
      var client = new ClientController();
      client.Save(new Models.Client() { Name = "Wedson", Phone = "111111", RegistryCode = "66666" });
    }
  }
}
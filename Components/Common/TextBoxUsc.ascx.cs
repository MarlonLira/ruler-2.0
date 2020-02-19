using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ruler.Components.Common
{
  public partial class TextBoxUsc : BaseCommonUsc
  {
    public string Placeholder { get; set; }
    public string Value { get; set; }
    public string Icon { get; set; }

    public string LoadIcon()
    {
      return "";
    }
  }
}
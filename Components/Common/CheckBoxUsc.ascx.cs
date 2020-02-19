using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ruler.Components.Common
{
  public partial class ChekBoxUsc : BaseCommonUsc
  {
  
    public bool IsChecked { get { return chkControl.Checked; } }

    public void Checked()
    {
      chkControl.Attributes.Add("checked", "checked");
      chkControl.Checked = true;
    }

  }
}
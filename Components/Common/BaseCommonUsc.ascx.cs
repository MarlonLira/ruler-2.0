using System;
using System.Web.UI;

namespace Ruler.Components.Common
{
  public partial class BaseCommonUsc : UserControl
  {
    //common attributes
    public string Text { get; set; }
    public string Type { get; set; }
    public string Icon { get; set; }

    public string CreateComponentId() => Guid.NewGuid().ToString(this.ID);

    // common styles
    //public string Style
    //{
    //  get { return string.IsNullOrEmpty(Style) ? "primary" : Style; }
    //  set { Style = value; }
    //}
  }
}
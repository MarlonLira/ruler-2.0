using System.Web.UI;

namespace Ruler.Components.Common
{
  public partial class BaseCommonUsc : UserControl
  {
    //common attributes
    public string Id { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
    // common styles
    //public string Style
    //{
    //  get { return string.IsNullOrEmpty(Style) ? "primary" : Style; }
    //  set { Style = value; }
    //}
  }
}
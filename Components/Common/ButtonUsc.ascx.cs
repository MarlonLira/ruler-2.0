using System;

namespace Ruler.Components.Common
{
  public partial class ButtonUsc : BaseCommonUsc
  {
    public string Text { get; set; }

    public delegate void OnclickEvent();
    public event OnclickEvent OnClick;

    protected void Btn_Click(object sender, EventArgs e)
    {
      try
      {
        OnClick?.Invoke();
      }
      catch
      {
        throw;
      }
    }
  }
}
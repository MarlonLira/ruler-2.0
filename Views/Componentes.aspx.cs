using System;
using System.Web.UI;
using Ruler.Components.Common;

namespace Ruler.Views
{
  public partial class Componentes : Page
  {
    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      btnSalvar.OnClick += new ButtonUsc.OnclickEvent(BtnSalvar_OnClick);
    }

    private void BtnSalvar_OnClick()
    {
      txtNome.Value = "Teste";
      txtNumber.Value = "404";
    }
  }
}
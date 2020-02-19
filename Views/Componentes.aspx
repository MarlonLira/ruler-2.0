<%@ Page Title="" Language="C#" MasterPageFile="~/BasePge.Master" AutoEventWireup="true" CodeBehind="Componentes.aspx.cs" Inherits="Ruler.Views.Componentes" %>

<asp:Content ID="ctt_components" ContentPlaceHolderID="cph_main" runat="server">
  <div class="card-form">
    <div class="card col-6">
      <div class="card-header">
        <h1>Form</h1>
      </div>
      <div class="card-body">
        <label>Nome</label>
        <usc:TextBox runat="server" Id="txtNome" Value="nome" Icon="envelope-open" Type="text" Placeholder="Digite seu nome" />
        <label>Number</label>
        <usc:TextBox runat="server" Id="txtNumber" Type="number" Icon="lock" Placeholder="Digite o seu número" />

          <div class="row">
            <usc:CheckBox runat="server" Id="chkBox" Text="aqui" />
        </div>
      </div>
      <div class="card-footer">
        <usc:Button runat="server" Id="btnSalvar" Text="Salvar" />
      </div>
    </div>
  </div>
</asp:Content>

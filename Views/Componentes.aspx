<%@ Page Title="" Language="C#" MasterPageFile="~/BasePge.Master" AutoEventWireup="true" CodeBehind="Componentes.aspx.cs" Inherits="Ruler.Views.Componentes" %>

<asp:Content ID="ctt_components" ContentPlaceHolderID="cph_main" runat="server">
  <div class="card-form">
    <div class="card col-6">
      <div class="card-header">
        <h1>Form</h1>
      </div>
      <div class="card-body">
        <usc:TextBox runat="server" Id="txtNome" Value="nome" Title="Nome" Type="text" Placeholder="Digite seu nome" />
        <usc:TextBox runat="server" Id="txtNumber" Title="Número" Type="number" Placeholder="Digite o seu número" />
        
        <div class="row">
            <usc:CheckBox runat="server" Id="chBox" Type="checkbox" />
            <label>Remember Me</label>
        </div>
        
      </div>
      <div class="card-footer">
        <usc:Button runat="server" Id="btnSalvar" Title="Salvar" />
      </div>
    </div>
  </div>
</asp:Content>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ruler.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <h1>Olá Mundo</h1>
          <h1>Nome: <%=client.Name%></h1>
          <h1>Telefone: <%=client.Phone%></h1>
          <h1>CPF: <%=client.RegistryCode%></h1>
        </div>
    </form>
</body>
</html>

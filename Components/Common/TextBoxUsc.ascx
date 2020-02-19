<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TextBoxUsc.ascx.cs" Inherits="Ruler.Components.Common.TextBoxUsc" %>

<div class="input-group mb-3">
    <input type="<%=Type%>" id="txtControl>" value="<%=Value %>" class="form-control" placeholder="<%=Placeholder%>">
    <div class="input-group-append">
        <%if (!string.IsNullOrEmpty(Icon)) { %>
            <div class="input-group-text">
                <span class="fas fa-<%=Icon %>"></span>
            </div>
        <%} %>
    </div>
</div>

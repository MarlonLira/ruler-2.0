<%@ Control Language="C#" CodeBehind="DropdownMnUsc.ascx.cs" Inherits="Ruler.Components.Template.Common.DropdownMnUsc" %>


<li class="nav-item dropdown">
  <a class="nav-link" data-toggle="dropdown" href="#">
    <i class="far fa-comments"></i>
    <span class="badge badge-danger navbar-badge">3</span>
  </a>
  <div class="dropdown-menu dropdown-menu-lg dropdown-menu-right">
    <usc:DropdownItem runat="server" ID="dditem" />
    <div class="dropdown-divider"></div>
    <a href="#" class="dropdown-item dropdown-footer">See All Messages</a>
  </div>
</li>



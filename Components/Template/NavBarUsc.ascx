<%@ Control Language="C#" CodeBehind="NavBarUsc.ascx.cs" Inherits="Ruler.Components.Template.NavBarUsc" %>

<!-- Navbar -->
<nav class="main-header navbar navbar-expand navbar-white navbar-light">
<!-- Left navbar links -->
  <usc:NavbarLink runat="server" ID="navbar_left" />

<!-- SEARCH FORM -->
  <usc:SearchForm runat="server" ID="search_form" />

<!-- Right navbar links -->
<ul class="navbar-nav ml-auto">
    <!-- Messages Dropdown Menu -->
    <usc:DropdownMn runat="server" ID="mnudd" />
    <!-- Notifications Dropdown Menu -->
    <usc:DropdownNtf runat="server" ID="ntfdd" />
    <li class="nav-item">
    <a class="nav-link" data-widget="control-sidebar" data-slide="true" href="#"><i
        class="fas fa-th-large"></i></a>
    </li>
</ul>
</nav>
<!-- /.navbar -->
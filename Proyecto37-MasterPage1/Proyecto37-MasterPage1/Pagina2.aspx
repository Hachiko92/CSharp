<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pagina2.aspx.cs" Inherits="Proyecto37_MasterPage1.Pagina2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Contenido" runat="server">
    Dato Original:
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="server">
    <!-- Codigo Spaghetti -> lo que va en <% %> es c# -->
    <asp:TextBox ID="txtFecha" Text="<% DateTime.Now %>" runat="server"></asp:TextBox>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pagina2.aspx.cs" Inherits="EjercicioASP6_1.Pagina2" %>
<%@ PreviousPageType VirtualPath="~/Pagina1.aspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Nombre concatenado"></asp:Label>
    <asp:TextBox ID="txtNombreCompleto" runat="server"></asp:TextBox>
</asp:Content>

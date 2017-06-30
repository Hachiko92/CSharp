<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="EjercicioASP5_2.WebForm2" %>
<%@ PreviousPageType VirtualPath="~/WebForm1.aspx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Label ID="Label1" runat="server" Text="Media: "></asp:Label>
        <asp:TextBox ID="txtMedia" AutoPostBack="true" runat="server"></asp:TextBox>

    </div>
    </form>
</body>
</html>

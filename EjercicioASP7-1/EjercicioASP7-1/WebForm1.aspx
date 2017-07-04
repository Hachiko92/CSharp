<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP7_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="ProductID"></asp:Label>
        <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br /><br />
        <asp:Label ID="lblUnidades" runat="server" Text="Unidades en stock: "></asp:Label>
        <asp:TextBox ID="txtUnidades" runat="server"></asp:TextBox>

    </div>
    </form>
</body>
</html>

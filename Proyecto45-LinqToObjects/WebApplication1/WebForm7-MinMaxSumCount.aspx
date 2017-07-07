<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7-MinMaxSumCount.aspx.cs" Inherits="WebApplication1.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Precio Minimo: 
        <asp:TextBox ID="txtMinimo" runat="server"></asp:TextBox>
        <br />
        Precio Máximo: 
        <asp:TextBox ID="txtMaximo" runat="server"></asp:TextBox>
        <br />
        Total: 
        <asp:TextBox ID="txtTotal" runat="server"></asp:TextBox>
        <br />
        Libros baratos(<300): 
        <asp:TextBox ID="txtBarato" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>

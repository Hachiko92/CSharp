<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP7.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Precio maximo por la cual ha sido vendido un producto</h2>
        <asp:Label ID="lblProducto" runat="server" Text="Producto: "></asp:Label>
        <asp:DropDownList ID="drpProductos" AutoPostBack="true" runat="server" OnSelectedIndexChanged="drpProductos_SelectedIndexChanged"></asp:DropDownList>
        <br /><br />
        <asp:Label ID="lblPrecio" runat="server" Text="Precio maximo: "></asp:Label>
        <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>

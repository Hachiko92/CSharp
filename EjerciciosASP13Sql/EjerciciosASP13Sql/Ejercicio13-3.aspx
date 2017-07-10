<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio13-3.aspx.cs" Inherits="EjerciciosASP13Sql.Ejercicio13_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataList ID="DataList1" runat="server">
            <HeaderTemplate>
                <h2>Productos con precio mayor que 50€</h2>
            </HeaderTemplate>
            <ItemTemplate>
                <asp:Label ID="lblNombre" runat="server" Text="<strong>Producto: </strong>"></asp:Label>
                <span><%# Eval("Producto") %></span>
                <br />
                <asp:Label ID="lblFecha" runat="server" Text="<strong>Unedades in stock: </strong>"></asp:Label>
                <span><%# Eval("Unidades") %></span>
                <br /><br />
            </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>

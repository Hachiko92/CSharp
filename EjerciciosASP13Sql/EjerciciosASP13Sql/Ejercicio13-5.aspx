<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio13-5.aspx.cs" Inherits="EjerciciosASP13Sql.Ejercicio13_5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataList ID="dtlPedidos" runat="server">
            <HeaderTemplate>
                <h2>Fecha pedidos por empleado</h2>
            </HeaderTemplate>
            <ItemTemplate>
                <span><%# Convert.ToDateTime(Eval("Pedido")).ToShortDateString() %> (<%# Eval("Empleado") %>)</span>
                <br /><br />
            </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>

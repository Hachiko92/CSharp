<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio13-4.aspx.cs" Inherits="EjerciciosASP13Sql.Ejercicio13_4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataList ID="dtlClientes" runat="server">
            <HeaderTemplate>
                <h2>Compañias de la ciudad de Sao Paulo</h2>
            </HeaderTemplate>
            <ItemTemplate>
                <asp:Label ID="lblNombre" runat="server" Text="<strong>Cliente: </strong>"></asp:Label>
                <span><%# Eval("Nombre") %></span>
                <br /><br />
            </ItemTemplate>
        </asp:DataList>
        <br />
        <asp:DataList ID="dtlEmpleados" runat="server">
            <HeaderTemplate>
                <h2>Empleados de la ciudad de Londres</h2>
            </HeaderTemplate>
            <ItemTemplate>
                <asp:Label ID="lblNombre" runat="server" Text="<strong>Empleado: </strong>"></asp:Label>
                <span><%# Eval("Nombre") %></span>
                <br />
                <asp:Label ID="lblFecha" runat="server" Text="<strong>Fecha de Nacimiento: </strong>"></asp:Label>
                <span><%# Convert.ToDateTime(Eval("Fecha")).ToShortDateString() %></span>
                <br /><br />
            </ItemTemplate>
        </asp:DataList>
        <br />
        <asp:DataList ID="dtlProductos" runat="server">
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

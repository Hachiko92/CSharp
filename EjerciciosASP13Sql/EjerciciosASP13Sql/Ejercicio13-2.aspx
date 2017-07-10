<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio13-2.aspx.cs" Inherits="EjerciciosASP13Sql.Ejercicio13_2" %>

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
                <h2>Empleados de la ciudad de Londres</h2>
            </HeaderTemplate>
            <ItemTemplate>
                <asp:Label ID="lblNombre" runat="server" Text="<strong>Empleado: </strong>"></asp:Label>
                <span><%# Eval("Nombre") %></span>
                <br />
                <asp:Label ID="lblFecha" runat="server" Text="<strong>Fecha de Nacimiento: </strong>"></asp:Label>
                <span><%# Eval("Fecha") %></span>
                <br /><br />
            </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>

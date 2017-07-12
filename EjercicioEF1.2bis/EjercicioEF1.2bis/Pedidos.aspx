<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="EjercicioEF1._2bis.Pedidos1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Nuevo Pedido</h1>
        <asp:Label ID="lblCliente" runat="server" Text="Cliente: "></asp:Label>
        <asp:DropDownList 
            ID="ddlClientes" 
            AppendDataBoundItems="true"
            runat="server" OnSelectedIndexChanged="ddlClientes_SelectedIndexChanged">
            <asp:ListItem Text=" - Seleccione un Cliente - " Value="0"></asp:ListItem>
        </asp:DropDownList>
        <span id="spanCliente" runat="server"></span>
        <br />
        <asp:Label ID="lblProducto" runat="server" Text="Producto: "></asp:Label>
        <asp:DropDownList 
            ID="ddlProducto" 
            AppendDataBoundItems="true"
            runat="server">
            <asp:ListItem Text=" - Seleccione un Cliente - " Value="0"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="lblCantidad" runat="server" Text="Cantidad: "></asp:Label>
        <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
        <asp:Button ID="btnCrear" runat="server" Text="Button" />

        <%if (IsPostBack) { %>

        <asp:GridView ID="grdPedido" runat="server"></asp:GridView>

        <%} %>
    </div>
    </form>
</body>
</html>

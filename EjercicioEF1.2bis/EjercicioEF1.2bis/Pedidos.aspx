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
        <span id="spanCliente" visible="false" runat="server">Campo obligatorio:</span>
        <br />
        <asp:Label ID="lblCliente" runat="server" Text="Cliente: "></asp:Label>
        <asp:DropDownList 
            ID="ddlClientes" 
            AppendDataBoundItems="true"
            runat="server" OnSelectedIndexChanged="ddlClientes_SelectedIndexChanged">
            <asp:ListItem Text=" - Seleccione un Cliente - " Value="0"></asp:ListItem>
        </asp:DropDownList>
        
        <br />

        <span id="spanProducto" visible="false" runat="server">Campo obligatorio:</span>
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
        <asp:Button ID="btnPedir" runat="server" Text="Pedir" OnClick="btnPedir_Click" />


        <br /><br />

        <%if (IsPostBack) { %>

        <asp:GridView ID="grdPedido" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>

        <%} %>
    </div>
    </form>
</body>
</html>

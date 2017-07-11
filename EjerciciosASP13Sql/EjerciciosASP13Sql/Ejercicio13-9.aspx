<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio13-9.aspx.cs" Inherits="EjerciciosASP13Sql.Ejercicio13_9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbl1" runat="server" Text="1· Pedidos de los clientes de Washington"></asp:Label>
        <asp:Button ID="btn1" runat="server" Text="Executar" OnClick="btn1_Click" />
        <br />
        <asp:Label ID="lbl2" runat="server" Text="2· Pedidos efectuado por cada cliente"></asp:Label>
        <asp:Button ID="btn2" runat="server" Text="Executar" OnClick="btn2_Click" />
        <br />
        <asp:Label ID="lbl3" runat="server" Text="3· Pedidos efectuado desde el 01/01/1998"></asp:Label>
        <asp:Button ID="btn3" runat="server" Text="Executar" OnClick="btn3_Click" />
        <br />
        <asp:Label ID="lbl4" runat="server" Text="4· Pedidos efectuado desde el 01/01/1997 por los clientes de Washington"></asp:Label>
        <asp:Button ID="btn4" runat="server" Text="Executar" OnClick="btn4_Click" />
        <br />
        <asp:Label ID="lbl5" runat="server" Text="5· Listado de Productos con sus categoria"></asp:Label>
        <asp:Button ID="btn5" runat="server" Text="Executar" OnClick="btn5_Click" />
        <br />
        <asp:Label ID="lbl6" runat="server" Text="6· El producto más caro por cada categoria"></asp:Label>
        <asp:Button ID="btn6" runat="server" Text="Executar" OnClick="btn6_Click" />
        <br />
        <asp:Label ID="lbl7" runat="server" Text="7· La media del los precios de los producto de cada categoria"></asp:Label>
        <asp:Button ID="btn7" runat="server" Text="Executar" OnClick="btn7_Click" />

        <br /><br />

        <% if (IsPostBack)
            { %>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal"
            >
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <% } %>
    </div>
    </form>
</body>
</html>

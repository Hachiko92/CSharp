<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio13-7.aspx.cs" Inherits="EjerciciosASP13Sql.Ejercicio13_7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ddlCategorias" AutoPostBack="true" AppendDataBoundItems="true" runat="server" OnSelectedIndexChanged="ddlCategorias_SelectedIndexChanged">
            <asp:ListItem Text=" - Seleccione una categoria - " Value="0"></asp:ListItem>
        </asp:DropDownList>
        <br /><br />
        
        <asp:GridView ID="grdProductos" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>

    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio13-8.aspx.cs" Inherits="EjerciciosASP13Sql.Ejercicio13_8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="grdCategorias" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" 
            OnRowCommand="grdCategorias_RowCommand" OnSelectedIndexChanged="grdCategorias_SelectedIndexChanged">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
            <Columns>
                <asp:ButtonField HeaderText="Calcular total" Text="Seleccionar" CommandName="calcular" />
            </Columns>
        </asp:GridView>

        <br /><br />

        <asp:Label ID="lblTotal" runat="server" Text="Total productos en Stock: "></asp:Label>
        <asp:TextBox ID="txtTotal" Enabled="false" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>

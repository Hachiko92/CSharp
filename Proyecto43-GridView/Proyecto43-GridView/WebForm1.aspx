<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Proyecto43_GridView.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView 
            ID="GridView1"
            DataSourceID="SqlDataSource1"
            EnableSortingAndPagingCallbacks="True"
            AllowSorting="True"
            AllowPaging="True"
            EmptyDataText="No hay datos"
            DataKeyNames="ProductID"
            AutoGenerateColumns="False"
            runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField
                    DataField="ProductID"
                    SortExpression="ProductID"
                    HeaderText="Codigo producto" />
                <asp:BoundField
                    DataField="ProductName"
                    SortExpression="ProductName"
                    NullDisplayText="Sin valor"
                    HeaderText="Producto" />
                <asp:BoundField
                    DataField="QuantityPerUnit"
                    SortExpression="QuantityPerUnit"
                    NullDisplayText="Sin valor"
                    HeaderText="Cantidad por unidad" />
                <asp:ButtonField 
                    ButtonType="Button"
                    Text="Imprimir Registro"
                    CommandName="Print" />
                <asp:HyperLinkField 
                    DataTextField="UnitPrice"
                    DataTextFormatString="{0:c}"
                    DataNavigateUrlFields="ProductID"
                    DataNavigateUrlFormatString="WebForm2.aspx?ProductId={0}"
                    HeaderText="Precio unitario"
                    Target="_blank" />
                <asp:CheckBoxField 
                    DataField="Discontinued"
                    HeaderText="Descuento?" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource 
            ID="SqlDataSource1" 
            ConnectionString="<%$ ConnectionStrings:NorthWind %>"
            SelectCommand="SELECT * FROM Products"
            DataSourceMode="DataSet"
            runat="server">
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>

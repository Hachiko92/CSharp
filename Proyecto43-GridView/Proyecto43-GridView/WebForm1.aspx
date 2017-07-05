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
                PageSize="15"
                EmptyDataText="No hay datos"
                DataKeyNames="ProductID"
                AutoGenerateColumns="False"
                runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand">
                <AlternatingRowStyle BackColor="White" />
                <HeaderStyle BackColor="LightBlue" HorizontalAlign="left" />
                <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" PageButtonCount="5" Position="Bottom" />
                <PagerStyle BackColor="LightBlue" Height="30px" Width="30px" VerticalAlign="Bottom" HorizontalAlign="Center" />
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
                        HeaderText="Imprimir Registro"
                        Text="Imprimir"
                        CommandName="Print"
                        ItemStyle-HorizontalAlign="Center" />
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
            </asp:GridView>
            <asp:SqlDataSource
                ID="SqlDataSource1"
                ConnectionString="<%$ ConnectionStrings:NorthWind %>"
                SelectCommand="SELECT * FROM Products"
                DataSourceMode="DataSet"
                runat="server"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>

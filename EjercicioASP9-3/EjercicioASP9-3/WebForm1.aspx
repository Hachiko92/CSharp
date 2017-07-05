<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP9_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ejercicio 9-3</title>
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource 
            ID="sqlProductos" 
            DataSourceMode="DataReader"
            ConnectionString="<%$ ConnectionStrings:NorthWind %>"
            SelectCommand="SELECT ProductID, ProductName FROM Products ORDER BY ProductName"
            runat="server">
        </asp:SqlDataSource>
        <asp:DataList 
            ID="dlProductos" 
            DataSourceID="sqlProductos"
            runat="server">
            <HeaderTemplate>
                <table border="1">
                    <tr>
                        <th><h2>Listado Productos</h2></th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        ID Producto:
                        <%# DataBinder.Eval(Container.DataItem, "ProductId") %>
                        <br />
                        Nombre:
                        <%# DataBinder.Eval(Container.DataItem, "ProductName") %>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
            <%--<SeparatorTemplate>
                <hr />
            </SeparatorTemplate>--%>
        </asp:DataList>
    </div>
    </form>
</body>
</html>

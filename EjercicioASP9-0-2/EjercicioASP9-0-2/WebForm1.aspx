<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP9_0_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>¿Productos descuentados?</h2>
        <asp:RadioButtonList ID="rbDescuento" AutoPostBack="true" runat="server">
            <asp:ListItem Selected="True" Value="1">Si</asp:ListItem>
            <asp:ListItem Value="0">No</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:DataList ID="DataList1" runat="server">
            <HeaderStyle BackColor="LightCyan" />
            <FooterStyle BackColor="LightCyan" />
            <HeaderTemplate>
                <table>
                    <tr>
                        <th>ProductName</th>
                        <th>QuantityPerUnit</th>
                        <th>UnitPrice</th>
                        <th>UnitsInStock</th>
                    </tr>
            </HeaderTemplate>
            <ItemStyle BackColor="WhiteSmoke" ForeColor="DarkGray" />
            <ItemTemplate>
                <tr>
                    <td><%# DataBinder.Eval(Container.DataItem, "ProductName") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "QuantityPerUnit") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "UnitPrice") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem, "UnitsInStock") %></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" Theme="App_Themes" CodeBehind="WebForm5.aspx.cs" Inherits="Proyecto43_GridView.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource 
            ID="SqlDataSource1" 
            ConnectionString="<%$ ConnectionStrings:NorthWind %>" 
            SelectCommand="SELECT TOP 5 ProductId, ProductName, UnitPrice FROM Products ORDER BY ProductName"
            runat="server">
        </asp:SqlDataSource>
        <h2>Un GridView sin Skin</h2>
        <asp:GridView 
            ID="GridView1" 
            DataSourceID="SqlDataSource1"
            DataKeyNames="ProductId"
            AutoGenerateColumns="false"
            runat="server">
            <Columns>
                <asp:BoundField ReadOnly="true"
                    HeaderText="ProductId"
                    DataField="ProductId"
                    SortExpression="ProductId" />
                
                <asp:BoundField
                    HeaderText="ProductName"
                    DataField="ProductName"
                    SortExpression="ProductName" />

                <asp:BoundField
                    HeaderText="UnitPrice"
                    DataField="UnitPrice"
                    SortExpression="UnitPrice" />
            </Columns>
        </asp:GridView>
        <br />
        <h2>Un GridView con skin "professional"</h2>
        <asp:GridView 
            ID="GridView2" 
            DataSourceID="SqlDataSource1"
            SkinID="Professional"
            DataKeyNames="ProductId"
            AutoGenerateColumns="false"
            runat="server">
            <Columns>
                <asp:BoundField ReadOnly="true"
                    HeaderText="ProductId"
                    DataField="ProductId"
                    SortExpression="ProductId" />
                
                <asp:BoundField
                    HeaderText="ProductName"
                    DataField="ProductName"
                    SortExpression="ProductName" />

                <asp:BoundField
                    HeaderText="UnitPrice"
                    DataField="UnitPrice"
                    SortExpression="UnitPrice" />
            </Columns>
        </asp:GridView>
        <br />
        <h2>Un GridView con skin "fun"</h2>
        <asp:GridView 
            ID="GridView3" 
            DataSourceID="SqlDataSource1"
            SkinID="Fun"
            DataKeyNames="ProductId"
            AutoGenerateColumns="false"
            runat="server">
            <Columns>
                <asp:BoundField ReadOnly="true"
                    HeaderText="ProductId"
                    DataField="ProductId"
                    SortExpression="ProductId" />
                
                <asp:BoundField
                    HeaderText="ProductName"
                    DataField="ProductName"
                    SortExpression="ProductName" />

                <asp:BoundField
                    HeaderText="UnitPrice"
                    DataField="UnitPrice"
                    SortExpression="UnitPrice" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>

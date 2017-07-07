﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Proyecto44_DetailsView.WebForm1" %>

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
            DataSourceID="sqlCustomers"
            AutoGenerateColumns="false"
            AutoGenerateSelectButton="true"
            DataKeyNames="CustomerId" 
            runat="server">
            <Columns>
                <asp:CommandField ButtonType="Button" />
                <asp:BoundField DataField="CustomerId" HeaderText="Codigo" />
                <asp:BoundField DataField="ContactName" HeaderText="Responsable" />
                <asp:BoundField DataField="CompanyName" HeaderText="Compañia" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource 
            ID="sqlCustomers" 
            ConnectionString="<%$ ConnectionStrings:NorthWind %>" 
            SelectCommand="SELECT TOP 5 * FROM Customers"
            runat="server">
        </asp:SqlDataSource>

        <br /><br />

        <asp:DetailsView 
            ID="DetailsView1" 
            DataSourceID="sqlOrders"
            DataKeyNames="CustomerId, EmployeeId" 
            runat="server" 
            AllowPaging="true"
            AutoGenerateDeleteButton="true"
            AutoGenerateEditButton="true"
            AutoGenerateInsertButton="true"
            Height="50px" 
            Width="300px">
        </asp:DetailsView>
        <asp:SqlDataSource 
            ID="sqlOrders"
            ConnectionString="<%$ ConnectionStrings:NorthWind %>" 
            SelectCommand="SELECT OrderId, CustomerId, EmployeeId, Freight, ShipName, ShipAddress FROM Orders WHERE CustomerId = @CustomerId" 
            UpdateCommand="Update Orders SET Freight = @Freight, ShipName = @ShipName, ShipAddress = @ShipAddress WHERE OrderId = @OrderId"
            DeleteCommand="DELETE FROM [Orders Details] WHERE OrderId = @OrderId;
                           DELETE FROM Orders WHERE OrderId = @OrderId"
            InsertCommand="INSERT INTO Orders (CusomerId, EmployeeId, Freight, ShipName, ShipAddress) VALUES (@CusomerId, @EmployeeId, @Freight, @ShipName, @ShipAddress)"
            runat="server">
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Type="String" Name="CustomerId" PropertyName="SelectedValue" />
            </SelectParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="GridView1" Type="String" Name="CustomerId" PropertyName="SelectedValue" />
            </InsertParameters>
            <DeleteParameters>
                <asp:Parameter Type="Int32" Name="OrderId" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Type="Int32" Name="OrderId" />
                <asp:Parameter Type="Decimal" Name="Freight" />
                <asp:Parameter Type="String" Name="ShipName" />
                <asp:Parameter Type="String" Name="ShipAddress" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
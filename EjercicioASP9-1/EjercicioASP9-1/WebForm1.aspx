<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP9_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource 
            ID="sqlCustomers"
            DataSourceMode="DataReader"
            ConnectionString="<%$ ConnectionStrings:NorthWind %>"
            SelectCommand="SELECT CustomerID, CompanyName FROM Customers" 
            runat="server">
        </asp:SqlDataSource>
        <asp:Label ID="lblCustomers" runat="server" Text="Customers: "></asp:Label>
        <asp:DropDownList 
            ID="drpCustomers" 
            DataSourceID="sqlCustomers"
            DataTextField="CompanyName"
            DataValueField="CustomerID"
            AutoPostBack="true"
            runat="server">
        </asp:DropDownList>
        <br /><br />
        <asp:SqlDataSource 
            ID="sqlOrderEmployees"
            DataSourceMode="DataReader"
            ConnectionString="<%$ ConnectionStrings:NorthWind %>"
            SelectCommand="SELECT DISTINCT E.FirstName + ' ' + E.LastName AS NAME, E.EmployeeID FROM Orders AS O INNER JOIN Employees AS E ON E.EmployeeID = O.EmployeeID WHERE O.CustomerID = @idCustomer" 
            runat="server">
            <SelectParameters>
                <asp:ControlParameter 
                    Name="idCustomer" 
                    ControlID="drpCustomers" 
                    PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:Label ID="lblEmployees" runat="server" Text="Employees: "></asp:Label>
        <asp:DropDownList 
            ID="drpEmployees" 
            DataSourceID="sqlOrderEmployees"
            DataTextField="Name"
            DataValueField="EmployeeID"
            AutoPostBack="true"
            runat="server">
        </asp:DropDownList>
        <br /><br />
        <asp:SqlDataSource 
            ID="sqlEmployees"
            DataSourceMode="DataReader"
            ConnectionString="<%$ ConnectionStrings:NorthWind %>"
            SelectCommand="SELECT EmployeeID, FirstName, LastName, Title FROM Employees WHERE EmployeeId = @idEmployee" 
            runat="server">
            <SelectParameters>
                <asp:ControlParameter 
                    Name="idEmployee" 
                    ControlID="drpEmployees" 
                    PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:TextBox 
            ID="TextBox1" 
            Enabled="false"
            Text="<%# DataBinder.Eval(Container.DataItem, "ProductName")%>"
            AutoPostBack="true"
            runat="server">
        </asp:TextBox>
    </div>
    </form>
</body>
</html>

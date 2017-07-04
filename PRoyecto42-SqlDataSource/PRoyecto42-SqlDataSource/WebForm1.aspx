<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PRoyecto42_SqlDataSource.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--<asp:DropDownList ID="DropDownList1" runat="server">

        </asp:DropDownList>
        <asp:SqlDataSource 
            ID="SqlDataSource1" 
            DataSourceMode="DataReader"
            ConnectionString="<%$ ConnectionStrings:NorthWind %>"
            SelectCommand="SELECT FirstName, LastName, Title FROM Employees WHERE EmployeeID = @CodigoEmpleado"
            runat="server">
            <SelectParameters>
                <asp:ControlParameter 
                    Name="CodigoEmpleado" 
                    ControlID="DropDownList1" 
                    PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>--%>

        <%--<asp:SqlDataSource 
            ID="SqlDataSource1" 
            DataSourceMode="DataReader"
            ConnectionString="<%$ ConnectionStrings:NorthWind %>"
            SelectCommand="SELECT FirstName, LastName, Title FROM Employees"
            runat="server">
        </asp:SqlDataSource>--%>

        <asp:DropDownList ID="DropDownList1" runat="server">

        </asp:DropDownList>
        <br />
        Nombre:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:SqlDataSource 
            ID="SqlDataSource1" 
            DataSourceMode="DataSet"
            ConnectionString="<%$ ConnectionStrings:NorthWind %>"
            SelectCommand="SELECT FirstName, LastName, Title FROM Employees WHERE EmployeeID = @CodigoEmpleado"
            UpdateCommand="UPDATE Employees SET FirstName = @FirstNmae, LastName = @LastName, Title = @Title WHERE EmployeeId = @codigoEmpleado"
            runat="server">
            <SelectParameters>
                <asp:ControlParameter 
                    Name="CodigoEmpleado" 
                    ControlID="DropDownList1" 
                    PropertyName="SelectedValue" />
                <asp:ControlParameter 
                    Name="FirstName" 
                    ControlID="TextBox1" 
                    PropertyName="Text" />
            </SelectParameters>
        </asp:SqlDataSource>

        <asp:GridView 
            ID="GridView1" 
            DataSourceID="SqlDataSource1"
            runat="server">
        </asp:GridView>
    </div>
    </form>
</body>
</html>

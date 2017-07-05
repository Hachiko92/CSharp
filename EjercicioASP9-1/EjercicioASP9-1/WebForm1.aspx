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
            AppendDataBoundItems="true"
            OnSelectedIndexChanged="drpCustomers_SelectedIndexChanged"
            AutoPostBack="true"
            runat="server">
            <asp:ListItem Value="0"> - Selecciona un Cliente - </asp:ListItem>
        </asp:DropDownList>
        <br /><br />
        <!-- solo cuando vuelve a entrar de vuelta al server (cuando selecciona un cliente) -->
        <% if (IsPostBack)
            { 
        %>
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
                AppendDataBoundItems="true"
                AutoPostBack="true"
                runat="server" OnSelectedIndexChanged="drpEmployees_SelectedIndexChanged">
                <asp:ListItem Value="0"> - Selecciona un Cliente - </asp:ListItem>
            </asp:DropDownList>
            <br /><br />
            <%-- Hay que poner DataSet o hay problemas en el server para convertirlo en DataView --%>
            <asp:SqlDataSource 
                ID="sqlEmployees"
                DataSourceMode="DataSet"
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
            <asp:Label ID="lblId" runat="server" Text="Numero empleado: "></asp:Label>
            <asp:TextBox ID="txtId" Enabled="false" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblNombre" runat="server" Text="Nombre: "></asp:Label>
            <asp:TextBox ID="txtNombre" Enabled="false" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblApellido" runat="server" Text="Apellido: "></asp:Label>
            <asp:TextBox ID="txtApellido" Enabled="false" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCargo" runat="server" Text="Cargo en la empresa: "></asp:Label>
            <asp:TextBox ID="txtCargo" Enabled="false" runat="server"></asp:TextBox>


        <% } %>
        <!-- fin if -->
    </div>
    </form>
</body>
</html>

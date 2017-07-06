<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP10_1.WebForm1" Theme="App_Theme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView 
            ID="grdEmployees"
            DataSourceID="SqlEmployees"
            AutoGenerateColumns="false"
            DataKeyNames="EmployeeId"
            AutoGenerateEditButton="true"
            CssClass="grid"
            runat="server" 
            OnRowCommand="grdEmployees_RowCommand">
            <Columns>
                <asp:ButtonField
                    HeaderText="Seleccionar"
                    Text="Seleccionar"
                    ButtonType="Button"
                    CommandName="Select" />
                <asp:BoundField ReadOnly="true"
                    HeaderText="ID Empleado"
                    DataField="EmployeeId"
                    SortExpression="EmployeeId" />
                <asp:BoundField
                    HeaderText="Apellido"
                    DataField="LastName" />
                <asp:BoundField
                    HeaderText="Nombre"
                    DataField="FirstName" />
                <asp:BoundField
                    HeaderText="Cargo"
                    DataField="Title" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource 
            ID="sqlEmployees" 
            ConnectionString="<%$ ConnectionStrings:NorthWind %>" 
            SelectCommand="SELECT EmployeeId, FirstName, LastName, Title FROM Employees"
            UpdateCommand="UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, Title = @Title WHERE EmployeeId = @EmployeeId"
            OnUpdated="sqlEmployees_Updated"
            OnUpdating="sqlEmployees_Updating"
            runat="server">
            <UpdateParameters>
                <asp:Parameter Type="Int32" Name="EmployeeId" />
                <asp:Parameter Type="String" Name="FirstName" />
                <asp:Parameter Type="String" Name="LastName" />
                <asp:Parameter Type="String" Name="Title" />
            </UpdateParameters>
        </asp:SqlDataSource>

        <br /><br />
        <span id="result" runat="server"></span>
        <br /><br />

        <asp:Label ID="lblApellido" runat="server" Text="Apellido: "></asp:Label>
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblNombre" runat="server" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCargo" runat="server" Text="Cargo: "></asp:Label>
        <asp:TextBox ID="txtCargo" runat="server"></asp:TextBox>
        
    </div>
    </form>
</body>
</html>

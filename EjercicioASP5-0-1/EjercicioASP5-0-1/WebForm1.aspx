<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP5_0_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" method="post" action="WebForm2.aspx">
    <div>
        
        <fieldset>
            <legend>Add Customers:</legend>
            <div>
                <label for="CompanyName">Company Name: </label>
                <input type="text" id="CompanyName" name="CompanyName" />
            </div>
            <div>
                <label for="ContactName">Contact Name: </label>
                <input type="text" id="ContactName" name="ContactName" />
            </div>
            <div>
                <label for="Employees">Employees: </label>
                <input type="text" id="Employees" name="Employees" />
            </div>
            <div>
                <input type="submit" value="Enviar" />
            </div>
        </fieldset>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Selected="True" Text="Elemento1" Value="1"></asp:ListItem>
            <asp:ListItem Selected="True" Text="Elemento2" Value="2"></asp:ListItem>
            <asp:ListItem Selected="True" Text="Elemento3" Value="3"></asp:ListItem>
        </asp:DropDownList>

    </div>
    </form>
</body>
</html>

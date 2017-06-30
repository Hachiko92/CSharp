<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP5_0_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ejercicio 5.0.2</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="wrap">

        <header>
            <h1>My Store Manager</h1>
            <nav>
                <ul>
                    <li>Home</li>
                    <li>About Us</li>
                    <li>Contacts</li>
                </ul>
            </nav>
        </header>

        <form id="form1" runat="server">
        <div>
            <h2>Add product</h2>
            <br />
            <asp:Label ID="lblName" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCategory" runat="server" Text="Category: "></asp:Label>
            <!-- AutoPostBack="true" por cuando  -->
            <asp:DropDownList ID="ddlCategory" AutoPostBack="true" runat="server">
                <asp:ListItem Selected="True" Text="" Value="0"></asp:ListItem>
                <asp:ListItem Text="Casa" Value="1"></asp:ListItem>
                <asp:ListItem Text="Coche" Value="2"></asp:ListItem>
                <asp:ListItem Text="Alimentación" Value="3"></asp:ListItem>
                <asp:ListItem Text="Bellezza" Value="4"></asp:ListItem>
            </asp:DropDownList>
            <asp:HiddenField ID="HiddenField1" runat="server"></asp:HiddenField>
            <br />
            <asp:Label ID="lblSupplier" runat="server" Text="Supplier: "></asp:Label>
            <asp:DropDownList ID="ddlSupplier" AutoPostBack="true" runat="server">
                <asp:ListItem Selected="True" Text="" Value="0"></asp:ListItem>
                <asp:ListItem  Text="Pippo" Value="1"></asp:ListItem>
                <asp:ListItem Text="Fiat" Value="2"></asp:ListItem>
                <asp:ListItem Text="Conad" Value="3"></asp:ListItem>
                <asp:ListItem Text="Flomar" Value="4"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Unit price: "></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        </div>
        </form>

    </div>
</body>
</html>

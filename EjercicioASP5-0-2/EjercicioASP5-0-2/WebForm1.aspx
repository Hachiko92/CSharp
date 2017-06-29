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
            <asp:DropDownList ID="ddlCategory" runat="server">
                <asp:ListItem Selected="True" Text="Casa" Value="Casa"></asp:ListItem>
                <asp:ListItem Text="Coche" Value="Coche"></asp:ListItem>
                <asp:ListItem Text="Alimentación" Value="Alimentación"></asp:ListItem>
                <asp:ListItem Text="Bellezza" Value="Bellezza"></asp:ListItem>
                <asp:ListItem Text="Ropa" Value="Ropa"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblSupplier" runat="server" Text="Supplier: "></asp:Label>
            <asp:DropDownList ID="ddlSupplier" runat="server">
                <asp:ListItem Selected="True" Text="Pippo" Value="Pippo"></asp:ListItem>
                <asp:ListItem Text="Fiat" Value="Fiat"></asp:ListItem>
                <asp:ListItem Text="Conad" Value="Conad"></asp:ListItem>
                <asp:ListItem Text="Flomar" Value="Flomar"></asp:ListItem>
                <asp:ListItem Text="Zara" Value="Zara"></asp:ListItem>
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

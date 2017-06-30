<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="EjercicioASP5_0_2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Producto guardado</title>
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
            <asp:Panel ID="Panel1" runat="server">
                <h1>
                    Producto añadido:
                </h1>
                <asp:Label ID="lblName" runat="server" Text="Name: "></asp:Label>
                <br />
                <asp:Label ID="lblCategory" runat="server" Text="Category: "></asp:Label>
                <br />
                <asp:Label ID="lblSupplier" runat="server" Text="Supplier: "></asp:Label>
                <br />
                <asp:Label ID="lblPrice" runat="server" Text="Unite price: "></asp:Label>
            </asp:Panel>
        </div>
        </form>

    </div>
</body>
</html>

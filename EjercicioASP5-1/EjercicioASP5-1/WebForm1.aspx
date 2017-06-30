<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP5_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <h3>Alumno 1</h3>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Altura 1: "></asp:Label>
        <asp:TextBox ID="txtAltura1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Peso 1: "></asp:Label>
        <asp:TextBox ID="txtPeso1" runat="server"></asp:TextBox>

        <br /><br />

        <h3>Alumno 2</h3>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Altura 2: "></asp:Label>
        <asp:TextBox ID="txtAltura2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Peso 2: "></asp:Label>
        <asp:TextBox ID="txtPeso2" runat="server"></asp:TextBox>

        <br /><br />

        <h3>Alumno 3</h3>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Altura 3: "></asp:Label>
        <asp:TextBox ID="txtAltura3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Peso 3: "></asp:Label>
        <asp:TextBox ID="txtPeso3" runat="server"></asp:TextBox>

        <asp:Button ID="Button1" runat="server" PostBackUrl="~/WebForm2.aspx" Text="Button" />
        
    </div>
    </form>
</body>
</html>

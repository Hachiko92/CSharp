<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP4_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Label ID="lblNombre" AssociatedControlID="txtNombre"
             runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblApellido" AssociatedControlID="txtApellido" 
            runat="server" Text="Apellido"></asp:Label>
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkNet" runat="server" Text="Especialista .Net" />
        <asp:CheckBox ID="chkPhp" runat="server" Text="Especialista PHP" />
        <asp:CheckBox ID="chkJava" runat="server" Text="Especialista Java" />
        <br /><br />
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />

    </div>
    </form>
</body>
</html>

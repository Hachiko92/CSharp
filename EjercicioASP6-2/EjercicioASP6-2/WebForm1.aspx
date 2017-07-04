<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP6_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Apellido: "></asp:Label>
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        <br />
        <div class="calendares">
            <div>
                <asp:Label ID="Label3" runat="server" Text="Ida: "></asp:Label>
                <asp:Calendar ID="cIda" SkinID="ida" runat="server"></asp:Calendar>
            </div>
            
            <div>
                <asp:Label ID="Label4" runat="server" Text="Vuelta: "></asp:Label>
                <asp:Calendar ID="cVuelta" SkinID="vuelta" runat="server"></asp:Calendar> 
            </div>
              
        </div>
        <asp:Button ID="btnSend" SkinID="send" runat="server" Text="Send" />
        <asp:Button ID="btnClear" SkinID="clear" runat="server" Text="Clear" />

    </div>
    </form>
</body>
</html>

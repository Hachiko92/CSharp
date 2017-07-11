<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto47_Seguridad.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Página de Inicio</h1>
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
                <p>Por favor, introduce tus credenciales</p>
                <asp:Login ID="Login1" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333">

                    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                    <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
                    <TextBoxStyle Font-Size="0.8em" />
                    <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />

                </asp:Login>
            </AnonymousTemplate>
            <LoggedInTemplate>
                <h2>Bienvenido <asp:LoginName ID="LoginName1" runat="server" /></h2>
                <p>
                    <asp:LoginStatus ID="LoginStatus1" runat="server" />
                </p>
            </LoggedInTemplate>
        </asp:LoginView>
    </div>
    </form>
</body>
</html>

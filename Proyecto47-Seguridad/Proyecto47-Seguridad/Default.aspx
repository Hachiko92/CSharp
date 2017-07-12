<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto47_Seguridad.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Página Principal</h1>
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
                <h2>Por favor, inserte sus credenciales</h2>
                <asp:Login ID="Login1" 
                    CreateUserText="Nuevo Usuario" CreateUserUrl="~/RegistrarUsuario.aspx"
                    PasswordRecoveryText="¿Te has olvidado la contraseña?"
                    PasswordRecoveryUrl="~/PwRecovery.aspx"
                    runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333">
                    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                    <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
                    <TextBoxStyle Font-Size="0.8em" />
                    <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                    
                </asp:Login>
            </AnonymousTemplate>
            <LoggedInTemplate>
                <p>
                    Benvenido 
                    <asp:LoginName ID="LoginName1" runat="server" />
                    <asp:LoginStatus ID="LoginStatus1" runat="server" />
                    <asp:LinkButton ID="LinkCambioPw" PostBackUrl="~/CambioPw.aspx" runat="server" OnClick="LinkCambioPw_Click">Cambiar Contraseña</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton1" PostBackUrl="~/ZonaDeAdministracion/WebForm1.aspx" 
                        runat="server" Visible="false"></asp:LinkButton>
                    <br />

                </p>
            </LoggedInTemplate>
        </asp:LoginView>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PwRecovery.aspx.cs" Inherits="Proyecto47_Seguridad.PwRecovery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Recuperación de contraseñas</h1>
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em">
            <SubmitButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <SuccessTextStyle Font-Bold="True" ForeColor="#507CD1" />
            <TextBoxStyle Font-Size="0.8em" />
            <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
            <MailDefinition BodyFileName="~/Email.txt" From="CorreoAplicacion@email.com"></MailDefinition>
        </asp:PasswordRecovery>
    </div>
    </form>
</body>
</html>

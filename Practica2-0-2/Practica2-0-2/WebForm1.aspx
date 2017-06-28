<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practica2_0_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <article>
            <h2>
                Contacts:
            </h2>
            <p runat="server" id="pContact">

            </p>
        </article>

        <asp:Button ID="Button1" runat="server" Text="Nombres por 'A'" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Alguien" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Alabama" OnClick="Button3_Click" />
        <br /><br />
        <span runat="server" id="result"></span>
    </div>
    </form>
</body>
</html>

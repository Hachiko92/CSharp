<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario1.aspx.cs" Inherits="Proyecto38_Themes.Formulario1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="txtCaja" runat="server"></asp:TextBox>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Text="Opcion1" Value="1"></asp:ListItem>
            <asp:ListItem Text="Opcion2" Value="2"></asp:ListItem>
            <asp:ListItem Text="Opcion3" Value="3"></asp:ListItem>
        </asp:RadioButtonList>
        <asp:TextBox ID="txtOtraCaja" SkinID="cajaBlue" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtOtraMas" EnableTheming="false" runat="server"></asp:TextBox>
        <br />
        Caja HTML:
        <input id="txtHTML" type="text" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Send" />

    </div>
    </form>
</body>
</html>

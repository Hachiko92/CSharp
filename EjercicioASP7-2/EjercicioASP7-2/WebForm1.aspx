<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP7_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Clientes por País: </h2>
        <asp:Label ID="Label1" runat="server" Text="Pais: "></asp:Label>
        <asp:DropDownList ID="drpPaises" AutoPostBack="true" runat="server" OnSelectedIndexChanged="drpPaises_SelectedIndexChanged">
            <%-- Se llena cuando la pagina se carga --%>
        </asp:DropDownList>
        <%--<asp:TextBox ID="txtPais" runat="server"></asp:TextBox>--%>
        <%--<asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />--%>
        <br /><br />
        <asp:Label ID="Label2" runat="server" Text="Clientes: "></asp:Label>
        <asp:TextBox ID="txtClientes" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>

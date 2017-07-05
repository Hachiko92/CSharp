<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP9_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ejercicio 9-2</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Elejir la(s) temporada(s):</h2>
        <asp:CheckBoxList ID="cbxTemporada" AutoPostBack="true" runat="server" OnSelectedIndexChanged="cbxTemporada_SelectedIndexChanged">
            <asp:ListItem Value="Alta">Temporada Alta</asp:ListItem>
            <asp:ListItem Value="Media">Temporada Media</asp:ListItem>
            <asp:ListItem Value="Baja">Temporada Baja</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <div id="result" runat="server">

        </div>
    </div>
    </form>
</body>
</html>

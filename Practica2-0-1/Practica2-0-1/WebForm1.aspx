<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practica2_0_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3>Resultado:</h3>
        <p runat="server" id="result"></p>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Menores de 5" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Suma" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Menores de 5 sin repetir" OnClick="Button3_Click" />
    
    </div>
    </form>
</body>
</html>

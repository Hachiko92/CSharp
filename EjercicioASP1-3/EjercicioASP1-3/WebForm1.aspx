<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP1_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Primer numero"></asp:Label>
        <br />
        <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="Label2" runat="server" Text="Segundo numero"></asp:Label>
        <br />
        <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btnSumar" runat="server" Text="Sumar" OnClick="btnSumar_Click" />
        <asp:Button ID="btnRestar" runat="server" Text="Restar" OnClick="btnRestar_Click" />
    
    </div>
    </form>
</body>
</html>

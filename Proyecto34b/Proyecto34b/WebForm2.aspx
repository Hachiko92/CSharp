<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Proyecto34b.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Número par:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CustomValidator 
            ID="CustomValidator1" 
            runat="server" 
            ControlToValidate="TextBox1"
            OnServerValidate="CustomValidator1_ServerValidate"
            ErrorMessage="Debe ser un número par">
        </asp:CustomValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
    </form>
</body>
</html>

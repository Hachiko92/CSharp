<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Proyecto34b.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Numero (1-10):
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RangeValidator 
            ID="RangeValidator1" 
            runat="server" 
            ControlToValidate="TextBox1"
            MinimumValue="1"
            MaximumValue="10"
            Text="*"
            Display="Static"
            type="Integer"
            ErrorMessage="Debes introducir entre 1 y 10">
        </asp:RangeValidator>
        <asp:ValidationSummary 
            ID="ValidationSummary1" 
            HeaderText="LISTA DE ERRORES"
            DisplayMode="BulletList"
            ShowSummary="true"
            ShowMessageBox="false"
            runat="server" />
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP4_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong>Credit Card Information</strong>
        <br />
        <asp:Panel ID="Panel1" runat="server" BackColor="WhiteSmoke">
            <asp:Label ID="Label1" runat="server" Text="Card type" ></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Text="Master Card"></asp:ListItem>
                <asp:ListItem Text="Visa"></asp:ListItem>
            </asp:RadioButtonList>

        </asp:Panel>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Card Number:"></asp:Label>
        <asp:TextBox ID="txtCardNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnValidate" runat="server" Text="Validate" />
        <asp:RegularExpressionValidator 
            ID="RegularExpressionValidator1" 
            runat="server" 
            ControlToValidate="txtCardNumber"
            ValidationExpression="^((67\d{2})|(4\d{3})|(5[1-5]\d{2})|(6011))(-?\s?\d{4}){3}|(3[4,7])\ d{2}-?\s?\d{6}-?\s?\d{5}$"
            Text="*"
            ErrorMessage="Formato tarjeta invalida">
        </asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator1" 
            runat="server" 
            ControlToValidate="RadioButtonList1"
            Text="*"
            Display="None"
            ErrorMessage="Debes seleccionar un tipo de tarjeta">
        </asp:RequiredFieldValidator>
        <asp:ValidationSummary 
            ID="ValidationSummary1" 
            ShowMessageBox="true"
            DisplayMode="BulletList"
            BackColor="Yellow"
            HeaderText="Errores producidos"
            runat="server" />
    </div>
    </form>
</body>
</html>

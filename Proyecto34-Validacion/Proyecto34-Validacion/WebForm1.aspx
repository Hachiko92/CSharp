<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Proyecto34_Validacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Nombre:
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator1" 
            runat="server" 
            ControlToValidate="txtNombre"
            ErrorMessage="Este campo es obligatorio">
        </asp:RequiredFieldValidator>
        <br />
        Edad:
        <asp:TextBox ID="ageTextBox" runat="server"></asp:TextBox>
        <asp:CompareValidator 
            ID="ageValidator" 
            runat="server" 
            ControlToValidate="ageTextBox"
            ValueToCompare="18" 
            Operator="GreaterThanEqual" 
            Type="Integer" 
            ErrorMessage="Debes ser mayor de 18 piltrafillas">
        </asp:CompareValidator>
        <br />
        Dirección email:
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator 
            ID="RegularExpressionValidator1" 
            runat="server" 
            ControlToValidate="txtEmail"
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
            ErrorMessage="No es una dirección valida">
        </asp:RegularExpressionValidator>
        <br />
        Altura:
        <asp:TextBox ID="txtAltura" runat="server">
        </asp:TextBox><asp:RangeValidator 
            ID="RangeValidator1" 
            runat="server" 
            ControlToValidate="txtAltura"
            MinimumValue="165"
            MaximumValue="198"
            Type="Integer"
            ErrorMessage="No tienes la altura necesaria">
        </asp:RangeValidator>
        <br />
        <br />

    </div>
    </form>
</body>
</html>

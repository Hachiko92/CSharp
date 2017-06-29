<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP4_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ejercicio 4.3</title>
    <link type="text/css" href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="wrap">

        <h1>
            Formulario
        </h1>
        <br />
        <asp:Label ID="lblNombre" runat="server" Text="Nombre">
        </asp:Label><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator1" 
            runat="server" 
            Text="*"
            ControlToValidate="txtNombre"
            ErrorMessage="Nombre requirido">
        </asp:RequiredFieldValidator>

        <br />

        <asp:Label ID="lblEdad" runat="server" Text="Edad"></asp:Label>
        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator2" 
            runat="server" 
            Text="*"
            ControlToValidate="txtEdad"
            ErrorMessage="Edad requirida">
        </asp:RequiredFieldValidator>
        <asp:RangeValidator 
            ID="RangeValidator1" 
            runat="server" 
            ControlToValidate="txtEdad"
            Text="*"
            MinimumValue="18"
            MaximumValue="50"
            Type="Integer"
            Display="Static"
            ErrorMessage="La edad debe ser entre 18 y 50">

        </asp:RangeValidator>

        <br />
        <asp:Label ID="lblPw" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPw" TextMode="Password" runat="server"></asp:TextBox>
        <%--<asp:RegularExpressionValidator 
            ID="RegularExpressionValidator1" 
            runat="server" 
            ControlToValidate="txtPw"
            ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$"
            Text="*"
            ErrorMessage="La constraseña debe contener por lo menos 8 caracteres, 1 mayuscula, 1 minuscula y 1 numero">
        </asp:RegularExpressionValidator>--%>
        <asp:CustomValidator 
            ID="CustomValidator1" 
            runat="server" 
            ControlToValidate="txtPw"
            OnServerValidate="CustomValidator1_ServerValidate"
            Text="*"
            ErrorMessage="La contraseña debe contener por lo menos 4 caracteres">
        </asp:CustomValidator>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator3" 
            runat="server" 
            ControlToValidate="txtPw"
            Text="*"
            ErrorMessage="Contraseña requerida">

        </asp:RequiredFieldValidator>

        <br />
        <asp:Label ID="lblPw2" runat="server" Text="Confirmar password"></asp:Label>
        <asp:TextBox ID="txtPw2" TextMode="Password" runat="server"></asp:TextBox>
        <asp:CompareValidator 
            ID="CompareValidator1" 
            ControlToCompare="txtPw"
            ControlToValidate="txtPw2"
            runat="server" 
            Text="*"
            ErrorMessage="La dos contraseñas no son iguales">
        </asp:CompareValidator>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator4" 
            runat="server" 
            ControlToValidate="txtPw2"
            Text="*"
            ErrorMessage="Confirme la contraseña">
        </asp:RequiredFieldValidator>

        <br /><br />
        <asp:Button ID="btnValidar" runat="server" Text="Validar" />

        <asp:ValidationSummary 
            ID="ValidationSummary1" 
            DisplayMode="BulletList"
            ShowSummary="true"
            ShowMessageBox="false"
            HeaderText="Lista de errores"
            runat="server" />

    </div>
    </form>
</body>
</html>

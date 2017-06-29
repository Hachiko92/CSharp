<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Proyecto34b.WebForm1" %>

<!DOCTYPE html>

<script type="text/javascript">
    /* La funcion que gestiona la validación necesita por lo menos construir
       los dos parametros.
       Se executerá antes el validator cliente. */
    function ValidarLongitud(oSrc, args) {
        args.IsValid = (args.Value.length >= 4);
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CustomValidator 
            ID="CustomValidator1" 
            OnServerValidate="TextValidate"
            ControlToValidate="TextBox1"
            runat="server" 
            ErrorMessage="Debes introducir almenos 8 caracteres">
        </asp:CustomValidator>
        <asp:CustomValidator 
            ID="CustomValidator2" 
            ControlToValidate="TextBox1"
            ClientValidationFunction="ValidarLongitud"
            runat="server" 
            ErrorMessage="Validación desde cliente">
        </asp:CustomValidator>
        <br /><br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
    </form>
</body>
</html>

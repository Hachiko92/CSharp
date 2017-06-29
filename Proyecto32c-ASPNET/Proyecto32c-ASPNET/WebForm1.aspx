<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Proyecto32c_ASPNET.WebForm1" %>

<!DOCTYPE html>
<script type="text/javascript">
    function saludar() {
        alert("Hola");
    }
</script>

<script runat="server">
    private void ponerMayuscula(object sender, EventArgs e)
    {
        string dato = Caja.Text;
        result.InnerHtml = dato.ToUpper();
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="Caja" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="saludar()" OnClick="ponerMayuscula" />
        <br />
        <h3>Resultado:</h3>
        <span runat="server" id="result"></span>
    </div>
    </form>
</body>
</html>

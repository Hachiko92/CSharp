<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Proyecto32c_ASPNET.WebForm2" %>

<!DOCTYPE html>

<script runat="server">
    private void ponerMayuscula(object sender, EventArgs e)
    {
        string dato = caja.Value;
        salida.InnerHtml = dato;
    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Poner en mayusculas
        </h1>
        <input type="text" id="caja" runat="server" />
        <input type="submit" id="btnAceptar" value="Proceder" runat="server" onserverclick="ponerMayuscula" />

        <h3>
            Resultado:
        </h3>
        <span runat="server" id="salida"></span>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Proyecto32_ASPNET.WebForm1" %>

<!DOCTYPE html>

<!-- lo script se puede poner en cualquier parte del codigo, normalmente se pone debajo de todo -->
<script runat="server">
    /* private porque estamos en el mismo entorno */
    private void makeUpper(object sender, EventArgs e)
    {
        string buf = TheString.Value;
        theResult.InnerHtml = buf.ToUpper();
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>UpperCase</title>
</head>
<body>
    <h1>Make it Upper Case</h1>
    <form id="form1" runat="server">
    <div>
        <input runat="server" id="TheString" type="text" />
        <input runat="server" id="button1" type="submit" onserverclick="makeUpper" value="Proceed" />

        <h3>
            Results:
        </h3>
        <span runat="server" id="theResult"></span>
    </div>
    </form>
</body>
</html>

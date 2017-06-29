<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP5_0.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <!-- action me conecta al WebForm2, hace si que le envie los datos -->
    <form id="form1" runat="server" action="WebForm2.aspx" method="post">
    <div>
        <!-- Cuando se utilizan etiquetas client hay que utilizar el name no el ID -->
        Nombre: <input name="txtNombre" type="text" />
        <br />
        Apellido: <input name="txtApellido" type="text" />
        <br />
        <br />
        <input id="Submit1" type="submit" value="submit" />
    </div>
    </form>
</body>
</html>

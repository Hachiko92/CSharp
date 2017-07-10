<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2><strong>Profesor: </strong></h2>
        <asp:Label ID="lblProfesor" runat="server" Text=""><strong>Profesor: </strong></asp:Label>
        <br />
        <h2><strong>DNI: </strong></h2>
        <asp:Label ID="lblDNI" runat="server" Text=""></asp:Label>
        <br />
        <h2><strong>Fecha de Inicio: </strong></h2>
        <asp:Label ID="lblFinicio" runat="server" Text=""></asp:Label>
        <br />
        <h2><strong>Fecha de Fin: </strong></h2>
        <asp:Label ID="lblFfin" runat="server" Text=""></asp:Label>
        <br /><br />

        <asp:DataList ID="DataList1" runat="server">
            
        </asp:DataList>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP5_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        
        <asp:Label ID="Label1" runat="server" Text="Asignatura 1: "></asp:Label>
        <asp:TextBox ID="txtAsignatura1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Asignatura 2: "></asp:Label>
        <asp:TextBox ID="txtAsignatura2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Asignatura 3: "></asp:Label>
        <asp:TextBox ID="txtAsignatura3" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/WebForm2.aspx" Text="Button" />
        
    </div>
    </form>
</body>
</html>

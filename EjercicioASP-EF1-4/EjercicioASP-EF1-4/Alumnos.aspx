<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alumnos.aspx.cs" Inherits="EjercicioASP_EF1_4.Alumnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Alumnos: 
        <asp:DropDownList 
            ID="ddlAlumnos" 
            AutoPostBack="true"
            AppendDataBoundItems="true"
            runat="server">
        </asp:DropDownList>


    </div>
    </form>
</body>
</html>

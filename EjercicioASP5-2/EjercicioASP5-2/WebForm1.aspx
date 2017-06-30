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
        <asp:RangeValidator 
            ID="RangeValidator1" 
            runat="server" 
            ControlToValidate="txtAsignatura1"
            MinimumValue="0"
            MaximumValue="100"
            type="Double"
            Text="*"
            ErrorMessage="Insertar un valor entre 0 y 100">
        </asp:RangeValidator>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator1" 
            runat="server" 
            ControlToValidate="txtAsignatura1"
            Text="*"
            ErrorMessage="Campo requerido">
        </asp:RequiredFieldValidator>

        <br />

        <asp:Label ID="Label2" runat="server" Text="Asignatura 2: "></asp:Label>
        <asp:TextBox ID="txtAsignatura2" runat="server"></asp:TextBox>
        <asp:RangeValidator 
            ID="RangeValidator2" 
            runat="server" 
            ControlToValidate="txtAsignatura2"
            MinimumValue="0"
            MaximumValue="100"
            type="Double"
            Text="*"
            ErrorMessage="Insertar un valor entre 0 y 100">
        </asp:RangeValidator>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator2" 
            runat="server" 
            ControlToValidate="txtAsignatura2"
            Text="*"
            ErrorMessage="Campo requerido">
        </asp:RequiredFieldValidator>

        <br />

        <asp:Label ID="Label3" runat="server" Text="Asignatura 3: "></asp:Label>
        <asp:TextBox ID="txtAsignatura3" runat="server"></asp:TextBox>
        <asp:RangeValidator 
            ID="RangeValidator3" 
            runat="server" 
            ControlToValidate="txtAsignatura3"
            MinimumValue="0"
            MaximumValue="100"
            type="Double"
            Text="*"
            ErrorMessage="Insertar un valor entre 0 y 100">
        </asp:RangeValidator>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator3" 
            runat="server" 
            ControlToValidate="txtAsignatura3"
            Text="*"
            ErrorMessage="Campo requerido">
        </asp:RequiredFieldValidator>

        <br /><br />

        <asp:Button ID="Button1" runat="server" PostBackUrl="~/WebForm2.aspx" Text="Button" />
        
        <br /><br />

        <asp:ValidationSummary 
            ID="ValidationSummary1" 
            ShowMessageBox="false"
            HeaderText="Errores"
            runat="server" />
        
    </div>
    </form>
</body>
</html>

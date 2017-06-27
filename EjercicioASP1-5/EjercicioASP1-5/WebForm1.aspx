<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioASP1_5.WebForm1" %>

<!DOCTYPE html>

<script runat="server">

//private void calcularMedia(object sender, EventArgs e)
//{
//    try
//    {
//        float media = (Convert.ToSingle(txtNum1.Text) + Convert.ToSingle(txtNum2.Text) + Convert.ToSingle(txtNum3.Text)) / 3;
//        resultado.InnerHtml = "El resultado de la media es: " + media.ToString();
//    }
//    catch (Exception ex)
//    {
//        resultado.InnerHtml = ex.Message;
//    }
//}

    private void calcularMedia(object sender, EventArgs e)
    {
        try
        {
            float suma = (Convert.ToSingle(txtNum1.Value) + Convert.ToSingle(txtNum2.Value) + Convert.ToSingle(txtNum3.Value));
            float media = suma / 3;
            resultado.InnerHtml = "El resultado de la media es: " + media.ToString();
        }
        catch (Exception ex)
        {
            resultado.InnerHtml = ex.Message;
        }
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <%--<asp:Label ID="Label1" runat="server" Text="Primer número"></asp:Label>
        <br />
        <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="Label2" runat="server" Text="Segundo número"></asp:Label>
        <br />
        <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="Label3" runat="server" Text="Tercer número"></asp:Label>
        <br />
        <asp:TextBox ID="txtNum3" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btnMedia" runat="server" Text="Media" OnClick="calcularMedia" />
        <br />
        <h3>Resultado:</h3>
        <span runat="server" id="resultado"></span>--%>

        Primer número: <input runat="server" id="txtNum1" type="text" />
        <br />
        Segundo número: <input runat="server" id="txtNum2" type="text" />
        <br />
        Tercer número: <input runat="server" id="txtNum3" type="text" />
        <br />
        <input id="Button1" type="button" value="Media" runat="server" onserverclick="calcularMedia" />
        <br />
        <h3>Resultado:</h3>
        <span runat="server" id="resultado"></span>

    </div>
    </form>
</body>
</html>

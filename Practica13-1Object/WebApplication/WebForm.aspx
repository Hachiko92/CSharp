<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebApplication.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView 
            ID="GridViewProfesores" 

            runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnRowCommand="GridViewProfesores_RowCommand">
            <Columns>
                <asp:ButtonField
                    ButtonType="Button" 
                    HeaderText="Reservar Equipo" 
                    CommandName="Reservar"
                    Text="Reservar" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>

        <% if (IsPostBack){ %>

            <h2>Realizar Reserva de Equipos</h2>
            <br />
            <asp:Label ID="lblDNI" runat="server" Text="DNI: "></asp:Label>
            <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblProfesor" runat="server" Text="Profesor: "></asp:Label>
            <asp:TextBox ID="txtProfesor" runat="server"></asp:TextBox>
            <br /><br />
            <asp:GridView ID="GridViewReserva" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
                <Columns>
                    <asp:CheckBoxField  />
                </Columns>
        </asp:GridView>

        <% } %>
    </div>
    </form>
</body>
</html>

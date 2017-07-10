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
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox ID="chk" runat="server" Style="position: static" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Label ID="lblInicio" runat="server" Text="Inicio"></asp:Label>
        <asp:TextBox ID="txtInicio" runat="server"></asp:TextBox>
        <asp:Button ID="btnInicio" runat="server" Text="Button" OnClick="btnInicio_Click" />
            
       
            <asp:Label ID="Label1" runat="server" Text="Fin"></asp:Label>
        <asp:TextBox ID="txtFin" runat="server"></asp:TextBox>
        <asp:Button ID="btnFin" runat="server" Text="Button" OnClick="btnFin_Click" />
        <asp:Calendar ID="calendar" Visible="false" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" OnSelectionChanged="calendar_SelectionChanged">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                <NextPrevStyle VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#808080" />
                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" />
                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                <WeekendDayStyle BackColor="#FFFFCC" />
            </asp:Calendar>
            <br />
            <asp:Button ID="btnReservar" runat="server" Text="Button" OnClick="btnReservar_Click" />
            

        <% } %>
    </div>
    </form>
</body>
</html>

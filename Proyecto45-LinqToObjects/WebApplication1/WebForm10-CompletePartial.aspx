<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm10-CompletePartial.aspx.cs" Inherits="WebApplication1.WebForm10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Complete Restults</h2>
        <asp:GridView ID="GridViewComplete" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>

        <br />

        <h2>Partial Results</h2>
        
        Start:
        <asp:DropDownList 
            ID="ddlStart" 
            AutoPostBack="true" 
            CausesValidation="true"
            runat="server" OnSelectedIndexChanged="ddlStart_SelectedIndexChanged">
        </asp:DropDownList>
        
        End:
        <asp:DropDownList 
            ID="ddlEnd" 
            AutoPostBack="true" 
            CausesValidation="true"
            runat="server" OnSelectedIndexChanged="ddlEnd_SelectedIndexChanged">
        </asp:DropDownList>

        <br />

        <asp:CompareValidator 
            ID="CompareValidator1"
            ControlToValidate="ddlStart"
            ControlToCompare="ddlEnd"
            Operator="LessThanEqual"
            Type="Integer" 
            runat="server" 
            ErrorMessage="El segundo índice debe ser mayor o igual que el primero">
        </asp:CompareValidator>

        <br /><br />

        <asp:GridView ID="GridViewPartial" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>

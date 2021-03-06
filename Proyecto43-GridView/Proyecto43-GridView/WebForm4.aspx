﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Proyecto43_GridView.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView 
            ID="GridView1" 
            DataSourceID="SqlDataSource1"
            DataKeyNames="CustomerId"
            AutoGenerateColumns="false"
            AutoGenerateDeleteButton="true"
            AllowPaging="true"
            ShowFooter="true"
            runat="server">
            <Columns>

                <%-- CustomerId --%>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="CustomerIdLabel" runat="server">
                            <%# Eval("CustomerID") %>
                        </asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="CustomerIdTxt" runat="server"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateField>
                
                <%-- CompanyName --%>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="CompanyNameLaber" runat="server">
                            <%# Eval("CompanyName") %>
                        </asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="CompanyNameTxt" runat="server"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateField>

                <%-- ContactTitle --%>
                <asp:TemplateField>

                    <ItemTemplate>
                        <asp:DropDownList 
                            ID="drpContactTitle" 
                            DataSourceID="SqlDataSource3"
                            DataTextField="ContactTitle"
                            DataValueField="ContactTitle"
                            SelectedValue='<%# Bind("ContactTitle") %>'
                            runat="server">
                        </asp:DropDownList>
                        <asp:SqlDataSource 
                            ID="SqlDataSource3" 
                            ConnectionString="<%$ ConnectionStrings:NorthWind %>" 
                            SelectCommand="SELECT DISTINCT ContactTitle FROM Customers"
                            EnableCaching="true"
                            runat="server">
                        </asp:SqlDataSource>
                    </ItemTemplate>

                    <FooterTemplate>
                        <asp:DropDownList 
                            ID="drpContactTitle" 
                            DataSourceID="SqlDataSource2"
                            DataTextField="ContactTitle"
                            DataValueField="ContactTitle"
                            AppendDataBoundItems="true"
                            runat="server">
                            <asp:ListItem Text=" - Seleccione Cargo - " Value="0"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:SqlDataSource 
                            ID="SqlDataSource2" 
                            ConnectionString="<%$ ConnectionStrings:NorthWind %>" 
                            SelectCommand="SELECT DISTINCT ContactTitle FROM Customers"
                            runat="server">
                        </asp:SqlDataSource>
                        <asp:Button 
                            ID="btnAdd" 
                            runat="server" 
                            Text="Add"
                            OnClick="btnAdd_Click" />
                    </FooterTemplate>

                </asp:TemplateField>

            </Columns>
        </asp:GridView>
        <asp:SqlDataSource 
            ID="SqlDataSource1"
            ConnectionString="<%$ ConnectionStrings:NorthWind %>" 
            SelectCommand="SELECT CustomerId, CompanyName, ContactTitle FROM Customers"
            DeleteCommand="DELETE FROM Customers WHERE CustomerId = @CustomerId"
            InsertCommand="INSERT INTO Customers (CustomerID, CompanyName, ContactTitle) VALUES (@CustomerID, @CompanyName, @ContactTitle)"
            runat="server">
            <DeleteParameters>
                <asp:Parameter Type="String" Name="CustomerId" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Type="String" Name="CustomerID" />
                <asp:Parameter Type="String" Name="CompanyName" />
                <asp:Parameter Type="String" Name="ContactTitle" />
            </InsertParameters>
        </asp:SqlDataSource>

        
    </div>
    </form>
</body>
</html>

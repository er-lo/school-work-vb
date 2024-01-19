<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Update.aspx.vb" Inherits="Lopez_SalesStaff.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Page - SalesStaff by Erick Lopez</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 348px;
            text-align: center;
        }
        .auto-style4 {
            width: 348px;
        }
        .auto-style5 {
            margin-right: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">
                    <h1>
                        <asp:Label ID="lblSalesStaffInformation" runat="server" Text="Sales Staff Information" Font-Names="Microsoft Sans Serif"></asp:Label>
                    </h1>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">
                    <asp:DetailsView ID="dtvSalesStaffInfo" runat="server" AllowPaging="True" AutoGenerateRows="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" CssClass="auto-style5" DataKeyNames="ID" DataSourceID="SqlDataSource1" GridLines="None" Height="50px" Width="344px" Font-Names="Microsoft Sans Serif">
                        <EditRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                        <Fields>
                            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID">
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Last_Name" HeaderText="Last Name" SortExpression="Last_Name">
                            <ItemStyle HorizontalAlign="Left" />
                            </asp:BoundField>
                            <asp:BoundField DataField="First_Name" HeaderText="First Name" SortExpression="First_Name">
                            <ItemStyle HorizontalAlign="Left" />
                            </asp:BoundField>
                            <asp:CheckBoxField DataField="Full_Time" HeaderText="Full Time" SortExpression="Full_Time">
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:CheckBoxField>
                            <asp:BoundField DataField="Hire_Date" DataFormatString="{0:MM/dd/yyyy}" HeaderText="Hire Date" SortExpression="Hire_Date">
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Salary" DataFormatString="{0:c}" HeaderText="Salary" SortExpression="Salary">
                            <ItemStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:CommandField ShowEditButton="True">
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:CommandField>
                        </Fields>
                        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                    </asp:DetailsView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnLogout" runat="server" BorderColor="Black" BorderStyle="Solid" Height="30px" Text="Logout" Width="80px" Font-Names="Microsoft Sans Serif" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CompanyConnectionString %>" DeleteCommand="DELETE FROM [SalesStaff] WHERE [ID] = @ID" InsertCommand="INSERT INTO [SalesStaff] ([ID], [Last_Name], [First_Name], [Full_Time], [Hire_Date], [Salary]) VALUES (@ID, @Last_Name, @First_Name, @Full_Time, @Hire_Date, @Salary)" SelectCommand="SELECT * FROM [SalesStaff]" UpdateCommand="UPDATE [SalesStaff] SET [Last_Name] = @Last_Name, [First_Name] = @First_Name, [Full_Time] = @Full_Time, [Hire_Date] = @Hire_Date, [Salary] = @Salary WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ID" Type="Int32" />
                <asp:Parameter Name="Last_Name" Type="String" />
                <asp:Parameter Name="First_Name" Type="String" />
                <asp:Parameter Name="Full_Time" Type="Boolean" />
                <asp:Parameter Name="Hire_Date" Type="DateTime" />
                <asp:Parameter Name="Salary" Type="Decimal" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Last_Name" Type="String" />
                <asp:Parameter Name="First_Name" Type="String" />
                <asp:Parameter Name="Full_Time" Type="Boolean" />
                <asp:Parameter Name="Hire_Date" Type="DateTime" />
                <asp:Parameter Name="Salary" Type="Decimal" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>

<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Lopez_SalesStaff._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page - SalesStaff by Erick Lopez</title>
    <style type="text/css">
        #form1 {
            text-align: center;
        }
        .auto-style1 {
            width: 1061px;
        }
        .auto-style2 {
            height: 25px;
        }
        .auto-style9 {
            width: 302px;
        }
        .auto-style10 {
            height: 25px;
            width: 302px;
        }
        .auto-style13 {
            width: 205px;
        }
        .auto-style14 {
            width: 315px;
        }
        .auto-style15 {
            height: 25px;
            width: 315px;
        }
        .auto-style16 {
            width: 113px;
        }
        .auto-style17 {
            width: 205px;
            background-color: #FFFFFF;
        }
        .auto-style18 {
            width: 113px;
            background-color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table align="center" cellpadding="2" class="auto-style1">
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td colspan="2">
                    <h1>
                        <asp:Label ID="lblLogin" runat="server" Text="Login Page" Font-Names="Microsoft Sans Serif"></asp:Label>
                    </h1>
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style2" colspan="2"></td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14" style="text-align: right">&nbsp;</td>
                <td class="auto-style18" style="text-align: right">
                    <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address:" Font-Names="Microsoft Sans Serif"></asp:Label>
                </td>
                <td class="auto-style17" style="text-align: left">
                    <asp:TextBox ID="txtEmail" runat="server" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEmailFieldNotEmpty" runat="server" ControlToValidate="txtEmail" ErrorMessage="An Email Address Must Be Entered." ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revValidEmailAddress" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter A Valid Email Address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
                <td class="auto-style9" style="text-align: left">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14" style="text-align: right">&nbsp;</td>
                <td class="auto-style18" style="text-align: right">
                    <asp:Label ID="lblZipCode" runat="server" Text="Zip Code:" Font-Names="Microsoft Sans Serif"></asp:Label>
                </td>
                <td class="auto-style17" style="text-align: left">
                    <asp:TextBox ID="txtZipCode" runat="server" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvZipCodeFieldNotEmpty" runat="server" ControlToValidate="txtZipCode" ErrorMessage="A Zip Code Must Be Entered." ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvValidZipCode" runat="server" ControlToValidate="txtZipCode" ErrorMessage="Zip Code Must Be Between 10000 and 99999." ForeColor="Red" MaximumValue="99999" MinimumValue="10000" Type="Double">*</asp:RangeValidator>
                </td>
                <td class="auto-style9" style="text-align: left">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14" style="text-align: right">&nbsp;</td>
                <td class="auto-style16" style="text-align: right">&nbsp;</td>
                <td class="auto-style13" style="text-align: left">&nbsp;</td>
                <td class="auto-style9" style="text-align: left">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style2" colspan="2">
                    <asp:Button ID="btnLogin" runat="server" BorderColor="Black" BorderStyle="Solid" Height="30px" Text="Login" ToolTip="Button to login." Width="80px" />
                </td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style2" colspan="2">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td colspan="2">
                    <asp:ValidationSummary ID="vlsErrorMessages" runat="server" ForeColor="Red" Height="44px" Font-Names="Microsoft Sans Serif" />
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>

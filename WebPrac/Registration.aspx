<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 37%;
            height: 176px;
        }
        .auto-style2 {
            width: 169px;
            text-align: center;
        }
        .auto-style4 {
            width: 169px;
            height: 25px;
            text-align: right;
        }
        .auto-style5 {
            width: 191px;
            height: 25px;
            text-align: center;
        }
        .auto-style6 {
            height: 25px;
            width: 1141px;
            text-align: left;
        }
        .auto-style8 {
            width: 191px;
            text-align: center;
        }
        .auto-style9 {
            width: 1141px;
            text-align: center;
        }
        .auto-style10 {
            width: 1546px;
            height: 485px;
            text-align: left;
        }
        .auto-style11 {
            width: 1141px;
            text-align: left;
        }
        .auto-style12 {
            width: 169px;
            text-align: right;
        }
        .auto-style13 {
            width: 1141px;
            text-align: left;
            margin-left: 40px;
        }
        .auto-style14 {
            width: 191px;
            text-align: left;
            height: 33px;
        }
        .auto-style15 {
            width: 169px;
            text-align: right;
            height: 33px;
        }
        .auto-style16 {
            width: 1141px;
            text-align: center;
            height: 33px;
        }
        .auto-style18 {
            width: 191px;
            text-align: center;
            height: 34px;
        }
        .auto-style19 {
            width: 1141px;
            text-align: left;
            height: 34px;
        }
        .auto-style20 {
            width: 169px;
            text-align: right;
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style10">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">User Name:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBoxUn" runat="server" Width="180px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BorderColor="#CC0000" ControlToValidate="TextBoxUn" ErrorMessage="User Name Required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">Email</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="TextBoxEmail" runat="server" Width="180px"></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Email Required"></asp:RequiredFieldValidator> <br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Must Enter a Valid Email" ControlToValidate="TextBoxEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">Password</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="password Required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">Confirm Password</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="TextBoxRePassword" runat="server" Width="180px" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style13">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxRePassword" ErrorMessage="password rentry required"></asp:RequiredFieldValidator> <br />
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords do not match" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxRePassword"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style20">Country</td>
                    <td class="auto-style18">
                        <asp:DropDownList ID="DropDownListCountry" runat="server" Width="180px" Height="24px">
                            <asp:ListItem>Select Country</asp:ListItem>
                            <asp:ListItem>Canada</asp:ListItem>
                            <asp:ListItem>North Korea</asp:ListItem>
                            <asp:ListItem>United States</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style19">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxUn" ErrorMessage="Please Select a Country" InitialValue="Select Country"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15"></td>
                    <td class="auto-style14">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                        <input id="Reset1" type="reset" value="reset" /></td>
                    <td class="auto-style16"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

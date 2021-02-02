<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="HW5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">



    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 108px;
    }
    .auto-style3 {
        width: 108px;
        height: 23px;
    }
    .auto-style4 {
        height: 23px;
    }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" BorderColor="Blue" ForeColor="#009933" style="font-weight: 700; font-size: x-large" Text="Calorie Counter"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Fat"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="FatTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FatTextBox" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="FatTextBox" ErrorMessage="Must be between 1-1000" ForeColor="Red" MaximumValue="1000" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Carbs"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="CarbsTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="CarbsTextBox" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="CarbsTextBox" ErrorMessage="Must be between 1-1000" ForeColor="Red" MaximumValue="1000" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Protein"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="ProteinTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ProteinTextBox" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="ProteinTextBox" ErrorMessage="Must be between 1-1000" ForeColor="Red" MaximumValue="1000" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="CalcButton" runat="server" Text="Calculate" />
                </td>
                <td>
                    <asp:Button ID="ClearButton" runat="server" Text="Clear" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="ErrorLabel" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:HiddenField ID="TotalHiddenField" runat="server" Value="0" />
                </td>
                <td>
                    <asp:Label ID="TotalLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:TextBox ID="CaloriesTextBox" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            background-color:wheat;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="margin:auto;border:5px solid white"">
             <tr>
                 <td>
                 <asp:Label ID="UserName_label" runat="server" Text="UserName"></asp:Label> </td>
                 <td>
                     <asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox> </td>
                 </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="login" OnClick="Button1_Click" Width="59px" />
                    </td>
                    <td>
                        <asp:Label ID="lblErrorMessage" runat="server" Text="incorrct user credentials" ForeColor="Red"></asp:Label>
                        
                    </td>
                </tr>
                <tr>
                    <td>
                    
                        <asp:HyperLink ID="Register" runat="server" NavigateUrl="~/Registration.aspx">New User Registration</asp:HyperLink>
                    
                        </td>
                </tr>



                
             
            </table>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="IsPostBackProperty.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 170px;
        }
        .style2
        {
            width: 201px;
            height: 23px;
        }
        .style4
        {
            width: 97px;
        }
        .style5
        {
            height: 23px;
            width: 97px;
        }
        .style6
        {
            width: 201px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 296px">
            <tr>
                <td class="style1" colspan="2">
                    Employee Details<br />
                    <br />
                    Please hover on FirstName,LastName Textbox<br />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    First Name:</td>
                <td class="style5">
                    <asp:TextBox ID="TextBox1" runat="server" Rows="2" TextMode="MultiLine" 
                        ToolTip="TextMode(MultiLine);Rows(2)"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    Last Name:</td>
                <td class="style4">
                    <asp:TextBox ID="TextBox2" runat="server" MaxLength="16" TextMode="Password" 
                        ToolTip="maxLength(16);TextMode(Password)"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    City:</td>
                <td class="style4">
                    <asp:DropDownList ID="DropDownList1" runat="server" 
                        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Button ID="Button1" runat="server" Text="Register Employee" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

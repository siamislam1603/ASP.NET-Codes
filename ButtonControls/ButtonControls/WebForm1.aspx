<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ButtonControls.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Button:
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    
    </div>
    <p>
        LinkButton(OnClientClick Event can be handled 
        which is usually js):
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
            onclientclick="return confirm('Are you sure you want submit this link')">Click Here to go to youtube</asp:LinkButton>
    </p>
    ImageButton: 
    <asp:ImageButton ID="ImageButton1" runat="server" 
        ImageUrl="~/Images/facebook.png" onclick="ImageButton1_Click" />
    </form>
</body>
</html>

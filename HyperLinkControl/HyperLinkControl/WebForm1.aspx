<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HyperLinkControl.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    NavigateUrl:
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://youtube.com">Click here to go to Youtube</asp:HyperLink>
    <br />
    <div>
    
        ImageUrl,Target(_blank for new tab) :&nbsp;
        <asp:HyperLink ID="HyperLink2" runat="server" ImageUrl="~/Images/facebook.png" 
            NavigateUrl="https://facebook.com" Target="_blank">Click here to go to Facebook</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>

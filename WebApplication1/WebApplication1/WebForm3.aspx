<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1
        {
            margin-left: 7px;
        }
        #Button1
        {
            width: 65px;
            margin-left: 12px;
        }
    </style>
</head>
<body style="height: 144px">
    <form id="form1" runat="server">
    <div>
    
        ASP.NET server control:<asp:TextBox ID="TextBox1" runat="server" 
            style="margin-left: 6px"></asp:TextBox>
    
    </div>
    <p>
        HTML control:<input id="Text1" type="text" runat="server" /></p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </p>
    </form>
</body>
</html>

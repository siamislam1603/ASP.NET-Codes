<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CommandEvent.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" CommandName="Print" 
            oncommand="CommandButton_Click" Text="Print" />
&nbsp;
        <asp:Button ID="Button2" runat="server" CommandName="Delete" 
            oncommand="CommandButton_Click" Text="Delete" />
&nbsp;
        <asp:Button ID="Button3" runat="server" CommandArgument="Top10" 
            CommandName="Show" oncommand="CommandButton_Click" 
            Text="Show Top 10 Employee" />
&nbsp;
        <asp:Button ID="Button4" runat="server" CommandArgument="Bottom10" 
            CommandName="Show" oncommand="CommandButton_Click" 
            Text="Show Bottom 10 Employee" />
&nbsp;
        <asp:Label ID="OutputLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>

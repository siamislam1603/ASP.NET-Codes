<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RadioButtonControl.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family:Arial">
        <fieldset>
            <legend><b>Gender</b></legend>
            <asp:RadioButton ID="MaleRadioButton" runat="server" GroupName="GenderGroup"
             Text="Male" 
                
                ToolTip="GroupName of all this  3 radio buttons are same to make them exclusive" 
                oncheckedchanged="MaleRadioButton_CheckedChanged" />
            <asp:RadioButton ID="FemaleRadioButton" runat="server" GroupName="GenderGroup" 
                Text="Female" />
            <asp:RadioButton ID="UnknownRadioButton" runat="server" GroupName="GenderGroup" 
                Text="Unknown" />
        </fieldset>
    </div>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
    </p>
    </form>
</body>
</html>

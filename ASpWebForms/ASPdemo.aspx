<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASPdemo.aspx.cs" Inherits="ASpWebForms.ASPdemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /><br /><br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br /><br />
        Enter<asp:TextBox runat="server"></asp:TextBox>

    </form>
</body>
</html>

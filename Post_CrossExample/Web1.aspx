<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Web1.aspx.cs" Inherits="Web1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter your name:"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true"></asp:TextBox>
            <br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Same page post back" OnClick="Button1_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="cross page post back" PostBackUrl="~/web2.aspx" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

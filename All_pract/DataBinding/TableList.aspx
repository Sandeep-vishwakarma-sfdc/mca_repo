<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TableList.aspx.cs" Inherits="TableList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mcaprctConnectionString %>" SelectCommand="Select name from sys.tables"></asp:SqlDataSource>
        <br />
        <br />
        List of Table :
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="name">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show Data" />
        <br />
        <br />
&nbsp;<br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" >
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 57%;
        }
        .auto-style2 {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;<br />
        <br />
        <table class="auto-style1">
            <tr>
                <td>Name</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Age</td>
                <td class="auto-style2">:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>City</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Record" /></td>
                <td><asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update Record" /></td>
                <td><asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete Record" /></td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        
&nbsp;
&nbsp;
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="C_Name" HeaderText="C_Name" SortExpression="C_Name" />
                <asp:BoundField DataField="C_Age" HeaderText="C_Age" SortExpression="C_Age" />
                <asp:BoundField DataField="C_Country" HeaderText="C_Country" SortExpression="C_Country" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mcaprctConnectionString %>" SelectCommand="SELECT * FROM [UserRegistration]"></asp:SqlDataSource>
        <br />
    
    </div>
    </form>
</body>
</html>

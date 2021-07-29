﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductData.aspx.cs" Inherits="LinqToSql.ProductData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product</title>
    <style type="text/css">
        .auto-style2 {
            width: 229px;
        }
        .auto-style3 {
            width: 118px;
        }
        .auto-style4 {
            width: 420px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <br />
        <table>
            <tr>
                <td class="auto-style2">Enter Product_Name</td>
                <td class="auto-style3">:</td>
                <td class="auto-style4"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2">Enter Product_Price</td>
                <td class="auto-style3">:</td>
                <td class="auto-style4"><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <th class="auto-style2"><asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click1" /></th>
                <th class="auto-style3"><asp:Button ID="Button2" runat="server" Text="Select" OnClick="Button2_Click" /></th>
                <th class="auto-style4">
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Update" />
                    &emsp;
                    <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" /></th>
            </tr>
            <tr>
                <th class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </th>
                <th class="auto-style3">&nbsp;</th>
                <th class="auto-style4">&nbsp;</th>
            </tr>
        </table>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" InsertVisible="False" />
                <asp:BoundField DataField="P_Name" HeaderText="P_Name" SortExpression="P_Name" />
                <asp:BoundField DataField="P_Price" HeaderText="P_Price" SortExpression="P_Price" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString %>" SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource>
        <br />
        <br />
    </div>
    </form>
</body>
</html>

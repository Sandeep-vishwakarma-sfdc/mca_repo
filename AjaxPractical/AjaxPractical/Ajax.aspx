<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ajax.aspx.cs" Inherits="AjaxPractical.Ajax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Image ID="Image1" runat="server" Width="100" Height="100" ImageUrl="Image/photo.jpeg" />
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    Current Time is:<br />
                    <asp:Timer ID="Timer1" runat="server" Interval="1000"
                        OnTick="Timer1_Tick1">
                    </asp:Timer>
                    <asp:Label ID="Label1" runat="server" BackColor="#FF9999" BorderStyle="Ridge"
                        Font-Size="Larger"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>

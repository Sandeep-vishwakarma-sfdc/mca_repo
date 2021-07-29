<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="RegistrationForm.registration" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 41%;
            height: 267px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
                
                   <br />
        <table class="auto-style2">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
               
                    </td>
                <td>:</td>
                <td>
               
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                

             
                    </td>
            </tr>
            <tr>
                <td>
                

             
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                
                    </td>
                <td>:</td>
                <td>
                
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
               
             
             
                    </td>
            </tr>
            <tr>
                <td>
               
             
             
                    <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
               
                    </td>
                <td>:</td>
                <td>
               
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
               
       
            
                    </td>
            </tr>
            <tr>
                <td>
               
       
            
                    <asp:Label ID="Label4" runat="server" Text="City"></asp:Label>
               
                    </td>
                <td>:</td>
                <td>
               
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Mumbai</asp:ListItem>
                        <asp:ListItem>Pune</asp:ListItem>
                        <asp:ListItem>Ratnagiri</asp:ListItem>
                        <asp:ListItem>Raigad</asp:ListItem>
                    </asp:DropDownList>
                
           
             
                    </td>
            </tr>
            <tr>
                <td>
                
           
             
                    <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label>
                
                    </td>
                <td>:</td>
                <td>
                
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gen" Text="Male" />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gen" Text="Female"/>
                
                    </td>
            </tr>
            <tr>
                <td>
                
                    <asp:Label ID="Label6" runat="server" Text="Gmail"></asp:Label>
               
                    </td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" TextMode="Email"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                   <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>

    </div>
    </form>
</body>
</html>
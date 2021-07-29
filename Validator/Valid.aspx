<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Valid.aspx.cs" Inherits="Valid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>VALIDATION CONTROLS: </h1>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <asp:Label ID="Label3" runat="server" Style="top: 241px; left: 32px; position: absolute; height: 22px; width: 128px; bottom: 54px;" Text="Enter your email id:">         </asp:Label>
            <asp:Label ID="Label1" runat="server" Style="top: 65px; left: 31px; position: absolute; height: 22px; width: 128px" Text="Enter your name:">  </asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Style="top: 66px; left: 212px; position: absolute; height: 22px; width: 128px; right: 765px;"> </asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Style="top: 67px; left: 378px; position: absolute; height: 22px; width: 128px" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1"> name is mandatory </asp:RequiredFieldValidator>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Style="top: 311px; left: 267px; position: absolute; height: 26px; width: 61px"
                Text="Submit" />
        </p>
        <asp:TextBox ID="TextBox3" runat="server" Style="top: 145px; left: 209px; position: absolute; height: 22px; width: 131px" TextMode="Password">      </asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Style="top: 105px; left: 210px; position: absolute; height: 22px; width: 131px"
                TextMode="Password">   </asp:TextBox>
            <asp:Label ID="Label4" runat="server" Style="top: 105px; left: 31px; position: absolute; height: 22px; width: 128px" Text="Password">      </asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" Style="top: 239px; left: 210px; position: absolute; height: 22px; width: 132px">  </asp:TextBox>
        </p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Style="top: 104px; left: 367px; position: absolute; height: 26px; width: 162px" ErrorMessage="password required" ControlToValidate="TextBox2">    </asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Style="top: 145px; left: 367px; position: absolute; height: 26px; width: 162px" ErrorMessage="password required" ControlToValidate="TextBox3">     </asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" Style="top: 149px; left: 512px; position: absolute; height: 26px; width: 162px" ErrorMessage="CompareValidator" ControlToValidate="TextBox3" ValueToCompare="hello">    </asp:CompareValidator>
        <p>
            <asp:Label ID="Label5" runat="server" Style="top: 148px; left: 32px; position: absolute; height: 22px; width: 128px; bottom: 147px;" Text="Confirm Password">   </asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Style="top: 194px; left: 209px; position: absolute; height: 22px; width: 132px">    </asp:TextBox>
            <asp:Label ID="Label6" runat="server" Style="top: 194px; left: 32px; position: absolute; height: 22px; width: 128px; bottom: 101px;" Text="Enter your age:">   </asp:Label>
        </p>
        <asp:RangeValidator ID="RangeValidator1" runat="server" Style="top: 194px; left: 365px; position: absolute; height: 22px; width: 105px" ErrorMessage="RangeValidator" ControlToValidate="TextBox4" MaximumValue="100" MinimumValue="18" Type="Integer"> </asp:RangeValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Style="top: 234px; left: 366px; position: absolute; height: 22px; width: 177px" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox5" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">  </asp:RegularExpressionValidator>

    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditDetail.aspx.cs" Inherits="SessionApplication.EditDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 656px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 295px; top: 195px; position: absolute" Text="New Username:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 454px; top: 191px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 317px; top: 267px; position: absolute" Text="Edit" />
        
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Welcome.aspx" style="z-index: 1; left: 289px; top: 361px; position: absolute">Welcome</asp:HyperLink>
        
    </form>
</body>
</html>

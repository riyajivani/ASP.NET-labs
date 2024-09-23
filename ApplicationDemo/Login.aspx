<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ApplicationDemo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 485px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 344px; top: 139px; position: absolute" Text="Username: "></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 344px; top: 206px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 429px; top: 137px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 437px; top: 208px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_click" style="z-index: 1; left: 350px; top: 294px; position: absolute" Text="Submit" />
       
    </form>
</body>
</html>

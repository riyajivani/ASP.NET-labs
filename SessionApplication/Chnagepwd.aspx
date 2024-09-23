<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chnagepwd.aspx.cs" Inherits="SessionApplication.Chnagepwd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 531px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 252px; top: 230px; position: absolute" Text="Change Pass: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 387px; top: 228px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 269px; top: 300px; position: absolute" Text="Change" />
       
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Welcome.aspx" style="z-index: 1; left: 256px; top: 385px; position: absolute">Welcome</asp:HyperLink>
       
    </form>
</body>
</html>

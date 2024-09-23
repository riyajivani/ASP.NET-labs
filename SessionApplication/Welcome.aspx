<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="SessionApplication.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/EditDetail.aspx" style="z-index: 1; left: 10px; top: 59px; position: absolute">Edit Details</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Chnagepwd.aspx" style="z-index: 1; left: 10px; top: 125px; position: absolute">Change pwd</asp:HyperLink>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 10px; top: 169px; position: absolute" Text="Logout" />
        <br />
        <br />
        <br />
    </form>
</body>
</html>

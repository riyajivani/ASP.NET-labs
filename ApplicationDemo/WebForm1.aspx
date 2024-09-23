<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ApplicationDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 530px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" style="z-index: 1; left: 390px; top: 133px; position: absolute; height: 28px; width: 96px">
            <asp:ListItem>Pencil</asp:ListItem>
            <asp:ListItem>Eraser</asp:ListItem>
            <asp:ListItem>Scale</asp:ListItem>
            <asp:ListItem>Pen</asp:ListItem>
            <asp:ListItem>Whitner</asp:ListItem>
        </asp:CheckBoxList>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 401px; top: 322px; position: absolute; height: 29px; width: 43px" Text="Add" OnClick="Button1_Click1"/>
    </form>
</body>
</html>

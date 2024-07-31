<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DynamicTable.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 540px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server"  style="z-index: 1; left: 147px; top: 90px; position: absolute; height: 28px; width: 181px">
            <asp:ListItem>select row</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownList2" runat="server" style="z-index: 1; left: 406px; top: 88px; position: absolute; height: 32px; width: 175px">
            <asp:ListItem>select column</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
        <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 148px; top: 163px; position: absolute; height: 366px; width: 823px">
        </asp:Panel>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 638px; top: 85px; position: absolute" Text="Generate Table" />
    </form>
</body>
</html>

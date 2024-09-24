<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Invokewebservice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 529px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 412px; top: 159px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 420px; top: 239px; position: absolute" Text="Button" />
        <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 382px; top: 317px; position: absolute; height: 152px; width: 232px">
        </asp:GridView>
        
    </form>
</body>
</html>

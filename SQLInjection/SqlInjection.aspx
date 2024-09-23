<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SqlInjection.aspx.cs" Inherits="SQLInjection.SqlInjection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 473px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 213px; top: 126px; position: absolute" Text="Username: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 364px; top: 124px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 216px; top: 192px; position: absolute" Text="Password: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 362px; top: 190px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 295px; top: 289px; position: absolute; height: 47px; width: 103px" Text="Submit" />
        <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 762px; top: 76px; position: absolute; height: 152px; width: 232px">
        </asp:GridView>
        <asp:Label ID="Label3" runat="server" ForeColor="#FF0066" style="z-index: 1; left: 151px; top: 353px; position: absolute; width: 530px" Text="username: ' OR 1=1; Select * from Login;--    and password:anything can select all the data from table because -- after  this will considered as comment and 1==1 always be true."></asp:Label>
       
    </form>
</body>
</html>

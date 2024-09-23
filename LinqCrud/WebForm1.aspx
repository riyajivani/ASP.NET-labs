<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LinqCrud.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 634px;
        }
    </style>
</head>
<body style="height: 634px">
    <form id="form1" runat="server">
        
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 239px; top: 137px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 242px; top: 216px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 237px; top: 298px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 241px; top: 375px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 77px; top: 514px; position: absolute" Text="Insert" />
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 245px; top: 448px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 87px; top: 448px; position: absolute" Text="Salary: "></asp:Label>
        
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 190px; top: 516px; position: absolute; height: 29px;" Text="Update" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 319px; top: 513px; position: absolute" Text="Delete" OnClick="Button3_Click" />
        
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 96px; top: 141px; position: absolute" Text="Id: "></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 83px; top: 217px; position: absolute" Text="Name:"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 91px; top: 303px; position: absolute" Text="Desg: "></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 84px; top: 379px; position: absolute" Text="Dept:"></asp:Label>

            <asp:Button ID="Button4" runat="server" style="z-index: 1; left: 437px; top: 513px; position: absolute" Text="Avg salary" OnClick="Button4_Click" />
    
        <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 719px; top: 197px; position: absolute; height: 152px; width: 232px">
        </asp:GridView>
    
    </form>
</body>
</html>

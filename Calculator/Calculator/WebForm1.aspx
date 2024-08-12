<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body, html {
            height: 482px;
        }

        .container{
              height:100%;
              display:flex;
              flex-direction:column;
              justify-content:center;
              align-items:center;
              gap:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Label ID="Label1" runat="server" Text="Number1"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            <asp:Label ID="Label2" runat="server" Text="Number2"></asp:Label> 
            <asp:TextBox ID="TextBox2" runat="server"  OnTextChanged="TextBox2_TextChanged"></asp:TextBox>

            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Sub" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Mul" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Div" OnClick="Button4_Click" /> 

        </div>
    </form>
</body>
</html>

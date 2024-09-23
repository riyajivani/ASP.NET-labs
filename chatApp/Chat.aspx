<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="chatApp.Chat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #chatArea {
            height: 300px;
            overflow-y: scroll;
            border: 1px solid #ccc;
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Chat Application</h2>
            <div id="chatArea" runat="server"></div>
            <asp:TextBox ID="txtUsername" runat="server" Placeholder="Enter your username"></asp:TextBox><br />
            <asp:TextBox ID="txtMessage" runat="server" Placeholder="Enter your message"></asp:TextBox><br />
            <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click" />
        </div>
    </form>
</body>
</html>

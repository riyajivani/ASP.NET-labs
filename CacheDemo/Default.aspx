<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CacheDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h2>Cache Management</h2>

            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label><br /><br />

            <!-- File-based cache dependency -->
            <h4>File-Based Cache</h4>
            <asp:TextBox ID="txtFilePath" runat="server" Placeholder="Enter file path"></asp:TextBox>
            <asp:Button ID="btnFileDependency" runat="server" Text="Add File Dependency" OnClick="btnFileDependency_Click" /><br /><br />

            <!-- Key-based cache dependency -->
            <h4>Key-Based Cache</h4>
            <asp:Button ID="btnKeyDependency" runat="server" Text="Add Key Dependency" OnClick="btnKeyDependency_Click" style="margin-bottom: 1px" /><br /><br />

            <!-- Time-based cache dependency -->
            <h4>Time-Based Cache</h4>
            <asp:TextBox ID="txtTimeSeconds" runat="server" Placeholder="Enter time in seconds"></asp:TextBox>
            <asp:Button ID="btnTimeDependency" runat="server" Text="Add Time Dependency" OnClick="btnTimeDependency_Click" /><br /><br />

            <!-- Clear cache -->
            <h4>Clear All Cache</h4>
            <asp:Button ID="btnClearCache" runat="server" Text="Clear Cache" OnClick="btnClearCache_Click" /><br /><br />

        </div>
    </form>
</body>
</html>

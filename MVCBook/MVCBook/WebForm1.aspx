<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MVCBook.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource runat="server" ConnectionString="Data Source=RIYA\SQLEXPRESS;Initial Catalog=Book;Integrated Security=True;" ID="ds" />
        </div>
    </form>
</body>
</html>

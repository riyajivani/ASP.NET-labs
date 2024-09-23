<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DataAccessLayer.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Faculty Management</title>
    <style>
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 524px">
            <div class="form-group">
                <asp:Label ID="LabelId" runat="server" Text="ID:" AssociatedControlID="TextBoxId"></asp:Label>
                <asp:TextBox ID="TextBoxId" runat="server" placeholder="ID"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="LabelName" runat="server" Text="Name:" AssociatedControlID="TextBoxName"></asp:Label>
                <asp:TextBox ID="TextBoxName" runat="server" placeholder="Name"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="LabelDesg" runat="server" Text="Designation:" AssociatedControlID="TextBoxDesg"></asp:Label>
                <asp:TextBox ID="TextBoxDesg" runat="server" placeholder="Designation"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="LabelDept" runat="server" Text="Department:" AssociatedControlID="TextBoxDept"></asp:Label>
                <asp:TextBox ID="TextBoxDept" runat="server" placeholder="Department"></asp:TextBox>
            </div>

            <asp:Button ID="ButtonInsert" runat="server" Text="Insert" OnClick="ButtonInsert_Click" />
            <asp:Button ID="ButtonUpdate" runat="server" Text="Update" OnClick="ButtonUpdate_Click" />
            <asp:Button ID="ButtonDelete" runat="server" Text="Delete" OnClick="ButtonDelete_Click" />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="ID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Desg" HeaderText="Designation" />
                    <asp:BoundField DataField="Dept" HeaderText="Department" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>

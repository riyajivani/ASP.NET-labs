<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SQLdataSource.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"  AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnRowDataBound="GridView1_RowDataBound">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" ShowInsertButton="True"/>
                <asp:BoundField DataField="Id" HeaderText="Stud Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Name" HeaderText="stud Name" SortExpression="Name" />
                <asp:BoundField DataField="Sem" HeaderText="Stud Sem" SortExpression="Sem" />
                <asp:BoundField DataField="Branch" HeaderText="Stud Branch" SortExpression="Branch" />
                <asp:BoundField DataField="Batch" HeaderText="Stud Batch" SortExpression="Batch" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:mycs %>" 
            DeleteCommand="DELETE FROM [student] WHERE [Id] = @Id" 
            InsertCommand="INSERT INTO [student] ([Id], [Name], [Sem],[Branch],[Batch]) VALUES (@Id, @Name, @Sem,@Branch,@Batch)" 
            SelectCommand="SELECT * FROM [student]" 
            UpdateCommand="UPDATE [student] SET [Name] = @Name, [Sem] = @Sem, [Branch]=@Branch, [Batch]=@Batch WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Id" Type="Int32" />
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Sem" Type="Int32" />
                <asp:Parameter Name="Branch" Type="String" />
                <asp:Parameter Name="Batch" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Sem" Type="Int32" />
                <asp:Parameter Name="Id" Type="Int32" />
                <asp:Parameter Name="Branch" Type="String" />
                <asp:Parameter Name="Batch" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>

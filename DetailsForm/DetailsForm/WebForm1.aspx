<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DetailsForm.WebForm1" %>

<!DOCTYPE html>
<script runat="server">
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        body{
            height:100%;
            margin:10px;
            background-color:cornsilk;
        }

        .container{
            display:flex;
            flex-direction:column;
            gap:10px;
            margin:10px;
            align-items:start;
            justify-content:center;
        }
        .group{
            display:flex;
            gap:5px;
        }

         .detailsTable {
            width: 100%;
            border-collapse: collapse;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <h1>Application Form</h1>

            <div class="group">
                <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" TextMode="SingleLine"></asp:TextBox>
            </div>

            <div class="group">
                <asp:Label ID="Label2" runat="server" Text="Email: "></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Email"></asp:TextBox>
            </div>

            <div class="group">
              <asp:Label ID="Label3" runat="server" Text="Phone no.: "></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Phone"></asp:TextBox>
            </div>

            <div class="group">
                <asp:Label ID="Label4" runat="server" Text="Country: "></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="CountryChange">
                     <asp:ListItem ID="item0" Text="select country" ></asp:ListItem>
                   <asp:ListItem ID="item1" Text="INDIA"></asp:ListItem>
                   <asp:ListItem ID="item2" Text="USA"></asp:ListItem>
                   <asp:ListItem ID="item3" Text="UK"></asp:ListItem>
                </asp:DropDownList>
            </div>
            
            <div class="group">
                <asp:Label ID="Label5" runat="server" Text="State: "></asp:Label>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true" OnSelectedIndexChanged="StateChnaged"></asp:DropDownList>
            </div>

            <div class="group">
                <asp:Label ID="Label6" runat="server" Text="City: "></asp:Label>
                <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
            </div>

            <div class="group">
                <asp:Label ID="Label7" runat="server" Text="Certificates: " CssClass="horizontalCheckBoxList"></asp:Label>
                <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                    <asp:ListItem>IELTS</asp:ListItem>
                    <asp:ListItem>GRE</asp:ListItem>
                    <asp:ListItem>NCAT</asp:ListItem>
                    <asp:ListItem>GATE</asp:ListItem>
                </asp:CheckBoxList>
            </div>

            <div class="group">
                <asp:Label ID="Label8" runat="server" Text="Gender: "></asp:Label>
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Female"/>
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Male"/>
            </div>
            
            <asp:Button ID="Button1" runat="server" Text="Submit" BackColor="Green" BorderStyle="None" ForeColor="White" OnClick="HandleSubmit" />

            <asp:Panel ID="Panel1" runat="server"></asp:Panel>

        </div>
    </form>
</body>
</html>

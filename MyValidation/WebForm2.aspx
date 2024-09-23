<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="MyValidation.WebForm2" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 1236px;
        }
    </style>
</head>
<body style="height: 1097px">
    <form id="form1" runat="server">

        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 31px; top: 51px; position: absolute" Text="Name: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CausesValidation="True" style="z-index: 1; left: 130px; top: 52px; position: absolute"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name should not be empty." ForeColor="Red" SetFocusOnError="True" style="z-index: 1; left: 321px; top: 52px; position: absolute"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name not contain numbers." ForeColor="Red" style="z-index: 1; left: 560px; top: 52px; position: absolute" ValidationExpression="^[a-zA-Z\s]*$"></asp:RegularExpressionValidator>

        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 29px; top: 94px; position: absolute" Text="Email: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" CausesValidation="True" style="z-index: 1; left: 129px; top: 93px; position: absolute"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Email must contain @ and . " ForeColor="Red" style="z-index: 1; left: 327px; top: 94px; position: absolute" ValidationExpression="\w+([.]\w+)*@\w+([.]\w+)*\.\w+([.]\w+)*"></asp:RegularExpressionValidator>

        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 33px; top: 141px; position: absolute" Text="Ph no."></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" CausesValidation="True" style="z-index: 1; left: 126px; top: 143px; position: absolute"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Phone no. not contain alphabets and only indian no.(starts with 6-9) allowed" ForeColor="Red" style="z-index: 1; left: 328px; top: 144px; position: absolute" ValidationExpression="^\+91[6-9][0-9]{9}$"></asp:RegularExpressionValidator>

        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 34px; top: 246px; position: absolute" Text="Future Scope: "></asp:Label>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" CausesValidation="True" style="z-index: 1; left: 185px; top: 245px; position: absolute; height: 28px; width: 191px">
            <asp:ListItem>Higher Study</asp:ListItem>
            <asp:ListItem>Masters</asp:ListItem>
            <asp:ListItem>Interprenurship</asp:ListItem>
        </asp:CheckBoxList>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="One scope should be selected." ForeColor="Red" OnServerValidate="CheckboxListValidate" style="z-index: 1; left: 392px; top: 267px; position: absolute"></asp:CustomValidator>

        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 37px; top: 338px; position: absolute" Text="Country"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" CausesValidation="True" style="z-index: 1; left: 163px; top: 333px; position: absolute">
            <asp:ListItem>India</asp:ListItem>
            <asp:ListItem>US</asp:ListItem>
            <asp:ListItem>UK</asp:ListItem>
        </asp:DropDownList>
        <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="One Country should selected" ForeColor="Red" style="z-index: 1; left: 284px; top: 331px; position: absolute" OnServerValidate="DropdownValidate"></asp:CustomValidator>

        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 39px; top: 194px; position: absolute" Text="Gender:"></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList1" CausesValidation="true" runat="server" style="z-index: 1; left: 139px; top: 184px; position: absolute; height: 28px; width: 96px">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <asp:CustomValidator ID="CustomValidator4" runat="server" ErrorMessage="Select age " ForeColor="#CC0000" style="z-index: 1; left: 250px; top: 199px; position: absolute" OnServerValidate="RadioButtonValidate"></asp:CustomValidator>

        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 42px; top: 379px; position: absolute" Text="Passwod: "></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" CausesValidation="True" style="z-index: 1; left: 148px; top: 376px; position: absolute"></asp:TextBox>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="Pass must contain atleast one capital letter and atleast one number. and length should be 8." ForeColor="Red" style="z-index: 1; left: 337px; top: 359px; position: absolute" ValidationExpression="^(?=.*[a-zA-Z])(?=.*\d).{8}$" ControlToValidate="TextBox5"></asp:RegularExpressionValidator>

        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 45px; top: 455px; position: absolute" Text="Birthdate: "></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" CausesValidation="True" style="z-index: 1; left: 150px; top: 452px; position: absolute" TextMode="Date"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator3" runat="server" ErrorMessage="event date should be futre date" ForeColor="Red" OnServerValidate="DateValidate" style="z-index: 1; left: 338px; top: 452px; position: absolute"></asp:CustomValidator>

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 544px; top: 550px; position: absolute; height: 51px; width: 140px" Text="Submit" />

        <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 95px; top: 657px; position: absolute; height: 152px; width: 232px">
        </asp:GridView>
        
    </form>
</body>
</html>

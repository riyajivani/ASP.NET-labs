<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Advertisement.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 524px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <asp:AdRotator ID="AdRotator3" runat="server"  style="z-index: 1; left: 183px; top: 171px; position: absolute; height: 249px; width: 238px" AdvertisementFile="~/XMLFile1.xml" KeywordFilter="Lake" Target="_blank" />

        <asp:AdRotator ID="AdRotator2" runat="server" AdvertisementFile="~/XMLFile1.xml" KeywordFilter="Fruit" style="z-index: 1; left: 580px; top: 172px; position: absolute; height: 249px; width: 238px" Target="_blank" />
    </form>
</body>
</html>

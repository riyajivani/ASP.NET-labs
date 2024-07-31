<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="imagemapdemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 532px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <%--<asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" ImageUrl="~/imagemapdemo.png" />--%>

        <asp:ImageMap ID="ImageMap1" runat="server" style="z-index: 1; left: 316px; top: 96px; position: absolute; height: 333px; width: 545px" ImageUrl="~/imagemapdemo.png" >
            <asp:CircleHotSpot AlternateText="Circle" HotSpotMode="Navigate" NavigateUrl="~/Circle.aspx" Radius="84" Target="_blank" X="390" Y="102" />
            <asp:RectangleHotSpot AlternateText="Rectangle" Bottom="303" HotSpotMode="Navigate" Left="56" NavigateUrl="~/Rectangle.aspx" Right="490" Target="_blank" Top="201" />
            <asp:PolygonHotSpot AlternateText="Triangle" Coordinates="145,26;194,100;238,175;140,176;55,172;100,98" HotSpotMode="Navigate" NavigateUrl="~/Triangle.aspx" Target="_blank" />
        </asp:ImageMap>
    </form>
</body>
</html>

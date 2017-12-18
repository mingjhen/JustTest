<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="StyleSheet.css">
</head>
<body>
    <form id="form1" runat="server">
        <div id="top">
            <asp:TextBox ID="CountrySearch" runat="server"></asp:TextBox>
            <asp:Button ID="LinkData" runat="server" Text="確認" OnClick="LinkData_Click" />
        </div>
        <div id="sidebar">
            <div id="sidebar-top">
                <asp:Label ID="Label1" runat="server"></asp:Label></div>

            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" Font-Size="20px" TextMode="MultiLine" Height="400px" Width="100px" BorderStyle="Solid"></asp:TextBox>
        </div>
        <div id="center">
            <div id="center-top">
                <asp:Label ID="Label2" runat="server"></asp:Label></div>
            <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" Font-Size="20px" TextMode="MultiLine" Height="400px" Width="300px" BorderStyle="Solid" Visible="False"></asp:TextBox>
        </div>

    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="HitCounter.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hit counter</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelText" runat="server" Text="Label text"></asp:Label>
        </div>
        <asp:Label ID="LabelNumber" runat="server" Text="Number of hits:"></asp:Label>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BadGuyPage.aspx.cs" Inherits="FishApplicationAndSession.BadGuyPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bad guys</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelInfo" runat="server" Text="You were not allowed to visit this page"></asp:Label>
        </div>
        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Button" />
    </form>
</body>
</html>

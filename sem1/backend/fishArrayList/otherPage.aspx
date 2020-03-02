<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="otherPage.aspx.cs" Inherits="fishArrayList.otherPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Other page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBoxOther" runat="server" Height="241px" Width="291px"></asp:ListBox>
        </div>
        <asp:Button ID="ButtonGoBack" runat="server" OnClick="ButtonGoBack_Click" Text="Go back to front page" />
    </form>
</body>
</html>

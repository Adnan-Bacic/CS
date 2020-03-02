<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeeUsers.aspx.cs" Inherits="backendHandin2.seeUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>All users</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>All users</h1>
        </div>
            <p>
                <asp:ListBox ID="ListBoxUsers" runat="server" Height="326px" Width="644px"></asp:ListBox>
        </p>
        <p>
            <asp:Button ID="Button4" runat="server" PostBackUrl="~/index.aspx" Text="Back" />
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>

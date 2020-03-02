<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="variables.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Variables</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelHeader" runat="server" Text="Different kind of variables"></asp:Label>
        </div>
        <asp:ListBox ID="ListBoxResult" runat="server" Font-Size="Large" Height="251px" Width="648px"></asp:ListBox>
    </form>
</body>
</html>

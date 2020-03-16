<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TestDrivenMath.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Examples</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelResult" runat="server" Text="Results"></asp:Label>
            <br />
            <br />
            <asp:ListBox ID="ListBoxResult" runat="server" Height="200px" Width="400px"></asp:ListBox>
        </div>
    </form>
</body>
</html>

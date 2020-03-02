<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="DB_Connection.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridViewNorthwind" runat="server" EmptyDataText="No data yet">
            </asp:GridView>
        </div>
        <asp:Button ID="ButtonShow" runat="server" OnClick="ButtonShow_Click" Text="Button" />
        <p>
            <asp:Label ID="LabelMessage" runat="server" Text="No messages"></asp:Label>
        </p>
        <asp:ListBox ID="ListBoxNorthwind" runat="server" Height="238px" Width="604px"></asp:ListBox>
        <p>
            <asp:Button ID="ButtonListbox" runat="server" OnClick="ButtonListbox_Click" Text="Show data" />
        </p>
    </form>
</body>
</html>

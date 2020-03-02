<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="NorthwindCRUD.Create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridViewShippers" runat="server">
            </asp:GridView>
            <asp:TextBox ID="TextBoxCompany" runat="server"></asp:TextBox>
            <asp:Label ID="LabelCompany" runat="server" Text="Company name"></asp:Label>
        </div>
        <asp:TextBox ID="TextBoxPhone" runat="server"></asp:TextBox>
        <asp:Label ID="LabelPhone" runat="server" Text="Company phone"></asp:Label>
        <br />
        <asp:Label ID="LabelMessages" runat="server" Text="No messages"></asp:Label>
        <br />
        <asp:Button ID="ButtonCreate" runat="server" OnClick="ButtonCreate_Click" style="width: 56px" Text="Create" />
    </form>
</body>
</html>

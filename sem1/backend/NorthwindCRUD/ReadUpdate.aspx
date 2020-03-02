<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadUpdate.aspx.cs" Inherits="NorthwindCRUD.ReadUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridViewShippers" runat="server" EmptyDataText="No data" OnSelectedIndexChanged="GridViewShippers_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
        <asp:Label ID="LabelMessages" runat="server" Text="No messages"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxCompany" runat="server"></asp:TextBox>
        <asp:Label ID="LabelCompany" runat="server" Text="Company name"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxPhone" runat="server"></asp:TextBox>
        <asp:Label ID="LabelPhone" runat="server" Text="Company phone"></asp:Label>
        <br />
        <asp:Button ID="ButtonUpdate" runat="server" OnClick="ButtonUpdate_Click" Text="Update" />
    </form>
</body>
</html>

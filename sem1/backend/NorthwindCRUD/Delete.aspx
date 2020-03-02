<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="NorthwindCRUD.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridViewShippers" runat="server" EmptyDataText="No data">
            </asp:GridView>
        </div>
        <asp:DropDownList ID="DropDownListShippers" runat="server" OnSelectedIndexChanged="DropDownListShippers_SelectedIndexChanged">
        </asp:DropDownList>
        <p>
            <asp:Label ID="LabelMessages" runat="server" Text="No messages"></asp:Label>
        </p>
        <asp:Button ID="ButtonDelete" runat="server" Text="Delete" OnClick="ButtonDelete_Click" style="height: 26px" />
    </form>
</body>
</html>

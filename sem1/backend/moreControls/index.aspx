<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="moreControls.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>More controls</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList" runat="server" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
            </asp:DropDownList>
        </div>
        <p>
            <asp:Label ID="LabelMsg" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>

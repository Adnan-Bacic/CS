<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="fishArrayList.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fish</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBoxType" runat="server"></asp:TextBox>
            <asp:Label ID="LabelType" runat="server" Text="Type"></asp:Label>
            <br />
            <asp:TextBox ID="TextBoxLength" runat="server"></asp:TextBox>
            <asp:Label ID="LabelLength" runat="server" Text="Length"></asp:Label>
        </div>
        <asp:Button ID="ButtonCreate" runat="server" OnClick="ButtonCreate_Click" Text="Create" />
        <p>
            <asp:Button ID="ButtonShow" runat="server" OnClick="ButtonShow_Click" Text="Show all fish" />
        </p>
        <asp:ListBox ID="ListBoxFish" runat="server" Height="190px" Width="264px"></asp:ListBox>
        <p>
            <asp:Button ID="ButtonOther" runat="server" PostBackUrl="~/otherPage.aspx" Text="Go to other page" />
        </p>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="FishApplicationAndSession.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelHeader" runat="server" Text="Fish in the collection:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBoxFish" runat="server" Height="212px" Width="441px" TextMode="MultiLine"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" Text="Add new fish" />
        </p>
        <asp:Label ID="LabelLevel" runat="server" Text="You are at level"></asp:Label>
        <p>
            <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
            <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label>
        </p>
        <asp:Button ID="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" Text="Login" />
        <p>
            <asp:Button ID="ButtonLogout" runat="server" OnClick="ButtonLogout_Click" Text="Logout" />
        </p>
    </form>
</body>
</html>

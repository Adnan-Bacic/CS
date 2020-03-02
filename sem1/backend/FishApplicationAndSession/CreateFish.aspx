<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateFish.aspx.cs" Inherits="FishApplicationAndSession.CreateFish" %>

<!--tells the broswer to not cache the page-->
<%@ OutputCache Location="None" NoStore="true" VaryByParam="none" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create a fish</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelLevel" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:TextBox ID="TextBoxType" runat="server"></asp:TextBox>
            <asp:Label ID="LabelType" runat="server" Text="Fish type"></asp:Label>
        </div>
        <asp:TextBox ID="TextBoxLength" runat="server"></asp:TextBox>
        <asp:Label ID="LabelLength" runat="server" Text="Fish length"></asp:Label>
        <p>
            <asp:Button ID="ButtonCreate" runat="server" Text="Create" OnClick="ButtonCreate_Click" />
        </p>
    </form>
</body>
</html>

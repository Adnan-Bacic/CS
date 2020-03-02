<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PreInit.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change of theme</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelCat" runat="server" Text="Cat picture"></asp:Label>
        </div>
        <asp:Image ID="ImageCat" runat="server" SkinID="myskin" />
        <p>
            <asp:Button ID="ButtonDomestic" runat="server" OnClick="ButtonDomestic_Click" PostBackUrl="~/index.aspx?Theme=themeDomestic" Text="Domestic" />
            <asp:Button ID="ButtonEgypt" runat="server" OnClick="ButtonEgypt_Click" PostBackUrl="~/index.aspx?Theme=themeEgyptian" Text="Egyptian" />
        </p>
    </form>
</body>
</html>

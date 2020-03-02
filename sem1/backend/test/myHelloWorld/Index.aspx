<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="myHelloWorld.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Hello World</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="My web page"></asp:Label>

        </div>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged">Text box</asp:TextBox>
        <p>
            <asp:TextBox ID="textBoxInput" runat="server" OnTextChanged="textBoxInput_TextChanged"></asp:TextBox>
            <asp:TextBox ID="textBoxEcho" runat="server">text shown here</asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Press me" />
        </p>
    </form>
</body>
</html>

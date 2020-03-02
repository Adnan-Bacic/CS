<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Schema_Validator.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Schema validation</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelHead" runat="server" Text="XML valdiation with schema and xml reader"></asp:Label>
        </div>
        <asp:TextBox ID="TextBoxXML" runat="server" Height="18px" Width="387px"></asp:TextBox>
        <asp:Label ID="LabelXML" runat="server" Text="XML file"></asp:Label>
        <p>
            <asp:TextBox ID="TextBoxXSD" runat="server" Height="19px" Width="384px"></asp:TextBox>
            <asp:Label ID="LabelXSD" runat="server" Text="XSD file"></asp:Label>
        </p>
        <asp:Button ID="ButtonValidate" runat="server" OnClick="ButtonValidate_Click" Text="Validate" />
        <p>
            <asp:Label ID="LabelMesssages" runat="server" Text="No messagas"></asp:Label>
        </p>
        <asp:ListBox ID="ListBoxErrors" runat="server" Height="500px" Width="1000px"></asp:ListBox>
    </form>
</body>
</html>

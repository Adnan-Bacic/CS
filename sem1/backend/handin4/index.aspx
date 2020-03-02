<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="handin4.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Handin 4</title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
        </p>
        <asp:TextBox ID="TextBoxAge" runat="server"></asp:TextBox>
        <asp:Label ID="LabelAge" runat="server" Text="Age"></asp:Label>
        <p>
            <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
            <asp:Label ID="LabelEmail" runat="server" Text="Email"></asp:Label>
        </p>
        <asp:TextBox ID="TextBoxKeycard" runat="server"></asp:TextBox>
        <asp:Label ID="LabelKeycard" runat="server" Text="Keycard"></asp:Label>
        <p>
            <asp:Button ID="ButtonCreate" runat="server" OnClick="ButtonCreate_Click" Text="Add" />
        </p>
        <p>
            <asp:Label ID="LabelMessages" runat="server"></asp:Label>
        </p>
        <asp:ListBox ID="ListBoxResult" runat="server" Height="245px" Width="702px"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="ButtonSaveXML" runat="server" OnClick="ButtonSaveXML_Click" Text="Save as XML file" />
&nbsp;<asp:Button ID="ButtonXMLRead" runat="server" OnClick="ButtonXMLRead_Click" Text="See XML file" />
        <p>
            <asp:Button ID="ButtonSaveBinary" runat="server" OnClick="ButtonSaveBinary_Click" Text="Save as binary file" />
&nbsp;<asp:Button ID="ButtonReadBinary" runat="server" OnClick="ButtonReadBinary_Click" Text="See binary file" />
        </p>
    </form>
</body>
</html>

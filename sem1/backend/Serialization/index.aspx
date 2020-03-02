<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Serialization.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
        </div>
        <asp:TextBox ID="TextBoxColour" runat="server"></asp:TextBox>
        <asp:Label ID="LabelColour" runat="server" Text="Colour"></asp:Label>
            <br />
            <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
            <asp:Label ID="LabelID" runat="server" Text="ID"></asp:Label>
        <p>
            <asp:Button ID="ButtonCreate" runat="server" OnClick="ButtonCreate_Click" Text="Create Cat" />
        </p>
        <asp:ListBox ID="ListBoxCats" runat="server" Height="217px" Width="561px"></asp:ListBox>
        <p>
            <asp:Label ID="LabelMessages" runat="server"></asp:Label>
        </p>
        <asp:Button ID="ButtonSaveBinary" runat="server" OnClick="ButtonSaveBinary_Click" Text="Save binary" />
        <p>
            <asp:Button ID="ButtonReadBinary" runat="server" OnClick="ButtonReadBinary_Click" Text="Read binary" />
        </p>
        <asp:Button ID="ButtonSaveXML" runat="server" OnClick="ButtonSaveXML_Click" Text="Save XML" />
        <p>
            <asp:Button ID="ButtonReadXML" runat="server" OnClick="ButtonReadXML_Click" Text="Read XML" />
        </p>
        <asp:Button ID="ButtonSaveJSONOldSchool" runat="server" OnClick="ButtonSaveJSONOldSchool_Click" Text="Save JSON old school" />
        <p>
            <asp:Button ID="ButtonReadJSONOldSchool" runat="server" OnClick="ButtonReadJSONOldSchool_Click" Text="Read JSON old school" />
        </p>
        <asp:Button ID="ButtonSaveJSON" runat="server" OnClick="ButtonSaveJSON_Click" Text="Save JSON" />
        <p>
            <asp:Button ID="ButtonReadJSON" runat="server" OnClick="ButtonReadJSON_Click" Text="Read JSON" />
        </p>
    </form>
</body>
</html>

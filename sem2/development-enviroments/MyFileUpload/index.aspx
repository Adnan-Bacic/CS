<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MyFileUpload.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUploadMyFile" runat="server" />
        </div>
        <asp:Label ID="LabelName" runat="server" Text="New name of file"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonUpload" runat="server" OnClick="ButtonUpload_Click" Text="Upload" />
        <br />
        <asp:Label ID="LabelMessages" runat="server" Text="Messages:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxMessages" runat="server" Height="191px" Width="391px"></asp:TextBox>
        <br />
        <asp:Label ID="LabelFilesInFolder" runat="server" Text="Files in folder"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownListFiles" runat="server">
        </asp:DropDownList>
    </form>
</body>
</html>

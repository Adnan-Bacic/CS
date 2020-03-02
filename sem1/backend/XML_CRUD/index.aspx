<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="XML_CRUD.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>XML CRUD</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownListCats" runat="server">
            </asp:DropDownList>
        </div>
        <asp:Label ID="LabelMessages" runat="server"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxID" runat="server" ReadOnly="True"></asp:TextBox>
        <asp:Label ID="LabelID" runat="server" Text="ID (readonly)"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxColour" runat="server"></asp:TextBox>
        <asp:Label ID="LabelColour" runat="server" Text="Colour"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxPicture" runat="server"></asp:TextBox>
        <asp:Label ID="LabelPicture" runat="server" Text="Picture"></asp:Label>
        <br />
        <asp:Button ID="ButtonCreate" runat="server" Text="Create" OnClick="ButtonCreate_Click" />
&nbsp;<asp:Button ID="ButtonUpdate" runat="server" Text="Update" OnClick="ButtonUpdate_Click" />
&nbsp;<asp:Button ID="ButtonDelete" runat="server" Text="Delete" OnClick="ButtonDelete_Click" />
        <br />
        <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" OnClick="ButtonCancel_Click" />

        <asp:Repeater ID="RepeaterCat" runat="server">
            <HeaderTemplate>
                <table border="double">
                    <tr>
                        <td>Cat ID</td>
                        <td>Name</td>
                        <td>Colour</td>
                        <td>Picture</td>
                        <td>Photo</td>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("CatID") %></td>
                    <td><%# Eval("CatName") %></td>
                    <td><%# Eval("CatColour") %></td>
                    <td><%# Eval("Picture") %></td>
                    <td><img src="pictures/<%# Eval("Picture") %>" alt="cat" /></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>

    </form>
</body>
</html>

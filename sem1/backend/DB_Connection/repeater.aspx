<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="repeater.aspx.cs" Inherits="DB_Connection.repeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="RepeaterCats" runat="server">
                <HeaderTemplate>
                    <table class="table">
                        <tr>
                            <td class="tableHeader">Cat ID</td>
                            <td class="tableHeader">Cat Name</td>
                            <td class="tableHeader">Cat Colour</td>
                            <td class="tableHeader">Cat birthday</td>
                            <td class="tableHeader">Cat Picture</td>
                        </tr>
                </HeaderTemplate>

                <ItemTemplate>
                    <tr>
                        <td class="item"><%# Eval("catID") %></td>
                        <td class="item"><%# Eval("catname") %></td>
                        <td class="item"><%# Eval("catColour") %></td>
                        <td class="item"><%# Eval("catBirthday", "{0:dd-MM-yyyy}") %></td>
                        <td class="item"><img src="pictures/<%# Eval("catPicture") %>.jpg" alt="cat" /></td>

                    </tr>
                </ItemTemplate>

                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
        <asp:Button ID="ButtonShowCats" runat="server" Text="Show cats" OnClick="ButtonShowCats_Click" />
        <p>
            <asp:Label ID="LabelMessages" runat="server" Text="No messages"></asp:Label>
        </p>
    </form>
</body>
</html>

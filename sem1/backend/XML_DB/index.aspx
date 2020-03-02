<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="XML_DB.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>XML DB exchange</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:Repeater ID="RepeaterHorse" runat="server">
                <HeaderTemplate>
                    <table border="single">
                        <tr>
                            <td>ID</td>
                            <td>Name</td>
                            <td>Breed</td>
                            <td>Picture name</td>
                            <td>Picture</td>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("HorseID") %></td>
                        <td><%# Eval("HorseName") %></td>
                        <td><%# Eval("HorseBreed") %></td>
                        <td><%# Eval("Picture") %></td>
                        <td><img src="pictures/<%# Eval("Picture") %>" alt="Horse" /></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>


        <asp:Label ID="LabelMessages" runat="server"></asp:Label>
        <br />
        <asp:Button ID="ButtonSave" runat="server" Text="Save to XML" OnClick="ButtonSave_Click" />
&nbsp;<asp:Button ID="ButtonRead" runat="server" Text="Read from XML" OnClick="ButtonRead_Click" />
    </form>
</body>
</html>

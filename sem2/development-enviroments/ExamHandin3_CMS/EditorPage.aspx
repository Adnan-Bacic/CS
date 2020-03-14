<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditorPage.aspx.cs" Inherits="ExamHandin3_CMS.EditorPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LabelMessages" runat="server"></asp:Label>
    <h2>Add new item</h2>
    <asp:TextBox ID="TextBoxHeadline" runat="server"></asp:TextBox>
<asp:Label ID="LabelHeadline" runat="server" Text="Headline"></asp:Label>
<br />
<asp:TextBox ID="TextBoxCategory" runat="server"></asp:TextBox>
<asp:Label ID="LabelCategory" runat="server" Text="Category"></asp:Label>
<br />
<asp:TextBox ID="TextBoxDescription" runat="server"></asp:TextBox>
<asp:Label ID="LabelDescription" runat="server" Text="Description"></asp:Label>
    <br />
    <asp:FileUpload ID="FileUploadImage" runat="server" />
<br />
<asp:TextBox ID="TextBoxImageURL" runat="server"></asp:TextBox>
<asp:Label ID="LabelImageURL" runat="server" Text="Image name"></asp:Label>
<br />
<asp:TextBox ID="TextBoxIsHighlighted" runat="server"></asp:TextBox>
<asp:Label ID="LabelIsHighlighted" runat="server" Text="Is highlighted?"></asp:Label>
<br />
<asp:Button ID="ButtonCreate" runat="server" OnClick="ButtonCreate_Click" Text="Create" />
<br />

    <h2>Update highlighted items</h2>
    <asp:GridView ID="GridViewItems" runat="server" EmptyDataText="No data yet" OnSelectedIndexChanged="GridViewItems_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <asp:Label ID="LabelUpdateInfo" runat="server"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxUpdateHighlight" runat="server"></asp:TextBox>
    <asp:Label ID="LabelSelectedInfo" runat="server" Text="Change item to be highlighted or not. 0 is not highlighted, 1 is highlighted."></asp:Label>

    <br />
    <asp:Button ID="ButtonUpdateHighlight" runat="server" OnClick="ButtonUpdateHighlight_Click" Text="Update" />

    <h1>Add a joke</h1>
        <asp:TextBox ID="TextBoxJokeQuestion" runat="server"></asp:TextBox>
        <asp:Label ID="LabelJokeQuestion" runat="server" Text="Question"></asp:Label>

    <br />
    <asp:TextBox ID="TextBoxJokeAnswer" runat="server"></asp:TextBox>
    <asp:Label ID="LabelJokeAnswer" runat="server" Text="Answer"></asp:Label>
    <br />
<asp:TextBox ID="TextBoxJokeFKID" runat="server"></asp:TextBox>
<asp:Label ID="LabelFKID" runat="server" Text="What item ID should match with this joke?"></asp:Label>
    <br />
    <asp:Button ID="ButtonJokeCreate" runat="server" OnClick="ButtonJokeCreate_Click" Text="Add joke" />

</asp:Content>

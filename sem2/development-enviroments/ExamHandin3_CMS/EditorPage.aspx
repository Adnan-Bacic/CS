<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditorPage.aspx.cs" Inherits="ExamHandin3_CMS.EditorPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
<asp:TextBox ID="TextBoxImageURL" runat="server"></asp:TextBox>
<asp:Label ID="LabelImageURL" runat="server" Text="Image URL"></asp:Label>
<br />
<asp:TextBox ID="TextBoxIsHighlighted" runat="server"></asp:TextBox>
<asp:Label ID="LabelIsHighlighted" runat="server" Text="Is highlighted?"></asp:Label>
<br />
<asp:Button ID="ButtonCreate" runat="server" OnClick="ButtonCreate_Click" Text="Create" />
<br />
    <asp:Label ID="LabelMessages" runat="server"></asp:Label>

    <asp:GridView ID="GridViewItems" runat="server">
    </asp:GridView>

    <hr />
</asp:Content>

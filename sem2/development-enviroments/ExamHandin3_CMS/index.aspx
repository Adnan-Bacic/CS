<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ExamHandin3_CMS.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div class="left">
    <h1>All items</h1>
        <asp:Label ID="LabelMessages" runat="server"></asp:Label>

        <asp:GridView ID="GridViewItems" runat="server">
            <Columns>
                <asp:ImageField DataImageUrlField="itemImageURL" DataImageUrlFormatString="~/ItemImages/{0}" HeaderText="Image for this item">
                </asp:ImageField>
            </Columns>
        </asp:GridView>
    <h1>Todays highlighted item(s)</h1>
    <asp:GridView ID="GridViewHighlight" runat="server">
        <Columns>
            <asp:ImageField DataImageUrlField="itemImageURL" DataImageUrlFormatString="~/ItemImages/{0}" HeaderText="Image for this item">
            </asp:ImageField>
        </Columns>
    </asp:GridView>
    </div>
    <div class="right">
    <h1>Jokes</h1>
        <asp:GridView ID="GridViewJokes" runat="server">
        </asp:GridView>
    </div>
        <div>
        <h1>Items and joke matching id</h1>
    <asp:GridView ID="GridViewMatch" runat="server">
        <Columns>
            <asp:ImageField DataImageUrlField="itemImageURL" DataImageUrlFormatString="~/ItemImages/{0}" HeaderText="Image for this item">
            </asp:ImageField>
        </Columns>
    </asp:GridView>
            </div>
    </div>
</asp:Content>

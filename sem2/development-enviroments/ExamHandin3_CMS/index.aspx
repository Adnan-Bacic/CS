<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ExamHandin3_CMS.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>index</h1>
    <style>
        img{
            width:200px;
        }
    </style>
        <asp:Label ID="LabelMessages" runat="server"></asp:Label>

        <asp:GridView ID="GridViewItems" runat="server">
            <Columns>
                <asp:ImageField DataImageUrlField="itemImageURL" DataImageUrlFormatString="~/ItemImages/{0}" HeaderText="Image for this item">
                </asp:ImageField>
            </Columns>
        </asp:GridView>
</asp:Content>

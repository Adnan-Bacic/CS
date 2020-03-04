<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ExamHandin3_CMS.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>index</h1>
        <asp:Label ID="LabelMessages" runat="server"></asp:Label>

        <asp:GridView ID="GridViewItems" runat="server">
        </asp:GridView>
</asp:Content>

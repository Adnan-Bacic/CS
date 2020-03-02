<%@ Page Title="Trains" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="handin3.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LabelMessages" runat="server"></asp:Label>
    
    <asp:GridView ID="GridViewTrains" runat="server" EmptyDataText="No data yet">
    </asp:GridView>
        
</asp:Content>

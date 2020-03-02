<%@ Page Title="Delete" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="handin3.delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="TextBoxDelayID" runat="server"></asp:TextBox>
    <asp:Label ID="LabelDelayID" runat="server" Text="What delay ID to delete?"></asp:Label>
    <br />
    <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Delete" />
    <br />
    <asp:Label ID="LabelMessages" runat="server"></asp:Label>
    <asp:GridView ID="GridViewTrains" runat="server" EmptyDataText="No data yet" OnSelectedIndexChanged="GridViewTrains_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <br />
    </asp:Content>

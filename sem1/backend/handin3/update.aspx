<%@ Page Title="Update" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="handin3.update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="TextBoxDelayID" runat="server"></asp:TextBox>
    <asp:Label ID="LabelDelayID" runat="server" Text="Which delay ID to update?"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxDelayAmount" runat="server"></asp:TextBox>
    <asp:Label ID="LabelDelayAmount" runat="server" Text="What is the new delay amount?"></asp:Label>
    <br />
    <asp:Button ID="ButtonUpdate" runat="server" OnClick="ButtonUpdate_Click" Text="Update" />
    <br />
    <asp:Label ID="LabelMessages" runat="server"></asp:Label>
    <asp:GridView ID="GridViewTrains" runat="server" EmptyDataText="No data yet" OnSelectedIndexChanged="GridViewTrains_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    </asp:Content>

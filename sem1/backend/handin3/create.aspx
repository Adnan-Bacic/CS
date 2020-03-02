<%@ Page Title="Create" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="create.aspx.cs" Inherits="handin3.create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="TextBoxDelayedID" runat="server"></asp:TextBox>
    <asp:Label ID="LabelDelayID" runat="server" Text="Delay ID"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxIsDelayed" runat="server"></asp:TextBox>
    <asp:Label ID="LabelIsDelayed" runat="server" Text="Is the train delayed? 1 for yes"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxDelayAmount" runat="server"></asp:TextBox>
    <asp:Label ID="LabelDelayAmount" runat="server" Text="How much is the train delayed?"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxFKStationID" runat="server"></asp:TextBox>
    <asp:Label ID="LabelFKStationID" runat="server" Text="Id of station which has a delay"></asp:Label>
    <br />
    <asp:Button ID="ButtonCreate" runat="server" OnClick="ButtonCreate_Click" Text="Create" />
    <br />
    <asp:Label ID="LabelMessages" runat="server"></asp:Label>
    <asp:GridView ID="GridViewTrains" runat="server" EmptyDataText="No data yet">
    </asp:GridView>
    </asp:Content>

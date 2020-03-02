<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SeeUsers.aspx.cs" Inherits="handin2.SeeUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>All users</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <h1>All users</h1>
            <div id="resultsAll">
                <div class="resultTraindriver">
                <h2>Train drivers:</h2>
                <asp:ListBox ID="ListBoxTrainDrivers" runat="server" Height="200px" Width="500px"></asp:ListBox>
                </div>
                <div class="resultAdmin">
                    <h2>Administrators:</h2>
                <asp:ListBox ID="ListBoxAdmins" runat="server" Height="200px" Width="500px"></asp:ListBox>
        </div>
                </div>
        <div id="btnFrontpage">
            <asp:Button ID="ButtonFrontPage" runat="server" PostBackUrl="~/index.aspx" Text="Back to frontpage" />
            </div>
</asp:Content>
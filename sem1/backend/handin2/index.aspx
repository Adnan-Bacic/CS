<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="handin2.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Trains</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <h1>Trains</h1>
        <asp:ListBox ID="ListBoxResults" runat="server" Height="243px" Width="1200px"></asp:ListBox>
        <div class="addNew">
        <div class="newTraindriver">
        <h2>Make a new traindriver</h2>
        <asp:TextBox ID="TrainDriverName" placeholder="Type here" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TrainDriverName" EnableClientScript="False" ErrorMessage="Must be filled out"></asp:RequiredFieldValidator>
        <asp:Label ID="Label1" runat="server" Text="Traindriver name"></asp:Label>
        <p>
            <asp:TextBox ID="TrainDriverAge" placeholder="Type here" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TrainDriverAge" EnableClientScript="False" ErrorMessage="Must be filled out"></asp:RequiredFieldValidator>
            <asp:Label ID="Label2" runat="server" Text="Traindriver age"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TrainDriverEmail" placeholder="Type here" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TrainDriverEmail" EnableClientScript="False" ErrorMessage="Must be filled out"></asp:RequiredFieldValidator>
            <asp:Label ID="Label3" runat="server" Text="Traindriver email"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TrainDriverLicense" placeholder="Type here" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TrainDriverLicense" EnableClientScript="False" ErrorMessage="Must be filled out"></asp:RequiredFieldValidator>
            <asp:Label ID="Label4" runat="server" Text="Traindriver license number"></asp:Label>
        </p>
        <asp:Button ID="ButtonTrainDriverCreate" runat="server" OnClick="ButtonTrainDriverCreate_Click" Text="Add traindriver" />
            </div>
        
        
        <div class="newAdmin">
        <h2>Make a new administrator</h2>
        <asp:TextBox ID="AdminName" placeholder="Type here" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="AdminName" EnableClientScript="False" ErrorMessage="Must be filed out"></asp:RequiredFieldValidator>
        <asp:Label ID="Label5" runat="server" Text="Admin name"></asp:Label>
        <p>
            <asp:TextBox ID="AdminAge" placeholder="Type here" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="AdminAge" EnableClientScript="False" ErrorMessage="Must be filed out"></asp:RequiredFieldValidator>
            <asp:Label ID="Label6" runat="server" Text="Admin age"></asp:Label>
        </p>
        <asp:TextBox ID="AdminEmail" placeholder="Type here" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="AdminEmail" EnableClientScript="False" ErrorMessage="Must be filed out"></asp:RequiredFieldValidator>
        <asp:Label ID="Label7" runat="server" Text="Admin Email"></asp:Label>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="AdminEmail" EnableClientScript="False" ErrorMessage="Email must end in @pig.dk" ValidationExpression=".*\.@pig.dk$">#</asp:RegularExpressionValidator>
        <p>
            <asp:TextBox ID="AdminID" placeholder="Type here" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="AdminID" EnableClientScript="False" ErrorMessage="Must be filed out"></asp:RequiredFieldValidator>
            <asp:Label ID="Label8" runat="server" Text="Admin ID"></asp:Label>
        </p>
        
        <asp:Button ID="ButtonAdminCreate" runat="server" OnClick="ButtonAdminCreate_Click" Text="Add administrator" />
            <asp:Button ID="ButtonChangeEmail" runat="server" OnClick="ButtonChangeEmail_Click" Text="Change email" />
        </div>
            
            </div>
        <div id="seeUsers">
            <asp:Button ID="ButtonSeeUsers" runat="server" PostBackUrl="~/seeUsers.aspx" Text="See all users" />
            <br />
            <asp:Label ID="LabelMessage" runat="server"></asp:Label>
            </div>
</asp:Content>

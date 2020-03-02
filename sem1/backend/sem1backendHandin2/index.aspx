<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="backendHandin2.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trains</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Test 2</h1>
        </div>
        <asp:ListBox ID="ListBoxResults" runat="server" Height="243px" Width="700px"></asp:ListBox>
        <h2>Make new traindriver</h2>
        <asp:TextBox ID="TrainDriverName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TrainDriverName" EnableClientScript="False" ErrorMessage="Must be filled out"></asp:RequiredFieldValidator>
        <asp:Label ID="Label1" runat="server" Text="Traindriver name"></asp:Label>
        <p>
            <asp:TextBox ID="TrainDriverAge" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TrainDriverAge" EnableClientScript="False" ErrorMessage="Must be filled out"></asp:RequiredFieldValidator>
            <asp:Label ID="Label2" runat="server" Text="Traindriver age"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TrainDriverEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TrainDriverEmail" EnableClientScript="False" ErrorMessage="Must be filled out"></asp:RequiredFieldValidator>
            <asp:Label ID="Label3" runat="server" Text="Traindriver email"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TrainDriverLicense" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TrainDriverLicense" EnableClientScript="False" ErrorMessage="Must be filled out"></asp:RequiredFieldValidator>
            <asp:Label ID="Label4" runat="server" Text="Traindriver license number"></asp:Label>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        
        <asp:Label ID="LabelMessage" runat="server"></asp:Label>
        
        <h2>Make a new administrator</h2>
        <asp:TextBox ID="AdminName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="AdminName" EnableClientScript="False" ErrorMessage="Must be filed out"></asp:RequiredFieldValidator>
        <asp:Label ID="Label5" runat="server" Text="Admin name"></asp:Label>
        <p>
            <asp:TextBox ID="AdminAge" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="AdminAge" EnableClientScript="False" ErrorMessage="Must be filed out"></asp:RequiredFieldValidator>
            <asp:Label ID="Label6" runat="server" Text="Admin age"></asp:Label>
        </p>
        <asp:TextBox ID="AdminEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="AdminEmail" EnableClientScript="False" ErrorMessage="Must be filed out"></asp:RequiredFieldValidator>
        <asp:Label ID="Label7" runat="server" Text="Admin Email"></asp:Label>
        <p>
            <asp:TextBox ID="AdminID" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="AdminID" EnableClientScript="False" ErrorMessage="Must be filed out"></asp:RequiredFieldValidator>
            <asp:Label ID="Label8" runat="server" Text="Admin ID"></asp:Label>
        </p>
        
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <p>
            <asp:Button ID="Button3" runat="server" PostBackUrl="~/seeUsers.aspx" Text="See all users" />
        </p>
        
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="validation.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validation</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelPage" runat="server" Font-Size="X-Large" Text="Page with validation"></asp:Label>
        </div>
        <asp:Label ID="LabelEnterData" runat="server" Text="Enter data"></asp:Label>
        <p>
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxName" EnableClientScript="False" ErrorMessage="Name is missing" ForeColor="Red">#</asp:RequiredFieldValidator>
            <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
        </p>
        <asp:TextBox ID="TextBoxAddress" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxAddress" EnableClientScript="False" ErrorMessage="Address is missing" ForeColor="Red">#</asp:RequiredFieldValidator>
        <asp:Label ID="LabelAddress" runat="server" Text="Address"></asp:Label>
        <p>
            <asp:TextBox ID="TextBoxZip" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxZip" EnableClientScript="False" ErrorMessage="Zip is missing" ForeColor="Red">#</asp:RequiredFieldValidator>
            <asp:Label ID="LabelZip" runat="server" Text="Zip"></asp:Label>
            <asp:RangeValidator ID="RangeValidatorZip" runat="server" ControlToValidate="TextBoxZip" EnableClientScript="False" ErrorMessage="Zip must be between 1000-9999" ForeColor="Red" MaximumValue="9999" MinimumValue="1000" Type="Integer"></asp:RangeValidator>
        </p>
        <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxPassword" EnableClientScript="False" ErrorMessage="Password is missing" ForeColor="Red">#</asp:RequiredFieldValidator>
        <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxPassword" EnableClientScript="False" ErrorMessage="Password must be between 4-8 characters" ForeColor="Red" ValidationExpression="^\w{4,8}"></asp:RegularExpressionValidator>
        <p>
            <asp:TextBox ID="TextBoxConfirmPassword" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxConfirmPassword" EnableClientScript="False" ErrorMessage="Password has not been confirmed" ForeColor="Red">#</asp:RequiredFieldValidator>
            <asp:Label ID="LabelConfirm" runat="server" Text="Confirm password"></asp:Label>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxConfirmPassword" EnableClientScript="False" ErrorMessage="Must match password" ForeColor="Red"></asp:CompareValidator>
        </p>
        <asp:TextBox ID="TextBoxBirthday" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxBirthday" EnableClientScript="False" ErrorMessage="Birthday is missing" ForeColor="Red">#</asp:RequiredFieldValidator>
        <asp:Label ID="LabelBirthday" runat="server" Text="Your birthday"></asp:Label>
        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TextBoxBirthday" EnableClientScript="False" ErrorMessage="Incorrect date format. Try &quot;/&quot;, &quot;.&quot; or &quot;-&quot; between dates" ForeColor="Red" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
        <p>
            <asp:Button ID="ButtonCreate" runat="server" Text="Create (but no acction here)" OnClick="ButtonCreate_Click" BackColor="Blue" BorderStyle="None" Font-Bold="True" ForeColor="White" />
        </p>
        <asp:Label ID="LabelMessage" runat="server"></asp:Label>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" BorderStyle="Double" ForeColor="Red" HeaderText="Errors on page:" />
    </form>
</body>
</html>

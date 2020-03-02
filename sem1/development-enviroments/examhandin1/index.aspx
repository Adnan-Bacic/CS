<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="examhandin1.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Sports club</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="container">
        <h1>Sports club</h1>
        <div class="textLeft">
            <p>We are a spots club for children aged 0-17. For many years we have helped
                children stay active and engaged in sports and other kinds of physcial 
                activities. We enjoy what we do and have ben doing this for over 50 years!
            </p>
        </div>
        <div class="textRight">
            <p>We have all kinds of activies here! Running, bicycling, swimming and weight
                lifting. For sports we have football, basketball, volleyball anf dodgeball.
                If you wish to sign you children up with use you can do so just below!
            </p>
        </div>
        <h2>Sign your child up to the club!</h2>
        <p>
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxName" EnableClientScript="False" ErrorMessage="Name must be filled out">#</asp:RequiredFieldValidator>
            <asp:Label ID="LabelName" runat="server" Text="Enter first name"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxLastName" EnableClientScript="False" ErrorMessage="Last name must be filled out">#</asp:RequiredFieldValidator>
            <asp:Label ID="LabelLastName" runat="server" Text="Enter last name"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBoxAge" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxAge" EnableClientScript="False" ErrorMessage="Age must be filled out">#</asp:RequiredFieldValidator>
            <asp:Label ID="LabelAge" runat="server" Text="Enter age"></asp:Label>
            <asp:RangeValidator ID="RangeValidatorAge" runat="server" ControlToValidate="TextBoxAge" EnableClientScript="False" ErrorMessage="We only accept kids from age 0-17" MaximumValue="17" MinimumValue="0" Type="Integer">#</asp:RangeValidator>
        </p>
        <p>
            <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxEmail" EnableClientScript="False" ErrorMessage="Email must be filled out">#</asp:RequiredFieldValidator>
            <asp:Label ID="LabelEmail" runat="server" Text="Enter email"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBoxEmailConfirm" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxEmailConfirm" EnableClientScript="False" ErrorMessage="Email confirmation must be filled out">#</asp:RequiredFieldValidator>
            <asp:Label ID="LabelEmailConfirm" runat="server" Text="Confirm email"></asp:Label>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="TextBoxEmail" ControlToValidate="TextBoxEmailConfirm" EnableClientScript="False" ErrorMessage="Must match email">#</asp:CompareValidator>
        </p>
        <p>
            <asp:TextBox ID="TextBoxBirthday" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxBirthday" EnableClientScript="False" ErrorMessage="Birthday must be filled out">#</asp:RequiredFieldValidator>
            <asp:Label ID="LabelBirthday" runat="server" Text="Enter birthday"></asp:Label>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBoxBirthday" EnableClientScript="False" ErrorMessage="Incorrect date format. Try &quot;/&quot;, &quot;.&quot; or &quot;-&quot; between numbers" Operator="DataTypeCheck" Type="Date">#</asp:CompareValidator>
        </p>
        <p>
            <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBoxPassword" EnableClientScript="False" ErrorMessage="Password must be filled out">#</asp:RequiredFieldValidator>
            <asp:Label ID="LabelPassword" runat="server" Text="Enter password(Only numbers and between 4 to 5 characters long)"></asp:Label>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxPassword" EnableClientScript="False" ErrorMessage="Password must be only numbers and between 4-5" ValidationExpression="^[0-9]{4,5}$">#</asp:RegularExpressionValidator>
        </p>
        <p>
            <asp:TextBox ID="TextBoxPasswordConfirm" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBoxPasswordConfirm" EnableClientScript="False" ErrorMessage="Password must be confirmed">#</asp:RequiredFieldValidator>
            <asp:Label ID="LabelPasswordConfirm" runat="server" Text="Confirm password"></asp:Label>
            <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxPasswordConfirm" EnableClientScript="False" ErrorMessage="Confirmed password must match password">#</asp:CompareValidator>
        </p>
        <p>
            <asp:Button ID="ButtonSignUp" runat="server" OnClick="ButtonSignUp_Click" Text="Sign up" />
        </p>
        <p>
            <asp:Label ID="LabelMessage" runat="server"></asp:Label>
        </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </div>
</asp:Content>

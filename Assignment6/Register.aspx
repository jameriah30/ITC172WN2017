<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Register</h1>
        <p>Lastname <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox> </p>
        <p>Firstname <asp:TextBox ID="FirstnameTextBox" runat="server"></asp:TextBox> </p>
        <p>Email <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox> </p>
        <p>Apartment <asp:TextBox ID="ApartmentTextBox" runat="server"></asp:TextBox> </p>
        <p>Street <asp:TextBox ID="StreetTextBox" runat="server"></asp:TextBox> </p>
        <p>City <asp:TextBox ID="CityTextBox" runat="server"></asp:TextBox> </p>
        <p>State <asp:TextBox ID="StateTextBox" runat="server"></asp:TextBox> </p>
        <p>ZipCode <asp:TextBox ID="ZipCodeTextBox1" runat="server"></asp:TextBox> </p>
        <p>HomePhone <asp:TextBox ID="HomePhoneTextBox" runat="server"></asp:TextBox> </p>
        <p>WorkPhone <asp:TextBox ID="WorkPhoneTextBox" runat="server"></asp:TextBox> </p>
        <p>Password <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox> </p>

        <p>
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
            <asp:Label ID="ResultLabel" runat="server" Text="Result"></asp:Label>
        </p>
        <asp:LinkButton ID="LoginLinkButton" runat="server" PostBackUrl="~/Default.aspx">LinkButton</asp:LinkButton>
    </div>
    </form>
</body>
</html>

﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GrantRequest.aspx.cs" Inherits="GrantRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grant Request</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Grant Types</h1>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>

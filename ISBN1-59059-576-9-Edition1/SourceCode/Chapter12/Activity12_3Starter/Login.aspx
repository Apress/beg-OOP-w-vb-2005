<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMessage" runat="server" Font-Size="Large" Style="z-index: 100;
            left: 173px; position: absolute; top: 72px" Text="You must login to create an order."
            Width="252px"></asp:Label>
        <asp:Label ID="Label1" runat="server" Style="z-index: 101; left: 97px; position: absolute;
            top: 118px" Text="User Name:" Width="99px"></asp:Label>
        <asp:Label ID="Label2" runat="server" Style="z-index: 102; left: 99px; position: absolute;
            top: 153px" Text="Password:" Width="98px"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" Style="z-index: 103; left: 222px; position: absolute;
            top: 116px" Width="139px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" Style="z-index: 104; left: 223px; position: absolute;
            top: 149px" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Style="z-index: 105; left: 170px; position: absolute;
            top: 208px" Text="Submit" />
        <asp:Button ID="btnCancel" runat="server" Style="z-index: 107; left: 267px; position: absolute;
            top: 208px" Text="Cancel" />
    
    </div>
    </form>
</body>
</html>

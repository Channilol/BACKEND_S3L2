<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="EsempioLogin.ProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <asp:Label ID="showUsername" runat="server" Text="Non sei loggato!"></asp:Label>
        <br />
        <asp:Button ID="logout" runat="server" Text="Logout" OnClick="logout_Click" />
    </form>
</body>
</html>
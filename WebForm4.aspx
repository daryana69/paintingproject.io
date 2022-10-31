

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication2.WebForm4" %>
<authentication mode="Forms">
    <forms cookieless="UseCookies" timeout="525600" />
</authentication>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Login ID="Login1" runat="server" InstructionText = "Please enter your user name and password." OnAuthenticate="Login1_Authenticate1" OnLoginError="Login1_LoginError1" RememberMeSet="True">
            </asp:Login>

            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>

        </div>
    </form>
</body>
</html>

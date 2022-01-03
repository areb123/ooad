<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Student_Managment_System.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
        <h1>Basic Student Managment System</h1>
        <h2>asp.net C# Project</h2>
        <hr />
        <div style="background-color:azure; height:117px; width:250px;">
        <table border="1">
            <tr>
                <td>Admin User Id</td>
                <td><asp:TextBox ID="TxtAdminId" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password</td>
                <td><asp:TextBox ID="TxtPwdAdmin" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="ButLogin" runat="server" Text="Login" OnClick="ButLogin_Click"></asp:Button></td>
                <td><asp:Label ID="Labmsg" runat="server" Text="" ForeColor="Red"></asp:Label></td>
            </tr>
        </table>
            </div>
    </center>
    </div>
    </form>
</body>
</html>

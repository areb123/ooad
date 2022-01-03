﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="StudentPage.aspx.cs" Inherits="Student_Managment_System.StudentPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is Student Page .. !</h1>
    <div style="background-color:azure; height:371px; width:360px;">
        <table border="1">
            <tr>
                <td>Student First Name</td>
                <td style="width: 231px">
                    <asp:TextBox ID="TxtStFname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Student Last Name</td>
                <td style="width: 231px">
                    <asp:TextBox ID="TxtStLname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Father Name</td>
                <td style="width: 231px">
                    <asp:TextBox ID="TxtFatherName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Father Phone</td>
                <td style="width: 231px">
                    <asp:TextBox ID="TxtFatherPhone" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Email</td>
                <td style="width: 231px">
                    <asp:TextBox ID="TxtStEmail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Phone</td>
                <td style="width: 231px">
                    <asp:TextBox ID="TxtPhone" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Course Name</td>
                <td style="width: 231px">
                    <asp:DropDownList ID="DDLCourseName" runat="server" AutoPostBack="True" AppendDataBoundItems="true" DataSourceID="SqlDataSource1" DataTextField="Cname" DataValueField="Cname" OnSelectedIndexChanged="DDLCourseName_SelectedIndexChanged">
                        <asp:ListItem Value="0" Text="-- Select Course --"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentManagmentSystemConnectionString2 %>" SelectCommand="SELECT [Cname] FROM [Coursetable]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>Course Fees</td>
                <td style="width: 231px">
                    <asp:Label ID="LabCourseFees" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Installment</td>
                <td style="width: 231px">
                    <asp:TextBox ID="TxtCourseInstallment" runat="server" AutoPostBack="true" OnTextChanged="TxtCourseInstallment_TextChanged"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Fees Due</td>
                <td style="width: 231px">
                    <asp:Label ID="LabDueFees" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Join Date</td>
                <td style="width: 231px">
                    <asp:Literal ID="LitJoindate" runat="server"></asp:Literal></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButStudent" runat="server" Text="Insert Record" OnClick="ButStudent_Click" /></td>
                <td style="width: 231px">
                    <asp:Label ID="Labmsg" runat="server" Text="" ForeColor="Green"></asp:Label></td>
            </tr>
        </table>

    </div>
</asp:Content>

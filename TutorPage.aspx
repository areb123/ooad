<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="TutorPage.aspx.cs" Inherits="Student_Managment_System.TutorPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is Tutor Page .. !</h1>
    <div style="background-color:azure; height:250px; width:290px;">
    <table border="1">
          <tr>
              <td>Tutor Name</td>
              <td>
                  <asp:TextBox ID="TxtTutorname" runat="server"></asp:TextBox></td>
          </tr>
          <tr>
              <td>Email</td>
              <td>
                  <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox></td>
         </tr>
         <tr>
              <td>Phone</td>
              <td>
                  <asp:TextBox ID="TxtPhone" runat="server"></asp:TextBox></td>
         </tr>
         <tr>
              <td>Course</td>
              <td>
                  <asp:Dropdownlist ID="DDLCourse" runat="server" Height="30px" DataSourceID="SqlDataSource1" AppendDataBoundItems ="true" DataTextField="Cname" DataValueField="Cname">
                     <asp:ListItem Value="0" Text="-- Select Courses --"></asp:ListItem>
                  </asp:Dropdownlist>

                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentManagmentSystemConnectionString %>" SelectCommand="SELECT [Cname] FROM [Coursetable]"></asp:SqlDataSource>
              </td>
         </tr>
        <tr>
            <td>Qualification</td>
            <td><asp:TextBox ID="TxtQualification" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Join Date</td>
            <td>
                <asp:Literal ID="LitJoinDate" runat="server"></asp:Literal></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="ButTutor" runat="server" Text="Insert" OnClick="ButTutor_Click" /></td>
            <td>
                <asp:Label ID="Labmsg" runat="server" Text="" ForeColor="Green"></asp:Label></td>
        </tr>
     </table> 
    </div>
</asp:Content>

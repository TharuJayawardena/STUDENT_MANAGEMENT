<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="STUDENT_MANAGEMENT.Pages.StudentRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-10 mx-auto">
            </div>
        </div>
        <div class="row">
            <div class="col">
                <center>
                    <h4>Student Registration</h4>
                </center>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <hr>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <label>StudentId</label>
                <div class="form-group">
                    <asp:TextBox CssClass="form-control shadow" Height="50px" ID="TxtStudentId" runat="server" placeholder="StudentId" required="true"/>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <label>FirstName</label>
                <div class="form-group">
                    <asp:TextBox CssClass="form-control shadow" Height="50px" ID="TxtFirstName" runat="server" placeholder="FirstName" required />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <label>LastName</label>
                <div class="form-group">
                    <asp:TextBox CssClass="form-control shadow" Height="50px" ID="TxtLastName" runat="server" placeholder="LastName" required></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <label>Address</label>
                <div class="form-group">
                    <asp:TextBox CssClass="form-control shadow" Height="50px" ID="TxtAddress" runat="server" placeholder="Address" required></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <label>Gender</label>
                <div class="form-group">
                    <asp:DropDownList class="form-control shadow" Height="50px" ID="DropDownGender" runat="server">
                        <asp:ListItem Text="Select" Value="select" />
                        <asp:ListItem Text="M" Value="M" />
                        <asp:ListItem Text="F" Value="F" />


                    </asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <label>NIC</label>
                <div class="form-group">
                    <asp:TextBox CssClass="form-control shadow" Height="50px" ID="TxtNic" runat="server" placeholder="NIC" required></asp:TextBox>
                </div>
            </div>
            <div class="col-md-12">
                <label>Email ID</label>
                <div class="form-group">
                    <asp:TextBox CssClass="form-control shadow" Height="50px" ID="TxtEmail" runat="server" placeholder="abc@gmail.com" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$" required="true" TextMode="Email"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <label>Nationality</label>
                <div class="form-group">
                    <asp:TextBox CssClass="form-control shadow" Height="50px" ID="TxtNationality" runat="server" placeholder="Nationality" required></asp:TextBox>
                </div>
            </div>
        </div> 
      <div class="row">
         <div class="col-md-12">
                <label>ContactNo</label>
                <div class="form-group">
                    <asp:TextBox CssClass="form-control shadow" Height="50px" ID="TxtContactNo" runat="server" placeholder="ContactNo" required></asp:TextBox>
                </div>
            </div>
        </div> 


         <div class="row mt-3">
            <div class="col">
                <div class="form-group">

                    <asp:Button class="btn btn-success btn-block btn-lg" ID="AddStudentBtn" runat="server" Text="Register" OnClick="AddStudentBtn_Click" />

                </div>
                <br />


            </div>
        </div> 


    
</asp:Content>

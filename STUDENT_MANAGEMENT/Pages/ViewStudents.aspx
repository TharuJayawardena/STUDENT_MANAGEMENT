<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewStudents.aspx.cs" Inherits="STUDENT_MANAGEMENT.Pages.ViewStudents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">

        <div class="col-md-25">
            <div class="card-md-25">
                <div class="card-body">

                    <div class="row print-container">
                        <div class="col">
                            <center>
                                <h4>Student Details</h4>
                            </center>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <hr>
                        </div>
                    </div>



                    <asp:GridView class="table table-striped table-bordered print-container" ID="StudentGridView"
                        DataKeyNames="StudentId"
                        OnPageIndexChanging="StudentGridView_PageIndexChanging"
                        OnRowCancelingEdit="StudentGridView_RowCancelingEdit"
                        OnRowDeleting="StudentGridView_RowDeleting"
                        OnRowEditing="StudentGridView_RowEditing"
                        OnRowUpdating="StudentGridView_RowUpdating"
                        runat="server" AutoGenerateColumns="False">

                        <Columns>
                            <asp:BoundField DataField="StudentId" HeaderText="Student Id" SortExpression="studentId" />
                            <asp:BoundField DataField="FirstName" HeaderText="First Name" SortExpression="firstName" />
                            <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="lastName" />
                            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="address" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="gender" />
                            <asp:BoundField DataField="NIC" HeaderText="NIC" SortExpression="Nic" />
                            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="email" />
                            <asp:BoundField DataField="Nationality" HeaderText="Nationality" SortExpression="nationality" />
                            <asp:BoundField DataField="ContactNo" HeaderText="Contact No" SortExpression="contactNo" Visible="false" />
                            <asp:CommandField ShowEditButton="true" />
                            <asp:CommandField ShowDeleteButton="true" />
                            <asp:TemplateField HeaderText="Contact No">
                                <ItemTemplate>
                                   <%--<asp:LinkButton ID="BtnOpenContactNoModel" OnClick="BtnOpenContactNoModel_Click">View</asp:LinkButton>--%>
                                    <asp:LinkButton runat="server" ID="BtnOpenContactNoModel" 
                                        class="btn btn-primary" 
                                        OnClick="BtnOpenContactNoModel_Click">View</asp:LinkButton>
 
                                </ItemTemplate>
                            </asp:TemplateField>

                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>


    <!-- Modal -->
    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">

                    <asp:Panel ID="ContactPanel" runat="server">

                    </asp:Panel>
                   

                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary">Save changes</button>
                </div>
            </div>
        </div>
    </div>





    <%--<div id="mypop" style="display:none">
          <br />
          <div style="text-align:right">

            <p>ContactNo 1:<asp:TextBox ID="contactno1" runat="server"></asp:TextBox></p>
            <p>ContactNo 2:<asp:TextBox ID="contactno2" runat="server"></asp:TextBox></p>
            <p>ContactNo 3:<asp:TextBox ID="contactno3" runat="server"></asp:TextBox></p>
            <p>ContactNo 4:<asp:TextBox ID="contactno4" runat="server"></asp:TextBox></p>
           

           </div>

        </div>--%>

    
</asp:Content>

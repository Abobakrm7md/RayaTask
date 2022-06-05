<%@ Page Title="Employee" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"
    CodeBehind="Employees.aspx.cs" Inherits="Raya.Employee.Forms.Employees" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="mainContainer" class="container">
        <div class="shadowBox">
            <div class="page-container">
                <div class="container">
                    <div class="jumbotron" style="align-content: center; align-items: center; text-align: center">
                         <img style="max-width: 500px; margin-top: -7px;" src="/Content/Images/logo.png">
                        <p class="text-info">Empolyees </p>
                    </div>
                    <div class="row">
                        <div class="col-lg-12 ">
                            <div class="table-responsive">
                                <asp:GridView ID="grdEmployee" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="EmployeeID" EmptyDataText="There are no data records to display.">
                                    <Columns>
                                        <%--  <asp:BoundField DataField="EmployeeId" HeaderText="EmployeeId" ReadOnly="True" SortExpression="EmployeeId" />--%>
                                        <asp:BoundField DataField="EmpName" HeaderText="EmpName" SortExpression="EmpName" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" />
                                        <asp:BoundField DataField="CreatedDate" HeaderText="CreatedDate" SortExpression="CreatedDate" ItemStyle-CssClass="visible-xs" HeaderStyle-CssClass="visible-xs" />
                                        <asp:BoundField DataField="ModifiedDate" HeaderText="ModifiedDate" SortExpression="ModifiedDate" HeaderStyle-CssClass="visible-md" ItemStyle-CssClass="visible-md" />
                                        <asp:BoundField DataField="CreateBy" HeaderText="CreateBy" SortExpression="CreateBy" HeaderStyle-CssClass="visible-md" ItemStyle-CssClass="visible-md" />
                                        <asp:BoundField DataField="ModifiedBy" HeaderText="ModifiedBy" SortExpression="ModifiedBy" HeaderStyle-CssClass="visible-md" ItemStyle-CssClass="visible-md" />
                                        <asp:BoundField DataField="BirthDate" HeaderText="BirthDate" SortExpression="BirthDate" HeaderStyle-CssClass="visible-md" ItemStyle-CssClass="visible-md" />
                                        <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" />
                                        <asp:BoundField DataField="HireDate" HeaderText="HireDate" SortExpression="HireDate" HeaderStyle-CssClass="visible-md" ItemStyle-CssClass="visible-md" />
                                        <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" />
                                        <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" />
                                        <asp:BoundField DataField="Confirmed" HeaderText="Status" SortExpression="Confirmed" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" />
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="EmpSelected" Text="Select" runat="server"
                                                    CommandArgument='<%# Eval("EmployeeId") %>' OnClick="EmpSelected_Click"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>


                    <div class="panel panel-default">
                        <div class="panel-heading">Add employee</div>
                        <div class="panel-body">
                            <div>
                                <asp:TextBox ID="EmpId" runat="server" Visible="false" Width="282px"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Label runat="server" CssClass="col-md-2 control-label">Name</asp:Label>
                                <div class="col-md-10">
                                    <asp:TextBox runat="server" ID="txt_Name" CssClass="form-control" />
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_Name"
                                        CssClass="text-danger" ErrorMessage="The user name field is required." />
                                </div>
                            </div>
                            <div class="form-group">
                                <asp:Label runat="server" CssClass="col-md-2 control-label">Address</asp:Label>
                                <div class="col-md-10">
                                    <asp:TextBox runat="server" ID="txt_Address" CssClass="form-control" />
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_Address" CssClass="text-danger" ErrorMessage="The address field is required." />
                                </div>
                            </div>
                            <div class="form-group">
                                <asp:Label runat="server" CssClass="col-md-2 control-label">Phone</asp:Label>
                                <div class="col-md-10">
                                    <asp:TextBox runat="server" ID="txt_Phone" CssClass="form-control" />
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_Phone" CssClass="text-danger" ErrorMessage="The phone field is required." />
                                </div>
                            </div>
                            <br />
                            <div class="form-group">
                                <asp:Label runat="server" CssClass="col-md-2 control-label">Department</asp:Label>
                                <div class="col-md-10">
                                    <asp:DropDownList ID="dept" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="dept" CssClass="text-danger" ErrorMessage="The deparment field is required." />
                                </div>
                            </div>
                            <br />
                            <div class="form-group">
                                <asp:Label runat="server" CssClass="col-md-2 control-label">Hire Data</asp:Label>
                                <div class="col-md-10">
                                    <asp:TextBox ID="HireDate" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="HireDate" CssClass="text-danger" ErrorMessage="The Hire Date field is required." />
                                </div>
                            </div>
                            <br />
                            <div class="form-group">
                                <asp:Label runat="server" CssClass="col-md-2 control-label">Birth Date</asp:Label>
                                <div class="col-md-10">
                                    <asp:TextBox ID="BirthDate" runat="server" TextMode="Date"  CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="BirthDate" CssClass="text-danger" ErrorMessage="The Birth Date field is required." />
                                </div>
                            </div>
                            <br />
                            <br />
                            <div id="dvMessage" runat="server" visible="false" class="alert alert-danger">
                                <strong>Error!</strong>
                                <asp:Label ID="lblMessage" runat="server" />
                            </div>
                        </div>
                    </div>

                    <br />
                    <asp:Button ID="Reset" Text="Reset" runat="server" Class="btn btn-primary" OnClick="Reset_Click" />
                    <asp:Button ID="AddNew" Text="AddNew" runat="server" Class="btn btn-primary" OnClick="AddNew_Click" />
                    <asp:Button ID="Update" Text="Update" runat="server" Class="btn btn-primary" OnClick="Update_Click" />
                    <asp:Button ID="Delete" Text="Delete" runat="server" Class="btn btn-danger" OnClick="Delete_Click" />
                    <asp:Button ID="Confirm" Text="Confirm" runat="server" Class="btn btn-primary" OnClick="Confirm_Click" />

                </div>
            </div>
        </div>
    </div>

</asp:Content>

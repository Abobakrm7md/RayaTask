<%@ Page Title="Employee" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"
    CodeBehind="Employees.aspx.cs" Inherits="Raya.Employee.Forms.Employees" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="mainContainer" class="container">
        <div class="shadowBox">
            <div class="page-container">
                <div class="container">
                    <div class="jumbotron" style="align-content: center; align-items: center; text-align: center">
                        <img style="height: 150px; width: 60%;" src="../Content/Images/raya2.jpg" />
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
                                        <asp:BoundField DataField="Confirmed" HeaderText="Confirmed" SortExpression="Confirmed" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" />                                    
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
                    <div>
                        <div>
                            &nbsp;<asp:TextBox ID="EmpId" runat="server" Visible="false" Width="282px"></asp:TextBox>
                        </div>
                        <div>
                            <label for="Name">Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>
                            &nbsp;<asp:TextBox ID="Name" runat="server" Width="282px"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <label>Address</label>
                            <asp:TextBox ID="Address" runat="server" Width="277px"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <label>Phone&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>
&nbsp;<asp:TextBox ID="Phone" runat="server" Width="272px"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <label>DepartMent</label>
                            <asp:DropDownList ID="dept" runat="server" Width="255px">
                            </asp:DropDownList>
                        </div>
                        <br />
                        <div>
                            <label>Hire Data</label>
                            <asp:TextBox ID="HireDate" runat="server" TextMode="Date" Width="262px"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <label>Birth Date</label>
                            <asp:TextBox ID="BirthDate" runat="server" TextMode="Date" Width="252px"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <asp:Button ID="Reset" Text="Reset" runat="server" Class="btn btn-primary" OnClick="Reset_Click"  />
                    <asp:Button ID="AddNew" Text="AddNew" runat="server" Class="btn btn-primary" OnClick="AddNew_Click" />
                    <asp:Button ID="Update" Text="Update" runat="server" Class="btn btn-primary" OnClick="Update_Click" />
                    <asp:Button ID="Delete" Text="Delete" runat="server" Class="btn btn-danger" OnClick="Delete_Click" />
                    <asp:Button ID="Confirm" Text="Confirm" runat="server" Class="btn btn-primary" OnClick="Confirm_Click" />

                </div>
            </div>
        </div>
    </div>

</asp:Content>

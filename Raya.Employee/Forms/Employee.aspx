<%@ Page Title="Employee" Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master"
    CodeBehind="Employee.aspx.cs" Inherits="Raya.Employee.Forms.Employee" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div id="mainContainer" class="container">  
            <div class="shadowBox">  
                <div class="page-container">  
                    <div class="container">  
                        <div class="jumbotron" style="align-content:center;align-items:center;text-align:center">  
                            <img style="height:150px;width:60%;" src="../Content/Images/raya2.jpg" />
                            <p class="text-info">Empolyees </p>  
                        </div>  
                        <div class="row">  
                            <div class="col-lg-12 ">  
                                <div class="table-responsive">  
                                    <asp:GridView ID="grdEmployee" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="EmployeeID" EmptyDataText="There are no data records to display.">  
                                        <Columns>  
                                            <asp:BoundField DataField="EmployeeId" HeaderText="EmployeeId" ReadOnly="True" SortExpression="EmployeeId" />  
                                            <asp:BoundField DataField="EmpName" HeaderText="EmpName" SortExpression="EmpName" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" />  
                                            <asp:BoundField DataField="CreatedDate" HeaderText="CreatedDate" SortExpression="CreatedDate" ItemStyle-CssClass="visible-xs" HeaderStyle-CssClass="visible-xs" />  
                                            <asp:BoundField DataField="ModifiedDate" HeaderText="ModifiedDate" SortExpression="ModifiedDate" HeaderStyle-CssClass="visible-md" ItemStyle-CssClass="visible-md" />  
                                            <asp:BoundField DataField="CreateBy" HeaderText="CreateBy" SortExpression="CreateBy" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />  
                                            <asp:BoundField DataField="ModifiedBy" HeaderText="ModifiedBy" SortExpression="ModifiedBy" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs" />  
                                            <asp:BoundField DataField="BirthDate" HeaderText="BirthDate" SortExpression="BirthDate" HeaderStyle-CssClass="visible-md" ItemStyle-CssClass="visible-md" />  
                                            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" />  
                                            <asp:BoundField DataField="HireDate" HeaderText="HireDate" SortExpression="HireDate" HeaderStyle-CssClass="visible-md" ItemStyle-CssClass="visible-md" />  
                                            <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" />  
                                            <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" />                                         
                                        </Columns>  
                                    </asp:GridView>  
                                </div>  
                            </div>  
                        </div>  
                         <div>  
            <table class="auto-style1">  
                <tr>  
                    <td>Name :</td>  
                    <td>  
                        <asp:TextBox ID="Name" runat="server"></asp:TextBox>  
                    </td>  
  
               </tr>  
                
                <tr>  
                    <td>Address</td>  
                     <td> <asp:TextBox ID="Address" runat="server"></asp:TextBox></td>  
                </tr>  

                <tr>  
                    <td>Phone</td>  
                    <td>  
                        <asp:TextBox ID="Phone" runat="server" ></asp:TextBox>  
                    </td>  
                </tr>  
                
                <tr>  
                    <td>DepartMent</td>  
                    <td>  
                        <asp:DropDownList ID="dept" runat="server">  
                            <asp:ListItem Text="Select Department" Value="select" Selected="True"></asp:ListItem>  
                           <%-- <asp:ListItem Text="Bangalore" Value="Bangalore"></asp:ListItem>  
                            <asp:ListItem Text="Mysore" Value="Mysore"></asp:ListItem>  
                            <asp:ListItem Text="Hubli" Value="hubli"></asp:ListItem>  --%>
                        </asp:DropDownList>  
                    </td>  
                </tr>    
            </table>  
        </div>  
                        <br />
                        <asp:Button ID="AddNew" Text="AddNew" runat="server" Class="btn btn-primary" OnClick="AddNew_Click" />
                        <asp:Button ID="Update" Text="Update" runat="server" Class="btn btn-primary"  />
                        <asp:Button ID="Delete" Text="Delete" runat="server" Class="btn btn-primary" />
                        <asp:Button ID="Confirm" Text="Confirm" runat="server" Class="btn btn-primary"  />

                    </div>  
                </div>  
            </div>  
        </div>  

</asp:Content>

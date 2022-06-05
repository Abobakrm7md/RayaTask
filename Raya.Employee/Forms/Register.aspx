<%@ Page Title="Register" Language="C#" AutoEventWireup="true"   MasterPageFile="~/Site.Master" CodeBehind="Register.aspx.cs" Inherits="Raya.Employee.Forms.Register" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p> 
     <h3>  <label class="label label-info"> Create a new account </label></h3>
            <hr />
    <div class="form-Horizental">
        <div class="form-horizontal">           
            <asp:ValidationSummary runat="server" CssClass="text-danger" />

            <div class="panel panel-default">
                <div class="panel-heading">Register information</div>
                <div class="panel-body">


                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtboxFirstName" CssClass="col-md-2 control-label">First Name</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtboxFirstName" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                                CssClass="text-danger" ErrorMessage="The Firs Name field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtboxSecondeName" CssClass="col-md-2 control-label">Second Name</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtboxSecondeName" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                                CssClass="text-danger" ErrorMessage="The Seconde Name field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="UserName" CssClass="col-md-2 control-label">UserName</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="UserName" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                                CssClass="text-danger" ErrorMessage="The user name field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtPassword" CssClass="col-md-2 control-label">Password</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword"
                                CssClass="text-danger" ErrorMessage="The password field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtConfirmPassword" CssClass="col-md-2 control-label">Confirm password</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtConfirmPassword"
                                CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                            <asp:CompareValidator runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword"
                                CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="TxtBoxEmail" CssClass="col-md-2 control-label">Email</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="TxtBoxEmail" CssClass="form-control" />
                            <asp:RegularExpressionValidator ID="TxtEmailRegEx" runat="server"
                                ErrorMessage="Please enter a valid email address "
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="TxtBoxEmail" />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="TxtBoxPhoneNumber" CssClass="col-md-2 control-label">Phone Number</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="TxtBoxPhoneNumber" MaxLength="11" CssClass="form-control" />
                            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" TargetControlID="TxtBoxPhoneNumber" FilterType="Numbers" />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="IsAdmin" CssClass="col-md-2 control-label">Is admin</asp:Label>
                        <div class="col-md-10">
                             <asp:DropDownList id="IsAdmin" runat="server"  CssClass="form-control" >
                              <asp:ListItem Selected="True" Value="True"> True </asp:ListItem>
                              <asp:ListItem Value="False"> False </asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                      <div id="dvMessage" runat="server" visible="false" class="alert alert-danger">
                        <strong>Error!</strong>
                        <asp:Label ID="lblMessage" runat="server" />
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button ID="CreateUser" runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-primary" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

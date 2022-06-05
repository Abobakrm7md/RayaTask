<%@ Page Title="Login to Raya Employee"  Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.cs" Inherits="Raya.Employee.Forms.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h2><label class="label label-info"> <%: Title %>. </label></h2>                    
                    <hr />
    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">

                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">

                    </asp:PlaceHolder>
                    <div class="panel panel-default">
                        <div class="panel-heading">Register information</div>
                        <div class="panel-body">
                            <div class="form-group">
                                <asp:Label runat="server" CssClass="col-md-2 control-label">Email</asp:Label>
                                <div class="col-md-10">
                                    <asp:TextBox runat="server" ID="txt_Email" CssClass="form-control" />
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_Email"
                                        CssClass="text-danger" ErrorMessage="The email field is required." />
                                </div>
                            </div>
                            <div class="form-group">
                                <asp:Label runat="server" CssClass="col-md-2 control-label">Password</asp:Label>
                                <div class="col-md-10">
                                    <asp:TextBox runat="server" ID="txt_Password" TextMode="Password" CssClass="form-control" />
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_Password" CssClass="text-danger" ErrorMessage="The password field is required." />
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-offset-2 col-md-10">
                                    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Log in" CssClass="btn btn-primary" />
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
                </div>
            </section>
        </div>
    </div>
</asp:Content>

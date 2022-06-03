<%@ Page Title="Login" Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.cs" Inherits="Raya.Employee.Forms.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<%--        <script type="text/javascript" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
        <script type="text/javascript" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
        <link rel="stylesheet" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css'
            media="screen" />--%>
        <div style="max-width: 4000px;margin-left:auto;margin-right:auto;">
            <h2 class="form-signin-heading">Login</h2>
            <label for="txtUsername">
                Username</label>
            <asp:TextBox ID="txt_Email" runat="server" CssClass="form-control" placeholder="Enter Username"
                required="true" />
            <br />
            <label for="txtPassword">
                Password</label>
            <asp:TextBox ID="txt_Password" runat="server" TextMode="Password" CssClass="form-control"
                placeholder="Enter Password" required="true" />
            <br />
            <asp:Button ID="btnLogin" Text="Login" runat="server" Class="btn btn-primary" OnClick="btnLogin_Click" />
            <br />
            <br />
            <div id="dvMessage" runat="server" visible="false" class="alert alert-danger">
                <strong>Error!</strong>
                <asp:Label ID="lblMessage" runat="server" />
            </div>
        </div>
</asp:Content>
<%@ Page Title="Error" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Error.aspx.cs" Inherits="Raya.Employee.Forms.Errors.Error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />

    <div class="row">
        <div id="dvMessage" runat="server" visible="true" class="alert alert-danger">
            <strong>Error!</strong>
            <asp:Label ID="lblMessage" runat="server" Text="Something bad occured so ,try again or contact with responsible person " />
            <asp:Label ID="Logs" runat="server" Text="Exceptions logs exist in logs.log " />

        </div>
    </div>
</asp:Content>

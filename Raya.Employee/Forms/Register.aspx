<%@ Page Title="Register" Language="C#" AutoEventWireup="true"  
    MasterPageFile="~/Site.Master" CodeBehind="Register.aspx.cs" Inherits="Raya.Employee.Forms.Register" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h4 style="font-size: medium">Register a new user</h4>
        <hr />
        <p>
            <asp:Literal runat="server" ID="StatusMessage" />
        </p>                
        <div style="margin-bottom:10px">
            <asp:Label runat="server" AssociatedControlID="Email">Email</asp:Label>
            <div>
                <asp:TextBox runat="server" ID="Email" />                
            </div>
        </div>
        <div style="margin-bottom:10px">
            <asp:Label runat="server" AssociatedControlID="Password">Password</asp:Label>
            <div>
                <asp:TextBox runat="server" ID="Password" TextMode="Password" />                
            </div>
        </div>
        <div style="margin-bottom:10px">
            <asp:Label runat="server" AssociatedControlID="ConfirmPassword">Confirm password</asp:Label>
            <div>
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" />                
            </div>
        </div>
        <div style="margin-bottom:10px">
            <asp:Label runat="server" AssociatedControlID="IsAdmin">Admin</asp:Label>
            <div>
            <asp:Label runat="server" AssociatedControlID="IsAdmin">IsAdmin</asp:Label>

                 <asp:DropDownList id="IsAdmin" runat="server">

                  <asp:ListItem Selected="True" Value="True"> True </asp:ListItem>
                  <asp:ListItem Value="False"> False </asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div>
            <div>
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" />
            </div>
        </div>
    </div>

</asp:Content>
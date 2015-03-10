<%@ Page Title="" Language="C#" MasterPageFile="~/WithNav.Master" AutoEventWireup="true" CodeBehind="NewAdminOrCommite.aspx.cs" Inherits="Capstone2.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container-fluid">
        <div class="row" style ="margin-top: 2%; position: relative ">
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
                    <h1  class="page-header">Add Committe Member or Admin</h1>
        </div>           
        </div>
        </div>
        <div class="col-lg-3 cl-md-6">
            </div>
    <div class="col-lg-6 col-md-6">
            <div class="panel panel-default" style="min-width: 275px; width: 100%; margin-left: auto; margin-right: auto">
                <div style="font-weight: bold" class="panel-heading">
                   Add Admin/Committe Form
                </div>
               
                <div class="panel-body" style="color: black; position: relative">
                    
                    <div class="col-lg-12 col-md-6">   
                     Which kind of user would you like to add?<br />
                        <asp:RadioButtonList ID="rblUsers" runat="server" style="margin-top: 10px" class="radioButtonList" RepeatDirection="Horizontal">
                            <asp:ListItem>Administrator</asp:ListItem>
                            <asp:ListItem>Committee Member</asp:ListItem>
                        </asp:RadioButtonList>            
                    </div>

                    <div class="col-lg-6 col-md-6" style="margin-top: 10px" >
                    <asp:Label ID="StarLabel" runat="server" Text="* " Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label><asp:Label ID="FirstNameLabel" runat="server" Text="First Name:" ></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="FirstNameTextBox" runat="server" style="width: 100%; margin-top:10px; margin-bottom: 20px; position: relative"></asp:TextBox>
                    </div>        
                    
                    <div class="col-lg-6 col-md-6" style="margin-top: 10px" >
                    <asp:Label ID="StarLabel1" runat="server" Text="* " Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label><asp:Label ID="LastNameLabel" runat="server" Text="Last Name:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="LastNameTextBox" runat="server" style="width: 100%; margin-top:10px; margin-bottom: 20px; position: relative"></asp:TextBox>
                    </div>
                   
                    <div class="col-lg-6 col-md-6"> 
                    <asp:Label ID="StarLabel2" runat="server" Text="* " Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label><asp:Label ID="EmailLabel" runat="server" Text="Email:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="EmailTextBox" runat="server" style="width: 100%; margin-top:10px; margin-bottom: 20px; position: relative"></asp:TextBox>
                    </div>

                    <div class="col-lg-6 col-md-6">
                    <asp:Label ID="StarLabel3" runat="server" Text="* " Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label><asp:Label ID="DepartmentLabel" runat="server" Text="Department:"></asp:Label>
                    <asp:DropDownList class="form-control" ID="HealthScholarsDropDownList" runat="server" style="width:100%; margin-top:10px; margin-bottom: 20px; position: relative">
                    <asp:ListItem Value="Select"></asp:ListItem>
                    <asp:ListItem Value="Computer Science"></asp:ListItem>
                    </asp:DropDownList>
                    </div>
                    
                    <div class="col-lg-4 col-md-6" style="width: 66%">
                     </div>
                    <div class="col-lg-4 col-md-6">
                    <asp:Button class="btn btn-default" ID="AddUserButton" runat="server" Text="Add User" style="width: 100%; margin-bottom: 10px; margin-top: 10px" BackColor="#9E1B34" ForeColor="White" BorderColor="#9E1B34" />                     
                    </div>
                    </div>
                </div>
            </div>
    
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/NoNav1.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Capstone2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
          
        <div class="row" style ="position: relative ">
           
            <div class="container-fluid" style="position: relative">
                <div class="col-xs-12">
                    
                </div>
            <div class="col-xs-12"style="margin-top: 3%">       
             <asp:Label ID="MessageLabel" runat="server" Visible="false" style=" display: block; width: 50%; margin-left: auto; font-size:medium; font-weight: bold; color: red; margin-right: auto; min-width: 275px" ></asp:Label>
            <div class="panel panel-default" style="width: 50%; margin-top: 5px; margin-left: auto; margin-right: auto; min-width: 275px">
               
                 <div style="font-weight: bold" class ="panel-heading">
                    Please Login:
                </div>
                <div class="panel-body" style="color: black; position: relative; height: 260px">



                    <asp:TextBox CssClass="form-control" ID="UserIdTextBox" runat="server" placeholder="AccessNet Username" Style="top: 30px; width: 80%; left: 10%; position: relative"></asp:TextBox>


                    <asp:TextBox CssClass="form-control" ID="PasswordTextBox" runat="server" TextMode="Password" placeholder="Password" Style="top: 50px; width: 80%; left: 10%; position: relative"></asp:TextBox>


                    <asp:Button class="btn btn-default" ID="LoginButton" OnClick="btnLogin_Click" runat="server" Text="Log In" Style="top: 70px; left: 10%; width: 80%; position: relative" BackColor="#9E1B34" ForeColor="White" BorderColor="#9E1B34" />
                    <asp:LinkButton ID="ForgotPasswordLinkButton" runat="server" OnClick="ForgotPassword_Click" Style="top: 90px; left: 10%; position: relative; float: left;" ForeColor="#0645AD">Forgot Password?</asp:LinkButton>




                </div>
            </div> 
        </div>
    </div>
</div>
</div>


</asp:Content>

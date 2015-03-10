<%@ Page Title="" Language="C#" MasterPageFile="~/WithNav.Master" AutoEventWireup="true" CodeBehind="SendEmail.aspx.cs" Inherits="Capstone2.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container-fluid">
        
    <div class="row">
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
                    <h1 class="page-header">Send Email</h1>
        </div>           
                
        
    </div>
    <div class="row" style ="position: relative">
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <asp:Label Style="font-weight: bold" ID="Label1" runat="server" Text="Send Email to Students"></asp:Label>
                </div>
                <div class="panel-body" style="color:black">
                    
                <div class="col-lg-12 col-md-6">   
                     <asp:Label ID="TypeOfEmailLabel" runat="server" Text="Type of Email:" ></asp:Label>
                        <asp:RadioButtonList ID="rblUsers" runat="server" style="margin-top: 10px" class="radioButtonList" RepeatDirection="Horizontal">
                            <asp:ListItem>Acceptance Email</asp:ListItem>
                            <asp:ListItem>Rejection Email</asp:ListItem>
                        </asp:RadioButtonList>            
                        </div>
                    
                    <div class="col-lg-12">
                    <asp:TextBox CssClass="form-control" ID="EmailTextBox" runat="server" TextMode="MultiLine" style="width: 100%; height: 200px; margin-top:20px; position: relative"></asp:TextBox>
                    </div>
                    
                    <div class="col-lg-4 col-md-6" style="width: 66%">
                    <span>
                    <input  type="file" 
                    style="visibility:hidden; width: 1px;" 
                    id='${multipartFilePath}' name='${multipartFilePath}'  
                    onchange="$(this).parent().find('span').html($(this).val().replace('C:\\fakepath\\', ''))"  /> <!-- Chrome security returns 'C:\fakepath\'  -->
                    <input style="border-color: #9E1B34 " class="btn btn-default" type="button" value="Upload Email" onclick="$(this).parent().find('input[type=file]').click();"/> <!-- on button click fire the file click event -->
                    &nbsp;
                    <span  class="badge badge-important" ></span>
                    </span>
                    </div>
                    
                    <div class="col-lg-4 col-md-6">
                    <asp:Button ID="SendButton" class="btn btn-primary" style="margin-top: 25px; width: 100%; background-color:#9E1B34" runat="server" Text="Send" />
                    </div>
                </div>
            </div>
        </div>

    </div>
    </div>

</asp:Content>

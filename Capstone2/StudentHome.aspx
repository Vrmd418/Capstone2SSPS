<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="Capstone2.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container-fluid">
    
    <div class="row">
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
                    <h1 class="page-header">Student Home</h1>
    </div>           
</div>

    <div class="row" style ="position: relative ">
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
            <div class="panel panel-default" style="margin-left: auto; margin-right: auto; min-width: 275px; position: relative">
                <div style="font-size: medium; font-weight: bold" class="panel-heading">
                    Student Home
                </div>
                <div class="panel-body" style="color: black">
                    <p style="margin-top: 10px; font-size:medium" >Starting a new application? <a style="color: blue" href="FreshmanApp.aspx"> Click Here!</a></p>
                    
                    <p style="margin-top: 10px; font-size:medium">Existing application? <a style="color: blue" href="FreshmanApp.aspx"> Click Here! </a></p>
                </div>
            </div>
        </div>
    </div>

        
     </div>

</asp:Content>

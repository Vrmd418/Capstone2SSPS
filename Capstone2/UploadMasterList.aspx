<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="UploadMasterList.aspx.cs" Inherits="Capstone2.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container-fluid">
    <div class="row">
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
                    <h1 class="page-header">Upload Cognos Report</h1>
        </div>           
                
        
    </div>
        
        <div class="row" style ="position: relative ">
        
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
            <div style="width:100%" class="panel panel-default" >
                <div style="font-weight: bold" class="panel-heading">
                    Upload Cognos Report
                </div>
                <div class="panel-body" style="color: black">
                    
                    <asp:Label ID="AcademicYearLabel" runat="server" Text="Academic Year" style="left: 2%; position:relative"></asp:Label>
                    <asp:DropDownList class="form-control" ID="AcademicYearList" runat="server" style="width:97%; margin-top:10px; margin-bottom: 0px; margin-left: auto; margin-right: auto; position: relative">
                    <asp:ListItem Value="2014-2015"></asp:ListItem>
                    </asp:DropDownList>
                    
                    
                    <div class="col-lg-4 col-md-6" style="width: 66%">
                    <span>
                    <input  type="file" 
                    style="visibility:hidden; width: 1px;" 
                    id='${multipartFilePath}' name='${multipartFilePath}'  
                    onchange="$(this).parent().find('span').html($(this).val().replace('C:\\fakepath\\', ''))"  /> <!-- Chrome security returns 'C:\fakepath\'  -->
                    <input style="border-color:#9E1B34 " class="btn btn-default" type="button" value="Chose File" onclick="$(this).parent().find('input[type=file]').click();"/> <!-- on button click fire the file click event -->
                    &nbsp;
                    <span  class="badge badge-important" ></span>
                    </span>
                    </div>
                    
                    <div class="col-lg-4 col-md-6">
                    <asp:Button ID="UploadButton" class="btn btn-primary" style="margin-top: 20px; width: 100%; background-color:#9E1B34" runat="server" Text="Submit" />
                    </div>
                    
                 </div>
            </div>
        </div>
    </div>

</div>



</asp:Content>

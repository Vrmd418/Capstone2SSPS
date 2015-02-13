<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Capstone2.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container-fluid">
    
    <div class="row">
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
                    <h1 class="page-header">Contacts</h1>
        </div>           
                
        
    </div>
    
    <div class="row" style ="position: relative ">
        
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
            <div class="panel panel-default" style="margin-left: auto; margin-right: auto; min-width: 275px; position: relative">
                <div style=" font-weight: bold" class="panel-heading">
                    Contact:
                </div>
                <div class="panel-body" style="color: black">
                    <b>Rose McGinnis:</b><br />
                    Instructor, <b>Director Student Career Assistance Center</b><br />
                    Office: SERC 351<br />
                    Phone: (215)204-8289<br />
                    Email:&nbsp;<asp:HyperLink Style="color: blue" ID="RoseEmail" runat="server">rose.mcginnis@temple.edu</asp:HyperLink>
                    
        
        <asp:HyperLink Style="color: blue" ID="RoseEmail2" runat="server">mcginnr@temple.edu</asp:HyperLink>
                </div>
            </div>
        </div>

    </div>
    <div class="row" style ="position: relative ">
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
        
            <div class="panel panel-default" style="margin-left: auto; margin-right: auto; min-width: 275px; position: relative">
                <div style=" font-weight: bold" class="panel-heading">
                    Contact:
                </div>
                <div class="panel-body" style="color: black">
                    <b>Ashley Babladelis:</b><br />
                    Academic Coordinator, Office of Student Services<br />
                    Office:
        <br />
                    Phone: (215)204-5887<br />
                    Email:
        <asp:HyperLink Style="color: blue" ID="AshleyEmail" runat="server">ashley.babladelis@temple.edu</asp:HyperLink>

                     </div>
               </div> 
            </div>
        </div>
    
     </div>
    
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Capstone2.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container">
<div class="row" style ="position: relative ">
        <div class="col-xs-12" style=" position: relative">
            <div class="panel panel-default" style="margin-top: 10%; margin-left: auto; margin-right: auto; width: 85%; min-width: 275px; position: relative">
                <div class="panel-heading">
                    Contact:
                </div>
                <div class="panel-body" style="color: black">
                    <b>Rose McGinnis:</b><br />
                    Instructor, <b>Director Student Career Assistance Center</b><br />
                    Office: SERC 351<br />
                    Phone: (215)204-8289<br />
                    Email:&nbsp;<asp:HyperLink ID="RoseEmail" runat="server">rose.mcginnis@temple.edu</asp:HyperLink>
                    
        
        <asp:HyperLink ID="RoseEmail2" runat="server">mcginnr@temple.edu</asp:HyperLink>
                </div>
            </div>
        </div>
    </div>

        <div class="row" style ="position: relative ">
        <div class="col-xs-12" style ="position: relative ">
            <div class="panel panel-default" style="margin-left: auto; margin-right: auto; width: 85%; min-width: 275px; position: relative">
                <div class="panel-heading">
                    Contact:
                </div>
                <div class="panel-body" style="color: black">
                    <b>Ashley Babladelis:</b><br />
                    Academic Coordinator, Office of Student Services<br />
                    Office:
        <br />
                    Phone: (215)204-5887<br />
                    Email:
        <asp:HyperLink ID="AshleyEmail" runat="server">ashley.babladelis@temple.edu</asp:HyperLink>


                </div>
            </div>
        </div>
    </div>
     </div>

</asp:Content>

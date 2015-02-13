<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="EditApplication.aspx.cs" Inherits="Capstone2.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container-fluid">
        <div class="row" style ="margin-top: 2%; position: relative ">
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
                    <h1 class="page-header">Edit Application</h1>
        </div>           
        </div>
        </div>
        <div class="col-lg-3 cl-md-6">
            </div>
    
        <div class="col-lg-6 col-md-6">
            <div class="panel panel-default" style="min-width: 275px; width: 100%; margin-left: auto; margin-right: auto">
                <div style="font-weight: bold" class="panel-heading">
                    Edit application questions below
                </div>
               
                <div class="panel-body" style="color: black; position: relative">
                                        
                    <div class="col-lg-6 col-md-6">
                    <asp:Label ID="StarLabel" runat="server" Text="* " Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label><asp:Label ID="MobilePhoneLabel" runat="server" Text="Mobile Phone:" ></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="MobilePhoneTextBox" runat="server" style="width: 100%; margin-top:10px; margin-bottom: 20px; position: relative"></asp:TextBox>
                    </div>        
                    
                    <div class="col-lg-6 col-md-6">
                    <asp:Label ID="StarLabel1" runat="server" Text="* " Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label><asp:Label ID="MajorLabel" runat="server" Text="Major:"></asp:Label>
                    <asp:DropDownList class="form-control" ID="MajorDropDownList" runat="server" style="width:100%; margin-top:10px; margin-bottom: 20px; position: relative">
                    <asp:ListItem Value="Select"></asp:ListItem>
                    <asp:ListItem Value="IS&T"></asp:ListItem>
                    </asp:DropDownList>
                    </div>
                   
                    <div class="col-lg-6 col-md-6"> 
                    <asp:Label ID="StarLabel2" runat="server" Text="* " Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label><asp:Label ID="CitizenshipLabel" runat="server" Text="What is your citizenship or immigration status? "></asp:Label>
                    <asp:DropDownList class="form-control" ID="CitizenshipDropDownList" runat="server" style="width:100%; margin-top:10px; margin-bottom: 20px; position: relative">
                    <asp:ListItem Value="Select"></asp:ListItem>
                    <asp:ListItem Value="US Citizen"></asp:ListItem>
                    <asp:ListItem Value="US Permanent Resident"></asp:ListItem>
                    </asp:DropDownList>
                    </div>

                    <div class="col-lg-6 col-md-6">
                    <asp:Label ID="StarLabel3" runat="server" Text="* " Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label><asp:Label ID="HealthScholarsLabel" runat="server" Text="Are you a Health Scholars Student?"></asp:Label>
                    <asp:DropDownList class="form-control" ID="HealthScholarsDropDownList" runat="server" style="width:100%; margin-top:10px; margin-bottom: 20px; position: relative">
                    <asp:ListItem Value="Select"></asp:ListItem>
                    <asp:ListItem Value="Yes"></asp:ListItem>
                    <asp:ListItem Value="No"></asp:ListItem>
                    </asp:DropDownList>
                    </div>
                    
                    <div class="col-lg-4 col-md-6" style="width: 66%">
                     </div>
                    <div class="col-lg-4 col-md-6">
                    <asp:Button class="btn btn-default" ID="SubmitButton" runat="server" Text="Submit" style="width: 100%; margin-bottom: 10px; margin-top: 10px" BackColor="#9E1B34" ForeColor="White" BorderColor="#9E1B34" />                     
                    </div>
                    </div>
                </div>
            </div>
       <%-- </div>
        </div>--%>

</asp:Content>

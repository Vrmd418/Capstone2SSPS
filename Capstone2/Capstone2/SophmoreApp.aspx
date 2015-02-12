<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SophmoreApp.aspx.cs" Inherits="Capstone2.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
                    <h1 class="page-header">Sophomore Application</h1>
        </div>           
                
        
    </div>
    <div class="row">
                   
        <div class="col-lg-3 cl-md-6">
         <div class="panel panel-default" style="min-width: 275px; width: 100%; margin-left: auto; margin-right: auto">
                <div class="panel-heading">
                    Instructions
                </div>
                <div class="panel-body" style="color: black">
                    You may fill out the application in its entirety
                        or you may save and return at a later date.
                        Make sure to complete the application by the deadline.
                </div>
            </div>
        </div>
        
                <div class="col-lg-6 col-md-6">
                    <div class="panel panel-default" style="min-width: 275px; margin-left: auto; margin-right: auto">
                <div class="panel-heading"  >
                    * Denotes a required field.
                </div>
                <div class="panel-body" style="color: black">
                
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
                   
                    <div class="col-lg-12">
                    <asp:Label ID="StarLabel4" runat="server" Text="* " Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label><asp:Label ID="InterestsLabel" runat="server" Text="What are your areas of interest as they relate to potential research?"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="InterestsTextBox" runat="server" style="width: 100%; margin-top:10px; margin-bottom: 20px; position: relative"></asp:TextBox>
                    </div>
                    
                    <div class="col-lg-12">
                    <asp:Label ID="StarLabel5" runat="server" Text="* " Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label><asp:Label ID="ResearchProjectsLabel" runat="server" Text="Did you participate in any research projects/programs in high school or your first year at Temple? If so, please describe."></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="ResearchProjectsTextBox" runat="server" TextMode="MultiLine" style="width: 100%; margin-top:10px; height: 100px; margin-bottom: 20px; position: relative"></asp:TextBox>
                    </div>
                    
                    <div class="col-lg-12">
                    <asp:Label ID="StarLabel6" runat="server" Text="* " Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label><asp:Label ID="AccomplishmentLabel" runat="server" Text="What accomplishment that you have had so far are you most proud of?"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="AccomplishmentTextBox" runat="server" TextMode="MultiLine" style="width: 100%; height: 100px; margin-top:10px; margin-bottom: 20px; position: relative"></asp:TextBox>
                    </div>
                    
                    <div class="col-lg-12">
                    <asp:Label ID="StarLabel7" runat="server" Text="* " Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label><asp:Label ID="UniversityLabel" runat="server" Text="Why did you select Temple University?"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="UniversityTextBox" runat="server" TextMode="MultiLine" style="width: 100%; height: 100px; margin-top:10px; margin-bottom: 20px; position: relative"></asp:TextBox>
                    </div>
                                        
                    <div class="col-lg-12">
                    <asp:Label ID="EssayQuestionsLabel" runat="server" style="width: 100%; position: relative" Font-Size="X-Large" Text="Essay Questions"></asp:Label>
                    </div> 
                    
                    <div class="col-lg-12" style="margin-bottom: 20px">
                    <asp:Label ID="EssayQuestionsLabel2" runat="server" style="width: 100%; position: relative" Text="Please complete the following <b>three essay</b> questions in 250 words or less for each question."></asp:Label> 
                    </div>
                    
                    <div class="col-lg-12">
                    <asp:Label ID="StarLabel8" runat="server" Text="* " Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label><asp:Label ID="Essay1Label" runat="server" Text="Name an invention or discovery you wish you had made and why?"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="Essay1TextBox" runat="server" TextMode="MultiLine" style="width: 100%; height: 100px; margin-top:10px; margin-bottom: 20px; position: relative"></asp:TextBox>
                    </div>
                    
                    <div class="col-lg-12" >
                    <asp:Label ID="StarLabel9" runat="server" Text="* " Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label><asp:Label ID="Essay2Label" runat="server" Text="Tell about the most interesting work you have completed so far in science or technology. If you could continue your work what would be your next step?"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="Essay2TextBox" runat="server" TextMode="MultiLine" style="width: 100%; height: 100px; margin-top:10px; margin-bottom: 20px; position: relative"></asp:TextBox>
                    </div>
                    
                    <div class="col-lg-12" >
                    <asp:Label ID="StarLabel10" runat="server" Text="* " Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label><asp:Label ID="Essay3Label" runat="server" Text="What are your career objectives?"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="Essay3TextBox" runat="server" TextMode="MultiLine" style="width: 100%; height: 100px; margin-top:10px; margin-bottom: 10px; position: relative"></asp:TextBox>
                    </div>
                    
                    <div class="col-lg-4 col-md-6" style="width: 66%">
                    <span>
                    <input  type="file" 
                    style="visibility:hidden; width: 1px;" 
                    id='${multipartFilePath}' name='${multipartFilePath}'  
                    onchange="$(this).parent().find('span').html($(this).val().replace('C:\\fakepath\\', ''))"  /> <!-- Chrome security returns 'C:\fakepath\'  -->
                    <input class="btn btn-default" type="button" value="Upload Resume" onclick="$(this).parent().find('input[type=file]').click();"/> <!-- on button click fire the file click event -->
                    &nbsp;
                    <span  class="badge badge-important" ></span>
                    </span>
                    </div>
                    
                    <div class="col-lg-4 col-md-6">
                    <asp:Button ID="SaveButton" class="btn btn-default" style="margin-top: 20px; margin-bottom: 10px; width: 100%" runat="server" Text="Save" />
                    <asp:Button ID="SubmitButton" class="btn btn-primary" style="margin-bottom: 10px; width: 100%; background-color:#9E1B34" runat="server" Text="Submit" />
            </div>
         </div>
       </div>
     </div>
     </div>

</div>

</asp:Content>

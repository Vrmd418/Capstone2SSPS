<%@ Page Title="" Language="C#" MasterPageFile="~/WithNav.Master" AutoEventWireup="true" CodeBehind="EditDeadlines.aspx.cs" Inherits="Capstone2.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
    <div class="row">
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
                    <h1 class="page-header">Edit Deadlines</h1>
        </div>           
                
        
    </div>
        
        <div class="row" >
        
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
            
            <div class="panel panel-default" >
                <div style="font-weight: bold" class="panel-heading">
                   <asp:Label ID="AcademicYearLabel" runat="server" Text="Academic Year" style="left: 3%"></asp:Label>
                </div>
                <div class="panel-body" style="color: black">
                    <div class="col-lg-8 cl-md-8">
                     </div>
                    

                   
                    
                    
                    <div class="col-lg-8 cl-md-12">
                    <asp:Label ID="ApplicationDeadlineLabel" runat="server" Style="display:block; left:3%; margin-top: 10px" Text="Application Deadline" ></asp:Label>
                    
                        <asp:LinkButton ID="ApplicationDeadlineLinkButton" runat="server" style="display:block; margin-top: 3px; margin-left: 2px" OnClick="ApplicationDeadlineLink_OnClick"><span class="glyphicon glyphicon-calendar " style="margin-top: 10px; float: left; color: #9E1B34; font-size:155%; margin-top:10px; padding-right: 10px;"></span></asp:LinkButton><asp:TextBox ID="ApplicationDeadlineTextBox" CssClass="form-control" Style="width: 89%; margin-top: 10px; margin-bottom:0px" runat="server" Enabled="False"></asp:TextBox>
                        
                    </div>
                    <div>
                    <div class="col-lg-8 cl-md-12">
                    <asp:Label ID="DocumentDeadlineLabel" runat="server" Style="display:block; left:3%; margin-top: 10px" Text="Document Deadline" ></asp:Label>
                    
                        <asp:LinkButton ID="DocumentDeadlineLinkButton" runat="server" style="display:block; margin-top: 3px; margin-left: 2px" OnClick="DocumentDeadlineLink_OnClick"><span class="glyphicon glyphicon-calendar " style="margin-top: 10px; float: left; color: #9E1B34; font-size:155%; margin-top:10px; padding-right: 10px;"></span></asp:LinkButton><asp:TextBox ID="DocumentDeadlineTextBox" CssClass="form-control" Style="width: 89%; margin-top: 10px; margin-bottom:0px" runat="server" Enabled="False"></asp:TextBox>
                        
                    </div>
                    </div>
                    <div class="col-lg-8 cl-md-12">
                    <asp:Label ID="RankDeadlineLabel" runat="server" Style="display:block; left:3%; margin-top: 10px" Text="Rank Deadline" ></asp:Label>
                    
                        <asp:LinkButton ID="RankDeadlineLinkButton" runat="server" style="display:block; margin-top: 3px; margin-left: 2px" OnClick="RankDeadlineLink_OnClick"><span class="glyphicon glyphicon-calendar " style=" margin-right: 1%; margin-top: 10px; float: left; color: #9E1B34; font-size:155%; margin-top:10px; padding-right: 10px;"></span></asp:LinkButton><asp:TextBox ID="RankDeadlineTextBox" CssClass="form-control" Style="width: 89%; margin-top: 10px; margin-bottom: 10px" runat="server" Enabled="False"></asp:TextBox>
                        
                    </div>
                       <div class="col-lg-4 col-md-12"> <asp:Button OnClientClick="SubmitButton()" ID="SibmitButton" class="btn btn-sm" OnClick="SubmitButton_OnClick" style="margin-top: 40px; margin-bottom:20px; width: 100%; background-color:#9E1B34; color:white" runat="server" Text="Update" />
                        <script>
                            function SubmitButton() {
                                alert("The deadlines were successfully updated");
                            }
                        </script>
                       
                       </div>
                              <%--<div class="col-lg-8 cl-md-8">--%>         
                    <asp:Calendar ID="Calendar1" runat="server" Visible="false" Width="200px" Height="100px" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" NextPrevFormat="FullMonth" Style="background-color: white; position:absolute; left: 35%; top: 30%; border-width: 1px; border-style: solid; border-color: #9E1B34" TitleFormat="Month">
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt"></DayHeaderStyle>

                        <DayStyle Width="14%"></DayStyle>

                        <NextPrevStyle Font-Size="8pt" ForeColor="White"></NextPrevStyle>

                        <OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>

                        <SelectedDayStyle BackColor="#CC3333" ForeColor="White"></SelectedDayStyle>

                        <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%"></SelectorStyle>

                        <TitleStyle BackColor="#9E1B34" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt"></TitleStyle>

                        <TodayDayStyle BackColor="#CCCC99"></TodayDayStyle>
                    </asp:Calendar>
                    <%--</div>--%>
                    <%--<div class="col-lg-12 col-md-12">
                    <div class="col-lg-8 col-md-12">--%>
                    
                   <%-- </div>--%>
                    
                    
                    <%--</div>--%>
                 </div>
            </div>
            </div>
        </div>
    </div>

<%--</div>--%>







</asp:Content>

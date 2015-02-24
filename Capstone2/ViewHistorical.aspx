<%@ Page Title="" Language="C#" MasterPageFile="~/WithNav.Master" AutoEventWireup="true" CodeBehind="ViewHistorical.aspx.cs" Inherits="Capstone2.WebForm9" %>
<%--Main--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container-fluid">
    
    <div class="row">
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
                    <h1 class="page-header">View Historical Data</h1>
        </div>           
                
        
    </div>
    
    <div class="row" style ="position: relative ">
        
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
            <div class="panel panel-default">
                <div style=" font-weight: bold" class="panel-heading">
                    Search Historical Data:
                </div>
                <div class="panel-body" style="padding-left: 20px; color: black">
                    
                    <div class="col-lg-6 col-md-6">
                    <asp:Label ID="AcademicYearLabel" runat="server" Text="Academic Year:"></asp:Label>
                    <asp:DropDownList class="form-control" ID="AcademicYearDropDownList" runat="server" style="width:100%; margin-top:10px; margin-bottom: 20px; position: relative">
                    <asp:ListItem Value="Select"></asp:ListItem>
                    <asp:ListItem Value="2014-2015"></asp:ListItem>
                    </asp:DropDownList>
                    </div>        
                    
                    <div class="col-lg-6 col-md-6">
                    <asp:Label ID="MajorLabel" runat="server" Text="Major:"></asp:Label>
                    <asp:DropDownList class="form-control" ID="MajorDownList" runat="server" style="width:100%; margin-top:10px; margin-bottom: 20px; position: relative">
                    <asp:ListItem Value="Select"></asp:ListItem>
                    <asp:ListItem Value="CIS"></asp:ListItem>
                    </asp:DropDownList>
                    </div>

                    <div class="col-lg-6 col-md-6">
                    <asp:Label ID="FirstNameLabel" runat="server" Text="First Name:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="FirstNameTextBox" runat="server" style="width: 100%; margin-top:10px; margin-bottom: 20px; position: relative"></asp:TextBox>
                    </div>
                   
                    <div class="col-lg-6 col-md-6"> 
                    <asp:Label ID="LastNameLabel" runat="server" Text="Last Name:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="LastNameTextBox" runat="server" style="width: 100%; margin-top:10px; margin-bottom: 20px; position: relative"></asp:TextBox>
                    </div>

                    
                    
                    <div class="col-lg-4 col-md-6" style="width: 66%">
                     </div>
                    <div class="col-lg-4 col-md-6">
                    <asp:Button class="btn btn-default" ID="SearchButton" runat="server" Text="Search" BorderColor="#9E1B34" style="width: 100%; margin-bottom: 10px" BackColor="#9E1B34" ForeColor="White"/>                     
                    </div>
                    </div>
                    
                   
                    <asp:GridView ID="ViewHistoricalGridView" runat="server" Style="margin-top:5px; margin-bottom: 2%; margin-left: auto; margin-right: auto; position: relative; width: 94%" AutoGenerateColumns="False" Width="800px">
                        <Columns>
                            <asp:BoundField DataField="firstName" HeaderText="First Name" >
                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

                                <ItemStyle Width="20%"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="lastName" HeaderText="Last Name">
                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

                                <ItemStyle Width="20%"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="academicYear" HeaderText="Academic Year">
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                                <ItemStyle HorizontalAlign="Center" Width="15%"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="major" HeaderText="Major">
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                                <ItemStyle HorizontalAlign="Center" Width="15%"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="rank" HeaderText="Rank">
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                                <ItemStyle HorizontalAlign="Center" Width="15%"></ItemStyle>
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="View Application">
                                <ItemTemplate>
                                    <asp:Button ID="ViewApplicationButton" CssClass="btn btn-primary btn-xs" BackColor="#9E1B34" Style="width: 100%" runat="server" Text="Open" />
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                                <ItemStyle HorizontalAlign="Center" Width="15%"></ItemStyle>
                            </asp:TemplateField>
                        </Columns>
                        <HeaderStyle BackColor="#9e1b34" Font-Bold="True" ForeColor="White" />
                    </asp:GridView>
                    </div>
                <br />
            </div>
        </div>
    </div>

     
</asp:Content>

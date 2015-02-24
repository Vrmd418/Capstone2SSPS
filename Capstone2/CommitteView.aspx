<%@ Page Title="" Language="C#" MasterPageFile="~/WithNav.Master" AutoEventWireup="true" CodeBehind="CommitteView.aspx.cs" Inherits="Capstone2.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container-fluid">
    
    <div class="row">
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
                    <h1 class="page-header">Committe View</h1>
        </div>           
                
        
    </div>

<div class="row" style ="position: relative ">
        
        <div class="col-lg-3 cl-md-6"></div>
        <div class="col-lg-6 cl-md-6">
            <div class="panel panel-default">
                <div style=" font-weight: bold" class="panel-heading">
                    Committe View
                </div>
                <div class="panel-body" style="padding-left: 20px; color: black">
                    <div class="col-lg-8 col-md-12" >
                    <div class="col-lg-12 col-md-12">
                    <asp:Label ID="AcademicYearLabel" runat="server" Text="Academic Year:"></asp:Label>
                    <asp:DropDownList class="form-control" ID="AcademicYearDropDownList" runat="server" style="width:100%; margin-top:10px; margin-bottom: 20px; position: relative">
                    <asp:ListItem Value="Select"></asp:ListItem>
                    <asp:ListItem Value="2014-2015"></asp:ListItem>
                    </asp:DropDownList>
                    </div>        
                    
                    <div class="col-lg-12 col-md-12">
                    <asp:Label ID="MajorLabel" runat="server" Text="View Students By:"></asp:Label>
                    <asp:DropDownList class="form-control" ID="MajorDropDownList" runat="server" style="width:100%; margin-top:10px; margin-bottom: 20px; position: relative">
                    <asp:ListItem Value="Select"></asp:ListItem>
                       </asp:DropDownList>
                    </div>
                         </div>
                                     
                    <div class="col-lg-4 col-md-12">
                     <%--</div>--%>
                    <div class="col-lg-12 col-md-12">
                    <asp:Button class="btn btn-default" ID="SearchButton" runat="server" Text="Search" BorderColor="#9E1B34" style=" width:100%; margin-top: 30px; margin-bottom: 10px" BackColor="#9E1B34" ForeColor="White" />                     
                   </div>
                   <%-- <div class="col-lg-12 col-md-6" style="width: 66%">--%>
                    
                    <div class="col-lg-12 col-md-12">
                    <asp:Button class="btn btn-default" ID="SelectButton" runat="server" BorderColor="#9E1B34" Text="Download Selected" style="width:100%; margin-bottom: 10px" BackColor="#9E1B34" ForeColor="White" />                     
                    </div>
                   <%-- <div class="col-lg-4 col-md-6" style="width: 66%">
                     </div>--%>
                    <div class="col-lg-12 col-md-12">
                    <asp:Button class="btn btn-default" ID="ExportDataButton" runat="server" BorderColor="#9E1B34" Text="Export Data" style="width:100%; margin-bottom: 10px" BackColor="#9E1B34" ForeColor="White" />                     
                    </div> 
                </div>
                
                <%--</div>--%>
                    
                   
                    <asp:GridView ID="ViewHistoricalGridView" runat="server" Style="margin-top:5px; margin-bottom: 2%; margin-left: auto; margin-right: auto; position: relative; width: 94%" AutoGenerateColumns="False" Width="800px">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox" runat="server" />
                                </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" Width="5%"></ItemStyle>
                            </asp:TemplateField>

                            <asp:BoundField DataField="tuid" HeaderText="TU ID" >
                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

                                <ItemStyle Width="18%"></ItemStyle>
                            </asp:BoundField>
                                <asp:BoundField DataField="firstName" HeaderText="First Name" >
                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

                                <ItemStyle Width="18%" ></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="lastName" HeaderText="Last Name">
                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

                                <ItemStyle Width="18%" ></ItemStyle>
                            </asp:BoundField>
                           
                            <asp:BoundField DataField="major" HeaderText="Major">
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                                <ItemStyle HorizontalAlign="Center" Width="16%"></ItemStyle>
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="Rank">
                                <ItemTemplate>
                                    <asp:DropDownList ID="DropDownList" runat="server">
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                    </asp:DropDownList>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                                <ItemStyle HorizontalAlign="Center" Width="18%"></ItemStyle>
                            </asp:TemplateField>
                                <asp:TemplateField >
                                <ItemTemplate>
                                    <asp:Button ID="ViewApplicationButton" CssClass="btn btn-primary btn-xs" BackColor="#9E1B34" Style="width: 100%" runat="server" Text="Open" />
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                                <ItemStyle HorizontalAlign="Center" Width="7%" ></ItemStyle>
                            </asp:TemplateField>
                            <asp:TemplateField></asp:TemplateField>
                                               
                        </Columns>
                        <HeaderStyle BackColor="#9e1b34" Font-Bold="True" ForeColor="White" />
                    </asp:GridView>
                    </div>

            </div>
                <br />
            </div>
        </div>
    </div>


</asp:Content>

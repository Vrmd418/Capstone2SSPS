<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="workingpage.aspx.cs" Inherits="Capstone2.workingpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" Height="108px" TextMode="MultiLine" Width="281px"></asp:TextBox>
    
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" Height="47px" style="z-index: 1; left: 422px; top: 96px; position: absolute; height: 50px; width: 265px" Width="265px">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:RadioButtonList>
    
    </div>
        
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"><asp:RadioButton ID="RadioButton1" runat="server" style="z-index: 1; left: 177px; top: 127px; position: absolute" />
        <asp:RadioButton ID="RadioButton2" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" /></asp:PlaceHolder>
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="195px" Width="800px">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox1" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="firstName" HeaderText="First Name" />
                            <asp:BoundField DataField="lastName" HeaderText="Last Name" />
                            <asp:BoundField DataField="academicYear" HeaderText="Academic Year"></asp:BoundField>
                            <asp:BoundField DataField="rank" HeaderText="Rank"></asp:BoundField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="Button1" runat="server" Text="Button" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:DropDownList ID="DropDownList" runat="server">
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                    </asp:DropDownList>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#9e1b34" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#9e1b34" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </form>
</body>
</html>

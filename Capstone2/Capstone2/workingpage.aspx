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
    </form>
</body>
</html>

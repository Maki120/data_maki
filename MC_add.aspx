<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MC_add.aspx.cs" Inherits="WebApplication1_0921.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">   
        


        帳號：<asp:TextBox ID="MC_pid" runat="server" required="required"></asp:TextBox>
        <br />
         密碼：<asp:TextBox ID="MC_pwd" runat="server" required="required"></asp:TextBox><br />
         姓名：<asp:TextBox ID="MC_name" runat="server" required="required"></asp:TextBox><br />
         電話：<asp:TextBox ID="MC_tel" runat="server" required="required"></asp:TextBox><br />  
         E-Mail：<asp:TextBox ID="MC_email" runat="server" required="required"></asp:TextBox><br />
         <asp:Button ID="B1" runat="server" Text="新增" OnClick="B1_Click" /><br />
         <asp:Label ID="Msg1" runat="server" ForeColor="#ff0000" Text=""></asp:Label>
      
        <br /><br />

       

    </form>
</body>
</html>
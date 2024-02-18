<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MC_WebForm1.aspx.cs" Inherits="WebApplication1_1207.MC_WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Button ID="Button1" runat="server" Text="資料型態" BackColor="#0033cc" Height="40px" OnClick="Button1_Click" Width="177px" />
        <asp:Button ID="Button2" runat="server" Text="判斷式" BackColor="#CCFF33" Height="41px" OnClick="Button1_Click2" Width="177px" />
        <asp:Button ID="Button3" runat="server" Text="轉址" BackColor="#33CCCC" Height="41px" OnClick="Button1_Click3" Width="177px" />
        
        <br />

        <asp:Button ID="Button4" runat="server" Text="BMI" BackColor="#9999FF" Height="41px" OnClick="Button1_Click4" Width="177px" />     
        <asp:Button ID="Button5" runat="server" Text="九九乘法" BackColor="#CC66FF" Height="41px" OnClick="Button1_Click5" Width="177px" />
        <a href="https://www.youtube.com/watch?v=h36oAI9N994" target="_blank">one piece</a>
       
        <br /><br /><br />

        <asp:Label ID="Label1" runat="server" Text="帳號:"></asp:Label>
        <asp:TextBox ID="pid" runat="server"></asp:TextBox>       
       
        <br />

        <asp:Label ID="Label2" runat="server" Text="密碼:"></asp:Label>
        <asp:TextBox ID="pvd" runat="server"></asp:TextBox>
      
        <br />

        <asp:Button ID="Button6" runat="server" Text="登入"  BackColor="#999999" Height="32px" OnClick="Button1_Click6" Width="126px" />
         <asp:Label ID="msg3" runat="server" ForeColor="Red"></asp:Label>


        </div>
    </form>
</body>
</html>

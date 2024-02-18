<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MC_search.aspx.cs" Inherits="WebApplication1_1207.MC_search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="100%" border="0">
 	 <tr>
  	     <td width="80%">
    
		 關鍵字：<asp:textbox runat="server" id="Wkey" size="10" />
		 <asp:Button runat="server" ID="b1" Text="查　　詢" OnClick="Button_Click"/>

		 </td>
  	     <td width="20%" align="right">
		     <a href="MC_add.aspx" class="style1">新增使用者</a>
		 </td>
 	 </tr>
	</table>


        <table width="100%" border="1" bordercolorlight="#04A3DF" cellspacing="0" bordercolordark="#FFFFFF">
          <tr> 
			<td background="images/bg4.jpg" align="center"><font color="#000000"><strong>會員資料</strong></font></td>
          </tr>
             <tr> 
		    	<td>
	<asp:SqlDataSource ID="MyDataSource" runat="server" />	
	<asp:GridView runat="server" id="MyGridView" DataSourceID="MyDataSource" Width="100%" 
     HeaderStyle-ForeColor="#333333"   
     BorderColor="#CCCCCC" 
	 CellPadding="4" 
	 Font-Size="12pt" 
	 HeaderStyle-BackColor="#CCCCCC"
	 HeaderStyle-HorizontalAlign="left"
	 RowStyle-BackColor="#ffffff" 
	 AlternatingRowStyle-BackColor="#D5D9FD"  
	 AllowPaging="true" 
	 PageSize="20"  
	 PagerStyle-HorizontalAlign="Right"
	 OnPageIndexChanging="PageIndexChanging"
	 DataKeyField="MC_id"
     AutoGenerateColumns="false">
	 <pagersettings mode="Numeric" position="TopAndBottom" pagebuttoncount="10"/>
     <Columns>
	  <asp:TemplateField HeaderText="<nobr>修改</nobr>">
       <ItemTemplate>
		  <asp:Label runat="server" Text='<%# transfer_link(DataBinder.Eval(Container.DataItem,"MC_id").ToString()) %>'/>	  
	   </ItemTemplate>	   
	   </asp:TemplateField>
	  <asp:TemplateField HeaderText="<nobr>刪除</nobr>">
       <ItemTemplate>
		  <asp:Label runat="server" Text='<%# del_link(DataBinder.Eval(Container.DataItem,"MC_id").ToString()) %>'/>	  
	   </ItemTemplate>	   
	   </asp:TemplateField>
	  <asp:TemplateField HeaderText="<nobr>姓名</nobr>">
       <ItemTemplate>
		  <asp:Label runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MC_name").ToString() %>'/>	  
	   </ItemTemplate>	   
	   </asp:TemplateField>
	  <asp:TemplateField HeaderText="<nobr>帳號</nobr>">
       <ItemTemplate>
		  <asp:Label runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MC_pid").ToString() %>'/>	  
	   </ItemTemplate>	   
	   </asp:TemplateField>
	  <asp:TemplateField HeaderText="<nobr>密碼</nobr>">
       <ItemTemplate>
		  <asp:Label runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MC_pwd").ToString() %>'/>	  
	   </ItemTemplate>	   
	   </asp:TemplateField>
	  <asp:TemplateField HeaderText="<nobr>電話</nobr>">
       <ItemTemplate>
		  <asp:Label runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MC_tel").ToString() %>'/>	  
	   </ItemTemplate>	   
	   </asp:TemplateField>
	 </Columns>
</asp:GridView>
			    </td>
               </tr>
	        </table>
<p align="center"> 

<asp:label runat="server" ID="msg1" /> 
<asp:label runat="server" ID="PSQL" Visible="false" /> 

   </p>  

        </div>
    </form>
</body>
</html>

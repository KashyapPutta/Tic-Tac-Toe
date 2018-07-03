<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewResults.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form id="form1" runat="server">


    <style>
        .mydatagrid
{
	width: 80%;
	border: solid 2px black;
	min-width: 80%;
}
.header
{
	background-color: #646464;
	font-family: Arial;
	color: White;
	border: none 0px transparent;
	height: 25px;
	text-align: center;
	font-size: 16px;
}

.rows
{
	background-color: #fff;
	font-family: Arial;
	font-size: 14px;
	color: #000;
	min-height: 25px;
	text-align: left;
	border: none 0px transparent;
}
.rows:hover
{
	background-color: #ff8000;
	font-family: Arial;
	color: #fff;
	text-align: left;
}
.selectedrow
{
	background-color: #ff8000;
	font-family: Arial;
	color: #fff;
	font-weight: bold;
	text-align: left;
}
.mydatagrid a /** FOR THE PAGING ICONS  **/
{
	background-color: Transparent;
	padding: 5px 5px 5px 5px;
	color: #fff;
	text-decoration: none;
	font-weight: bold;
}

.mydatagrid a:hover /** FOR THE PAGING ICONS  HOVER STYLES**/
{
	background-color: #000;
	color: #fff;
}
.mydatagrid span /** FOR THE PAGING ICONS CURRENT PAGE INDICATOR **/
{
	background-color: #c9c9c9;
	color: #000;
	padding: 5px 5px 5px 5px;
}
.pager
{
	background-color: #646464;
	font-family: Arial;
	color: White;
	height: 30px;
	text-align: left;
}

.mydatagrid td
{
	padding: 5px;
}
.mydatagrid th
{
	padding: 5px;
}

    </style>



    <div>
    
        <asp:GridView ID="Results" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" DataKeyNames="Id">
            <Columns>
                <%--<asp:BoundField DataField="Id" HeaderText="S.no" SortExpression="S.no" />--%>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" InsertVisible="False" ReadOnly="True" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                <asp:BoundField DataField="UserWins" HeaderText="UserWins" SortExpression="UserWins" />
                
                <asp:BoundField DataField="MachineWins" HeaderText="MachineWins" SortExpression="MachineWins" />
                
            </Columns>
            <HeaderStyle CssClass="header" />
            <PagerStyle CssClass="pager" />
            <RowStyle CssClass="rows" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Database WinStatus.DataModel.WinStatus.Context %>" SelectCommand="SELECT [Id], [UserName], [UserWins], [MachineWins] FROM [WinClasses]"></asp:SqlDataSource>
        
        
        
    <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go Back" />
        <br />
        <br />

    </div>

        <div>
            
        </div>
    </form>
</body>
</html>

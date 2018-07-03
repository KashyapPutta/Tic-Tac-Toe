<%@ Page Title="TIC TAC TOE" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .layout {
            max-width: 800px;
            margin: auto auto auto 220px;
            background: #ffffff;
            opacity: 0.9;
            padding: 10px;
            height: 500px;
            width: 500px;
            position: relative;
            top: 4px;
            left: 334px;
        } 
    </style>

    <style>
        .options {
            max-width: 400px;
            margin: auto auto auto 220px;
            background: #ffffff;
            padding: 10px;
            height: 563px;
            width: 407px;
            position: relative;
            top: -583px;
            left: -217px;
        }
    </style>


    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-responsive.css" rel="stylesheet" />
    <link href="ButtonsStyleSheet.css" rel="stylesheet" />

    <br />

    <div class="layout">
        <asp:Button ID="Button1" runat="server" Text="1" Font-Bold="True" Width="150px" OnClick="Button1_Click" CssClass="Button" Font-Size="XX-Large" ForeColor="White" Font-Strikeout="False" />
        <asp:Button ID="Button2" runat="server" Text="2" Font-Bold="True" Width="150px" OnClick="Button2_Click" Height="150px" CssClass="Button" Font-Size="XX-Large" ForeColor="White" />
        <asp:Button ID="Button3" runat="server" Text="3" Font-Bold="True" Width="150px" OnClick="Button3_Click" Height="150px" CssClass="Button" Font-Size="XX-Large" ForeColor="White" />

        <br />

        <asp:Button ID="Button4" runat="server" Text="4" Font-Bold="True" Width="150px" OnClick="Button4_Click" Height="150px" CssClass="Button" Font-Size="XX-Large" ForeColor="White" />
        <asp:Button ID="Button5" runat="server" Text="5" Font-Bold="True" Width="150px" OnClick="Button5_Click" Height="150px" CssClass="Button" Font-Size="XX-Large" ForeColor="White" />
        <asp:Button ID="Button6" runat="server" Text="6" Font-Bold="True" Width="150px" OnClick="Button6_Click" Height="150px" CssClass="Button" Font-Size="XX-Large" ForeColor="White" />

        <br />

        <asp:Button ID="Button7" runat="server" Text="7" Font-Bold="True" OnClick="Button7_Click" CssClass="Button" Font-Size="XX-Large" ForeColor="White" Height="150px" Width="150px" />
        <asp:Button ID="Button8" runat="server" Text="8" Font-Bold="True" Width="150px" OnClick="Button8_Click" Height="150px" CssClass="Button" Font-Size="XX-Large" ForeColor="White" />
        <asp:Button ID="Button9" runat="server" Text="9" Font-Bold="True" OnClick="Button9_Click" CssClass="Button" Font-Size="XX-Large" ForeColor="White" Height="150px" Width="150px" />


	</div>




    <style>
        body {
            background-image: url("images/default_background.png");
            /*<div align="center" style="background-color: transparent; background-image: url(default_background.png);">*/
        }
        .layout {
            position: relative;
            top: 34px;
            left: 329px;
            height: 567px;
            width: 496px;
        }
    </style>




    <div class="options">


        <span style="font-size: 26px; font-weight: bold">USER:</span>
        <asp:TextBox ID="UserNameDisplay" runat="server" align=" center" Style="text-align: center" Font-Size="30pt" BackColor="Blue" BorderColor="Red" BorderWidth="10px" CssClass="alert-warning" ForeColor="White" Height="60px" ReadOnly="True" Width="150px" ClientIDMode="Static"></asp:TextBox>
        <span style="font-size: 26px; font-weight: bold">
            <br />
            <br />
            Computer Choice:</span>
        <asp:TextBox ID="ComputerChoiceTextBox" runat="server" align=" center" Style="text-align: center" Font-Size="30pt" BackColor="Blue" BorderColor="Red" BorderWidth="10px" CssClass="alert-warning" ForeColor="White" Height="87px" ReadOnly="True" Width="94px" ClientIDMode="Static"></asp:TextBox>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/NewGame.png" OnClick="ImageButton1_Click" Style="z-index: 1; left: -4px; top: 31px; position: relative; height: 75px; width: 166px; margin-top: 26px;" />
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/Results.gif" OnClick="ImageButton2_Click" Style="z-index: 1; top: 30px; position: relative; height: 73px; width: 173px; margin-top: 26px;" />


        <span style="font-size: 26px; font-weight: bold">
            <br />
            <br />

            Win Status</span>
        <asp:TextBox ID="WinStatusBox" runat="server" align=" center" Style="text-align: center; z-index: 1; left: 9px; top: 421px; position: absolute;" Font-Size="20pt" BackColor="Blue" BorderColor="Red" BorderWidth="10px" CssClass="alert-warning" ForeColor="White" Height="87px" ReadOnly="True" Width="300px" ClientIDMode="Static" TextMode="MultiLine"></asp:TextBox>

    </div>

    


</asp:Content>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="WebApplication2.UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    
<head runat="server">
    
    <style>
        body {
            background-color: burlywood;
        }
    </style>
    <title>Login</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <style>
        
        .content {
            max-width: 400px;
            margin: auto;
            background: #ffffff;
            opacity: 0.8;
            padding: 10px;
        }
    </style>

    <style>
        body {
            background-image: url("images/photo.jpg");
        }
        #form1 {
            height: 205px;
            width: 760px;
        }
    </style>
</head>
   

    <body>
        
       <h1 align="center">Welcome to TIC TAC TOE</h1>
   
<div class="content">

   
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-responsive.css" rel="stylesheet" />
    <link href="ButtonsStyleSheet.css" rel="stylesheet" />

    <form id="form1" runat="server">
         Please Enter Your UserName in the TextBox below:
       <div style="position: relative; top: 5px; left: 3px; width: 474px;">
            
        <div style="font-size:20px">Username:<asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox>
            </div>
         
        <asp:RequiredFieldValidator runat="server" id="UserNameRequired" controltovalidate="UserNameTextBox" errormessage="Please enter your name!" />
    <br />
		   
      
        
          <div style="font-size:20px">Password:<asp:TextBox ID="PasswordBox" runat="server"></asp:TextBox>
            </div>

          <asp:RequiredFieldValidator runat="server" id="PasswordRequired" controltovalidate="PasswordBox" errormessage="Please enter your name!" />
    <br />
           &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
           <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign In" CssClass="SignInButton" Height="50px" Width="150px" />
           &nbsp&nbsp&nbsp 
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Sign Up" CssClass="SignUpButton" Height="50px" Width="150px" />

        </div>

    </form>

     </div>
</body>


</html>

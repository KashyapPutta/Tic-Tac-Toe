using System;



namespace WebApplication2
{


    public partial class UserLogin : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {

        }

        public void Button1_Click(object sender, EventArgs e)
        {

            ConsoleApplication1.Program check = new ConsoleApplication1.Program();
            string password = PasswordBox.Text;
            string player = UserNameTextBox.Text;
            int x = check.QueryIfUserNameAndPasswordExists(password, player);
            if (x == 1)
            {
                Session["UserName"] = UserNameTextBox.Text;
                Session["Password"] = PasswordBox.Text;
                Response.Redirect("~/Default.aspx");
            }

            else if (x == 0)
            {
                //Response.Redirect("~/UserLogin.aspx");
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Wrong Password, Try again !');", true);
            }

            else if (x == 2)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('User not found, please signup');", true);
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string password = PasswordBox.Text;
            string player = UserNameTextBox.Text;
            Session["UserName"] = UserNameTextBox.Text;
            Session["Password"] = PasswordBox.Text;
            ConsoleApplication1.Program enquiry = new ConsoleApplication1.Program();
            int y = enquiry.SignUPEnquiryIfUserNameExists(password, player);

            if(y==3)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('UserAlreadyExists, Please Signin');", true);
            }

            else if (y==4)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Login successful');", true);
                Response.Redirect("~/Default.aspx");
            }

            //else if(y==5)
            //{
            //    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No Data in Database');", true);
            //}
            

        }
    }
}
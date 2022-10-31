using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;
using System.Data.Linq;
using System.Configuration;

namespace WebApplication2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
                ViewState["LoginErrors"] = 0;
        }

        private bool ValidationFunct(string username, string password)
        {
            DataClasses1DataContext _usercontext = new DataClasses1DataContext();
            bool returnvalue = false;

            int result = _usercontext.User_check(username, password);
            if (result == 1)
            {
                returnvalue = true;
            }

            return returnvalue;
        }

        protected void Login1_Authenticate1(object sender, AuthenticateEventArgs e)
        {
            if (ValidationFunct(Login1.UserName, Login1.Password))
            {
                Login1.Visible = false;
                Label1.Visible = true;
                Session["Username"] = Login1.UserName;
                Label1.Text = "Successful Login";
                Response.Redirect("master.aspx");
            }
            else
            {
                e.Authenticated = false;
            }
        }

        protected void Login1_LoginError1(object sender, EventArgs e)
        {
            if (ViewState["LoginErrors"] == null) ViewState["LoginErrors"] = 0;
            int ErrorCount = (int)ViewState["LoginErrors"] + 1;
            ViewState["LoginErrors"] = ErrorCount;
            if (ErrorCount > 3)
            {
                Login1.InstructionText = "Wrong username or password.";
            }
        }
    }
}
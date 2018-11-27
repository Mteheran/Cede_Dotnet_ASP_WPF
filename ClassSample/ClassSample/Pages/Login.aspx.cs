using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassSample.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_LoggedIn(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (user.Text == "admin" && password.Text == "123")
            {
                FormsAuthentication.RedirectFromLoginPage("admin", true);
            }
            else
            {
                Response.Write("Usuario o contrasena invalida");
            }
        }

        public string GetHellowordl()
        {
            return "qqqq";
        }
    }
}
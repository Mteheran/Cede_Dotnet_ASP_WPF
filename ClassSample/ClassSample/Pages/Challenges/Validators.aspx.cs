using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassSample.Pages.Challenges
{
    public partial class Validators : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUser.Text))
            {
                throw new Exception("Usuario requerido");
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                throw new Exception("Contraseña requerido");
            }
            
        }
    }
}
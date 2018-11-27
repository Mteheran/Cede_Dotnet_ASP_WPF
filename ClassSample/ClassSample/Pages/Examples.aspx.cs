using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassSample.Pages
{
    public partial class Examples : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Titulo desde el servidor";
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lblCalendar.Text = ((Calendar)sender).SelectedDate.ToString("yyyy-MM-dd");
            lblCalendar.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
        }
    }
}
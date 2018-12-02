using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassSample.Pages
{
    public partial class EditDeparment : System.Web.UI.Page
    {

        Deparment deparment { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            lblID.Text = Request.QueryString["id"].ToString();
            deparment = DataAccess.DeparmentData.GetDeparmentByID(int.Parse(Request.QueryString["id"].ToString()));
            txtName.Text = deparment.Name;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            deparment.Name = txtName.Text;
            DataAccess.DeparmentData.UpdateDeparment(deparment);
            Response.Redirect("Deparments.aspx");
        }
    }
}
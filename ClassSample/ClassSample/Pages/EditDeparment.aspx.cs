﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassSample.Pages
{
    public partial class EditDeparment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblID.Text = Request.QueryString["id"].ToString();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OSPS
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            l2.Text = Session["value"].ToString();
        }
        protected void logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }
    }
}